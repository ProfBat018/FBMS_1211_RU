using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AzimEx.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        [NotMapped]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }


        [NotMapped]
        public bool LoggedIn { get; set; }
        public override string ToString()
        {
            return $"Logged In with {Email}";
        }
    }
}
