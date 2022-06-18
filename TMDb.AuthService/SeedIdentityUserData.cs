using System.Security.Claims;
using IdentityModel;
using TMDb.AuthService.Data;
using TMDb.AuthService.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace TMDb.AuthService;

public class SeedIdentityUserData
{
    public static async Task EnsureSeedDataAsync(WebApplication app)
    {
        using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var context = scope.ServiceProvider.GetService<AspNetIdentityDbContext>();
            context.Database.Migrate();

            var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<TMDbUser>>();
            var roleMgr = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var AdminRole = await roleMgr.RoleExistsAsync("Admin");
            var UserRole = await roleMgr.RoleExistsAsync("User");
            if (!AdminRole && !UserRole)
            {
                await roleMgr.CreateAsync(new IdentityRole { Name = "Admin" });
                await roleMgr.CreateAsync(new IdentityRole { Name = "User" });
            }
            var alice = userMgr.FindByNameAsync("alice").Result;
            if (alice != null)
            {

                var isDeleted = userMgr.DeleteAsync(alice);
                if(isDeleted.IsCompletedSuccessfully)
                {
                    Log.Debug("Yay she's gone!");
                
                    alice = new TMDbUser
                    {
                        UserName = "alice",
                        Email = "AliceSmith@email.com",
                        FirstName = "Alice",
                        LastName = "Smith",
                        CreatedDate = DateTime.Now,
                        EmailConfirmed = true,
                    };
                    var result = userMgr.CreateAsync(alice, "Pass123$").Result;
                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }

                    await userMgr.AddToRoleAsync(alice, "Admin");
                    await userMgr.AddToRoleAsync(alice, "User");

                    result = userMgr.AddClaimsAsync(alice, new Claim[]{
                                new Claim(JwtClaimTypes.Name, "Alice Smith"),
                                new Claim(JwtClaimTypes.GivenName, "Alice"),
                                new Claim(JwtClaimTypes.FamilyName, "Smith"),
                                new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                                new Claim(JwtClaimTypes.Role, "Admin"),
                                new Claim(JwtClaimTypes.Role, "User")
                            }).Result;
                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                    Log.Debug("alice created");
                }
                else
                {
                    throw new Exception();
                }

            }
            else
            {

                alice = new TMDbUser
                {
                    UserName = "alice",
                    Email = "AliceSmith@email.com",
                    FirstName = "Alice",
                    LastName = "Smith",
                    CreatedDate = DateTime.Now,
                    EmailConfirmed = true,
                };
                var result = userMgr.CreateAsync(alice, "Pass123$").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                await userMgr.AddToRoleAsync(alice, "Admin");
                await userMgr.AddToRoleAsync(alice, "User");

                result = userMgr.AddClaimsAsync(alice, new Claim[]{
                            new Claim(JwtClaimTypes.Name, "Alice Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Alice"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                            new Claim(JwtClaimTypes.Role, "Admin"),
                            new Claim(JwtClaimTypes.Role, "User")
                        }).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                Log.Debug("alice created");
            }

            

            //var result1 = 
            //if (result1.Succeeded)
            //{
            //System.Diagnostics.Debug.WriteLine("BARE WORKED");
            //}

            var bob = userMgr.FindByNameAsync("bob").Result;
            if (bob == null)
            {
                bob = new TMDbUser
                {
                    UserName = "bob",
                    Email = "BobSmith@email.com",
                    EmailConfirmed = true
                };
                var result = userMgr.CreateAsync(bob, "Pass123$").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result = userMgr.AddClaimsAsync(bob, new Claim[]{
                            new Claim(JwtClaimTypes.Name, "Bob Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Bob"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                            new Claim("location", "somewhere")
                        }).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                Log.Debug("bob created");
            }
            else
            {
                Log.Debug("bob already exists");
            }
        }
    }
}
