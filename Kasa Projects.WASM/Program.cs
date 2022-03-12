using Kasa_Projects.WASM;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddHttpClient("Kasa Projects.AuthService",
//        client => client.BaseAddress = new Uri("https://localhost:5001/connect/authorize"))
//    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

//builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
//    .CreateClient("Kasa Projects.AuthService"));

//builder.Services.AddApiAuthorization();

builder.Services.AddOidcAuthentication(options =>
{
    builder.Configuration.Bind("InteractiveServiceSettings", options.ProviderOptions);
    //options.ProviderOptions.DefaultScopes.Add("openid");
});


await builder.Build().RunAsync();