using System;
using System.Collections.Generic;

namespace ShopApi.Repository.Model
{
    public partial class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public virtual Order? Order { get; set; } = null!;
        public virtual Product? Product { get; set; } = null!;
    }
}
