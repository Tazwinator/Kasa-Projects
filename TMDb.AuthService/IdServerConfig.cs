using Duende.IdentityServer.Models;
using IdentityModel;

namespace TMDb.AuthService;

public static class IdServerConfig
{

    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResource {
                Name = "UserRoles",
                UserClaims =
                {
                    JwtClaimTypes.Role
                }
            }
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("scope1"),
            new ApiScope("scope2"),
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            // m2m client credentials flow client
            new Client
            {
                ClientId = "m2m.client",
                ClientName = "Client Credentials Client",

                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },

                AllowedScopes = { "scope1" }
            },

            // interactive client using code flow + pkce
            // Development
            new Client
            {
                ClientId = "blazorClientDev",
                ClientSecrets = { new Secret("ClientSecret1".Sha256()) },

                AllowedGrantTypes = GrantTypes.Code,

                RedirectUris = { "https://localhost:5331/signin-oidc" },
                FrontChannelLogoutUri = "https://localhost:5331/signout-oidc",
                PostLogoutRedirectUris = { "https://localhost:5331/signout-callback-oidc" },

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "UserRoles" },

                AlwaysIncludeUserClaimsInIdToken = true,

                RequirePkce = true,
                RequireConsent = true,
                AllowPlainTextPkce = false
            },

            // Production
            new Client
            {
                ClientId = "TMDBWeb",
                ClientSecrets = { new Secret("C259CBA57288D6F56600D3B8EB7ABA3EC83CA4ECAED83CD48B77D1475AB00750".Sha256()) },

                AllowedGrantTypes = GrantTypes.Code,

                RedirectUris = { "https://tmdbblazorclient.azurewebsites.net/signin-oidc", "https://tazwin.co.uk/signin-oidc" },
                AllowedCorsOrigins = { "https://tmdbblazorclient.azurewebsites.net", "https://tazwin.co.uk" },
                PostLogoutRedirectUris = { "https://tmdbblazorclient.azurewebsites.net/signout-callback-oidc", "https://tazwin.co.uk/signout-callback-oidc" },

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "UserRoles" },

                AlwaysIncludeUserClaimsInIdToken = true,

                RequirePkce = true,
                RequireConsent = true,
                AllowPlainTextPkce = false
            }
        };
}
