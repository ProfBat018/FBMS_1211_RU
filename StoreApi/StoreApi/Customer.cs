using System;
using System.Collections.Generic;

namespace StoreApi
{
    public partial class Customer
    {
        public int Id { get; set; }
        public int? BonusId { get; set; }

        public virtual BonusCard? Bonus { get; set; }
    }
}
