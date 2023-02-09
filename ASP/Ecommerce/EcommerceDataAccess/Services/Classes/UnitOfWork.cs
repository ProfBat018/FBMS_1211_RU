using Ecommerce.Data.DbContexts;
using EcommerceDataAccess.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccess.Services.Classes
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository? Category { get; private set; }
        public ICoverTypeRepository? CoverType { get; private set; }
        public IProductRepository? Product{ get; private set; }
        public ICompanyRespository? Company { get; private set; }

        private ECommerceDbContext? _context;
        public UnitOfWork(ECommerceDbContext? context) 
        {
            _context = context!;

            Category = new CategoryRepository(_context);
            CoverType = new CoverTypeRepository(_context);
            Product = new ProductRepository(_context);
            Company = new CompanyRepository(_context);
        }
        public void Save()
        {
            _context?.SaveChanges();
        }
    }
}
