using Ecommerce.Data.DbContexts;
using Ecommerce.Data.Models;
using EcommerceDataAccess.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccess.Services.Classes
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ECommerceDbContext? _context;
        public CategoryRepository(ECommerceDbContext? context) : base(context)
        {
            _context = context!;
        }

        public Category? FindById(int id)
        {
            return _context!.Categories!.Find(id);
        }

        public void Update(Category? category)
        {
            _context!.Update(category!);
        }
    }
}
