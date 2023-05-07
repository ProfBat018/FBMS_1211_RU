using System;
using System.Collections.Generic;

namespace StoreApi
{
    public partial class Product
    {
        public Product()
        {
            BoughtProducts = new HashSet<BoughtProduct>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public byte[]? Qrcode { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? ExpirationTime { get; set; }

        public virtual ICollection<BoughtProduct> BoughtProducts { get; set; }
    }
}
