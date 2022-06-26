using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BravoRepository.EntityContext;
namespace Bravo.Services.Interfaces
{
    internal interface IRepositoryData
    {
        public BravoDbContext GetContext();
    }
}
