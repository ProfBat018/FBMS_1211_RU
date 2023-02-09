using System;
using System.Collections.Generic;

namespace ShopApi.Repository.Model
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; } = null!;
        public virtual ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
