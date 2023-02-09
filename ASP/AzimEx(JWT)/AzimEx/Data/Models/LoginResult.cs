namespace AzimEx.Data.Models
{
    public class LoginResult
    {
        public string? Username { get; set; }
        public string? Token { get; set; }

        public override string ToString()
        {
            return $"{Username}\n{Token}";
        }
    }
}
