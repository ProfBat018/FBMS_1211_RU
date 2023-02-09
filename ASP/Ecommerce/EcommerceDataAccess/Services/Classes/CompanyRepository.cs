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
    public class CompanyRepository : Repository<Company>, ICompanyRespository
    {
        private ECommerceDbContext? _context;
        public CompanyRepository(ECommerceDbContext? context) : base(context)
        {
            _context = context!;
        }

        public Company? FindById(int id)
        {
            return _context!.Companies!.Find(id);
        }

        public void Update(Company? category)
        {
            _context!.Update(category!);
        }
    }
}
