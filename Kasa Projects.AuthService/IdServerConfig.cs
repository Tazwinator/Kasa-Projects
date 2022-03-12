﻿using Duende.IdentityServer.Models;

namespace Kasa_Projects.AuthServer;

public static class IdServerConfig
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
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
            new Client
            {
                ClientId = "wasmClient",
                ClientSecrets = { new Secret("ClientSecret1".Sha256()) },

                AllowedGrantTypes = GrantTypes.ClientCredentials,

                RedirectUris = { "https://localhost:5000/signin-oidc" },
                FrontChannelLogoutUri = "https://localhost:5000/signout-oidc",
                PostLogoutRedirectUris = { "https://localhost:5000/signout-callback-oidc" },

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "scope2" },

                RequirePkce = true,
                RequireConsent = true,
                AllowPlainTextPkce = false
            }
        };
}