using BCrypt.Net;

namespace AzimEx.Services.Hash
{
    public static class HashGeneratorService
    {
        public static string? HashPassword(string? password)
        {
            var res = BCrypt.Net.BCrypt.HashPassword(password);
            return res;
        }
    }
}
