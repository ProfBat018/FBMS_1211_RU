using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DataModels
{
    public class Car
    {
        public Car()
        {
            Cars = new HashSet<Car>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string? Make { get; set; } = "Mercedes";
        [Required]
        [StringLength(15)]
        public string? Model { get; set; }


        public ICollection<Car> Cars { get; set; }
    }
}
