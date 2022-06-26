using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BravoRepository.EntityModel
{
    public class Check
    {
        public int Id { get; set; }
        public string? ProductInfo { get; set; }
        public Cashiers CashierInfo { get; set; } = null!;
    }
}
