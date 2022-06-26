using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BravoRepository.EntityModel
{
    public class Cashiers
    {
        public Cashiers()
        {
            Stocks = new HashSet<Stock>();
            Checks = new HashSet<Check>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Check> Checks{ get; set; }
    }
}
