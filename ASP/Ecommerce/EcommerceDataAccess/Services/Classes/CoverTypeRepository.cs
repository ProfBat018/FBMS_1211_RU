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
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ECommerceDbContext? _context;
        public CoverTypeRepository(ECommerceDbContext? context) : base(context)
        {
            _context = context!;
        }

        public CoverType? FindById(int id)
        {
            return _context!.CoverTypes!.Find(id);
        }

        public void Update(CoverType? coverType)
        {
            _context!.Update(coverType!);
        }
    }
}
