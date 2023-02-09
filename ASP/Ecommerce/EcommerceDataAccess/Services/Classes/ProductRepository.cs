using Ecommerce.Data.DbContexts;
using Ecommerce.Data.Models;
using EcommerceDataAccess.Data.Models;
using EcommerceDataAccess.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccess.Services.Classes
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ECommerceDbContext? _context;

        public ProductRepository(ECommerceDbContext? context) : base(context)
        {
            _context = context;
        }

        public Product? FindById(int id)
        {
            return _context!.Products!.Find(id)!;
        }

        public void Update(Product? obj)
        {
            var objFromDb = _context!.Products!.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Author = obj.Author;
                objFromDb.CoverTypeId = obj.CoverTypeId;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }

    }
}
