﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TMDb.AuthService.Entities;

namespace TMDb.AuthService.Data;

public class AspNetIdentityDbContext : IdentityDbContext<TMDbUser>
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
