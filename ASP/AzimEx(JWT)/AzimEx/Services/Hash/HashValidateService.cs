using System.Security.Cryptography;

namespace AzimEx.Services.Hash
{
    public static class HashValidateService
    {
        public static bool ValidateHashedPassword(string? hash, string? password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
