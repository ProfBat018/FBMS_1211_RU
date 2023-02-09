using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccess.Services.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category? category);
        Category? FindById(int id);
    }
}
