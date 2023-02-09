using System;
using System.Collections.Generic;

namespace ShopApi.Repository.Model
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public string? FullName { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public string? Phone { get; set; } = null!;
        public string? Address { get; set; } = null!;
        public string? Comment { get; set; }
        public decimal TotalPrice { get; set; }
        public int? OrderStatus { get; set; }

        public virtual ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
