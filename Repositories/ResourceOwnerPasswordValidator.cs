using AuthServer.Entities;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AuthServer.Repositories
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        private readonly IUserRepository userRepository;
        private readonly SignInManager<User> signInManager;

        public ResourceOwnerPasswordValidator(IUserRepository userRepository, SignInManager<User> signInManager)
        {
            this.userRepository = userRepository;
            this.signInManager = signInManager;
        }

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            try
            {
                var user = await userRepository.GetUserByName(context.UserName);
                if (user != null)
                {
                    var result = await signInManager.CheckPasswordSignInAsync(user, context.Password, false);
                    if (result.Succeeded)
                    {
                        context.Result = new GrantValidationResult(
                            subject: user.Id,
                            authenticationMethod: "custom",
                            claims: GetUserClaims(user));

                        return;
                    }

                    context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "Incorrect password");
                    return;
                }
                context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "User does not exist.");
                return;
            }
            catch (Exception ex)
            {
                context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "Invalid username or password");
            }
        }

        public static Claim[] GetUserClaims(User user)
        {
            return new Claim[]
            {
            new Claim("user_id", user.Id ?? ""),
            new Claim(JwtClaimTypes.Name, (!string.IsNullOrEmpty(user.FirstName) && !string.IsNullOrEmpty(user.LastName)) ? (user.FirstName + " " + user.LastName) : ""),
            new Claim(JwtClaimTypes.GivenName, user.FirstName ?? ""),
            new Claim(JwtClaimTypes.FamilyName, user.LastName  ?? ""),
            new Claim(JwtClaimTypes.Email, user.Email  ?? "")
            };
        }
    }
}
