using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BravoRepository.Services.Interfaces;

namespace BravoRepository.EntityModel
{
    public class DateInfo : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime MDate { get; set; }
        public DateTime EDate { get; set; }
        public Stock Stock { get; set; } = null!;
    }
}
