using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 50, ErrorMessage = "Display order must be between 1 and 50")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
