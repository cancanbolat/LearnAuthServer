using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer
{
    public static class Config
    {
        //Scopes
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("WebApi1", "Web API 1")
            };
        }

        //Resources
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("WebApi1", "Web API 1"){ Scopes = { "Webapi" } }
            };
        }

        //Clients
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "WebApi1",
                    ClientName = "Web API 1",
                    ClientSecrets = { new Secret("webapi1".Sha256()) },
                    AllowedGrantTypes = { GrantType.ResourceOwnerPassword },
                    AllowedScopes =
                    {
                        "WebApi",
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Email
                    }
                }
            };
        }

        //Identity Resources
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };
        }
    }
}
