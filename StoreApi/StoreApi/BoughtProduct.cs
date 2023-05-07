using System;
using System.Collections.Generic;

namespace StoreApi
{
    public partial class BoughtProduct
    {
        public BoughtProduct()
        {
            Receipts = new HashSet<Receipt>();
        }

        public int Id { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
