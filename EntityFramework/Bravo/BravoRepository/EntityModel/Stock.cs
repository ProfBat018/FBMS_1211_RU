using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BravoRepository.Services.Interfaces;

namespace BravoRepository.EntityModel
{
    public class Stock : IBaseEntity
    {
        public Stock()
        {
            DateInfos = new HashSet<DateInfo>();
        }
        
        public int Id { get; set; }
        public float Count { get; set; }
        public float Price { get; set; }
        public int VAT { get; set; }
        public Products Products { get; set; } = null!;
        public ICollection<DateInfo> DateInfos { get; set; }
    }
}
