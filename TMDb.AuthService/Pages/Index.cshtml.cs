using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TMDb.AuthService.Pages.Home;

[Authorize]
[Authorize(Roles = "Admin")]
public class Index : PageModel
{
    public string Version;

    private readonly IHttpContextAccessor _context;

    public Index(IHttpContextAccessor context)
    {
        _context = context;
    }

    
    public void OnGet()
    {
        Version = typeof(Duende.IdentityServer.Hosting.IdentityServerMiddleware).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion.Split('+').First();
    }
}