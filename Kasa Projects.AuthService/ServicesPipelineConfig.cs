using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using Kasa_Projects.AuthServer.Data;
using Kasa_Projects.AuthServer.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Kasa_Projects.AuthServer;

internal static class ServicesPipelineConfig
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        var assembly = typeof(Program).Assembly.GetName().Name;
        var defaultConnString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddRazorPages();

        builder.Services.AddDbContext<AspNetidentityDbContext>(options =>
            options.UseSqlServer(defaultConnString, sqlServerOptions => sqlServerOptions.MigrationsAssembly(assembly)));

        builder.Services.AddIdentity<KasaUser, IdentityRole>()
            .AddEntityFrameworkStores<AspNetidentityDbContext>()
            .AddDefaultTokenProviders();

        builder.Services
            .AddIdentityServer(options =>
            {
                options.Events.RaiseErrorEvents = true;
                options.Events.RaiseInformationEvents = true;
                options.Events.RaiseFailureEvents = true;
                options.Events.RaiseSuccessEvents = true;
                options.EmitStaticAudienceClaim = true;
            })
            .AddInMemoryIdentityResources(IdServerConfig.IdentityResources)
            .AddInMemoryApiScopes(IdServerConfig.ApiScopes)
            .AddInMemoryClients(IdServerConfig.Clients)
            .AddAspNetIdentity<KasaUser>()
            .AddApiAuthorization<KasaUser, AspNetidentityDbContext>();

        //builder.Services.AddAuthentication()
        //    .AddIdentityServerJwt()
        //    .AddGoogle(options =>
        //    {
        //        options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

        //        // register your IdentityServer with Google at https://console.developers.google.com
        //        // enable the Google+ API
        //        // set the redirect URI to https://localhost:5001/signin-google
        //        options.ClientId = "copy client ID from Google here";
        //        options.ClientSecret = "copy client secret from Google here";
        //    });

        builder.Services.AddControllersWithViews();

        return builder.Build();
    }
    
    public static WebApplication ConfigurePipeline(this WebApplication app)
    { 
        app.UseSerilogRequestLogging();
    
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        
        app.UseStaticFiles();
        app.UseRouting();
        app.UseIdentityServer();
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapDefaultControllerRoute();
        });

        return app;
    }
}