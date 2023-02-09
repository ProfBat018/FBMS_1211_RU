using Ecommerce.Data.Models;
using EcommerceDataAccess.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccess.Services.Interfaces
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType? category);
        CoverType? FindById(int id);
    }
}
