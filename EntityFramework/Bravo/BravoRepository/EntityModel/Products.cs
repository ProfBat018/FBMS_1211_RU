using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BravoRepository.EntityModel
{
    public class Products
    {
        public Products()
        {
            Stocks = new HashSet<Stock>();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public bool isCountable { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}
