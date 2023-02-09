using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace AzimEx.Services.Policies
{
    public class EmailHandler : AuthorizationHandler<EmailRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext? context, EmailRequirement? requirement)
        {
            if (context!.User.HasClaim(claim => claim.Type == ClaimTypes.Email))
            {
                if (context!.User.FindFirst(claim => claim.Type == ClaimTypes.Email).Value.Contains(requirement.Domain))
                {
                        context.Succeed(requirement);
                }
            }
            return Task.CompletedTask;
        }
    }
}
