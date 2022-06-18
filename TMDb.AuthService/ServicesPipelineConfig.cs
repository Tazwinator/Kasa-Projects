using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Services;
using TMDb.AuthService.Data;
using TMDb.AuthService.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace TMDb.AuthService;

internal static class ServicesPipelineConfig
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        var assembly = typeof(Program).Assembly.GetName().Name;
        var defaultConnString = builder.Configuration.GetConnectionString("DefaultConnection");

        // ASP.NET Identity
        builder.Services.AddDbContext<AspNetIdentityDbContext>(options =>
            options.UseSqlServer(defaultConnString, b => b.MigrationsAssembly(assembly)));

        builder.Services.AddIdentity<TMDbUser, IdentityRole>()
            .AddEntityFrameworkStores<AspNetIdentityDbContext>()
            .AddDefaultTokenProviders();

        //var IdServerClients = builder.Configuration.GetValue<Client[]>("IdentityServer:IdServerClients");
        //var IdServerApiScopes = builder.Configuration.GetValue<Client[]>("IdServerApiScopes");
        //var IdServerResources = builder.Configuration.GetValue<Client[]>("IdServerResources");

        builder.Services.AddAuthentication()
            .AddIdentityServerJwt();

        // Duende Identity Server
        builder.Services
            .AddIdentityServer(options =>
            {
                options.Events.RaiseErrorEvents = true;
                options.Events.RaiseInformationEvents = true;
                options.Events.RaiseFailureEvents = true;
                options.Events.RaiseSuccessEvents = true;
                options.EmitStaticAudienceClaim = true;
            })
            .AddAspNetIdentity<TMDbUser>()
            .AddConfigurationStore(options =>
            {
                options.ConfigureDbContext = b =>
                b.UseSqlServer(defaultConnString, opt => opt.MigrationsAssembly(assembly));
            })
            .AddOperationalStore(options =>
            {
                options.ConfigureDbContext = b =>
                b.UseSqlServer(defaultConnString, opt => opt.MigrationsAssembly(assembly));
            })
            .AddInMemoryIdentityResources(IdServerConfig.IdentityResources)
            .AddInMemoryApiScopes(IdServerConfig.ApiScopes)
            .AddInMemoryClients(IdServerConfig.Clients)
            .AddInMemoryCaching();

        // Used back in WASM days 

        //builder.Services.AddSingleton<ICorsPolicyService>((container) => {
        //    var logger = container.GetRequiredService<ILogger<DefaultCorsPolicyService>>();
        //    return new DefaultCorsPolicyService(logger)
        //    {
        //        AllowedOrigins = { "https://localhost:5331" }
        //    };
        //});

        // Extra Auth Methods
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

        builder.Services.AddMvc();

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
        app.MapControllers();
        app.MapRazorPages();

        app.UseIdentityServer();
        app.UseAuthentication();
        app.UseAuthorization();

        

        return app;
    }
}