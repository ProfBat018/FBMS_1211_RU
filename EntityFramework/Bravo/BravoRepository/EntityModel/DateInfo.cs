using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BravoRepository.EntityModel
{
    public class DateInfo
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public DateTime MDate { get; set; }
        public DateTime EDate { get; set; }
        public Stock Stock { get; set; } = null!;
    }
}
