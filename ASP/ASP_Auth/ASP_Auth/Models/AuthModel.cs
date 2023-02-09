using System.ComponentModel.DataAnnotations;

namespace ASP_Auth.Models
{
    public class AuthModel
    {
        
        public int Id { get; set; }
        public string? Email { get; set; }

        //[Required(ErrorMessage = "Please enter name")]
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
