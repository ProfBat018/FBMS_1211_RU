using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccess.Services.Interfaces
{
    public interface IUnitOfWork
    {
        public ICategoryRepository? Category { get; }
        public ICoverTypeRepository? CoverType { get; }
        public IProductRepository? Product { get; }
        public ICompanyRespository? Company{ get; }

        void Save();
    }
}
