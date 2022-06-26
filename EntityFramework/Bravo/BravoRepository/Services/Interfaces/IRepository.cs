using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BravoRepository.EntityContext;
using Microsoft.EntityFrameworkCore;

namespace BravoRepository.Services.Interfaces
{
    public interface IRepository<T> where T : IBaseEntity
    {
        T? Get(uint id);
        IEnumerable<T> GetAll();

        void Update();
        void Delete();
        void Add();
    }
}
