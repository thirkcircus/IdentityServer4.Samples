﻿using IdentityServer4.Models;
using System.Collections.Generic;

namespace Host.Configuration
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "mvc",
                    ClientName = "MVC Hybrid Client",
                    AllowedGrantTypes = GrantTypes.Hybrid,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:3308/signin-oidc"
                    },

                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:3308/"
                    },

                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },

                    AllowedScopes = new List<string>
                    {
                        StandardScopes.OpenId.Name,
                        StandardScopes.Profile.Name,
                        "api1"
                    }
                },
                new Client
                {
                    ClientId = "client",
                    ClientName = "Console Client Credentials",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },

                    AllowedScopes = new List<string>
                    {
                        "api1"
                    }
                }
            };
        }
    }
}