using AzimEx.Models;

namespace AzimEx.Services.Tokens
{
    public interface ITokenService
    {
        string BuildToken(string? key, string? issuer, UserViewModel? user, double expiration=30);
        bool ValidateToken(string? key, string? issuer, string? audience, string? token);
        Task<bool> IsCurrentActiveToken();
        Task<bool> IsActiveAsync(string token);
        Task DeactivateAsync(string token);
    }

}
