using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Kasa_Projects.AuthServer.Models;

namespace Kasa_Projects.AuthServer.Data;

public class AspNetIdentityDbContext : IdentityDbContext<KasaUser>
{
    public AspNetIdentityDbContext(DbContextOptions<AspNetIdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
