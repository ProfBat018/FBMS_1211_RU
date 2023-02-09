using Microsoft.AspNetCore.Authorization;

namespace AzimEx.Services.Policies
{
    public class EmailRequirement : IAuthorizationRequirement
    {
        public string? Domain { get; set; }
        
        public EmailRequirement(string? domain)
        {
            Domain = domain;
        }
    }
}
