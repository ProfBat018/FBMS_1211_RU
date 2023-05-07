using System;
using System.Collections.Generic;

namespace StoreApi
{
    public partial class BonusCard
    {
        public BonusCard()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public int? PersonId { get; set; }
        public decimal? Balance { get; set; }

        public virtual Person? Person { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
