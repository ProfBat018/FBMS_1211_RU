using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BravoRepository.EntityContext;
using BravoRepository.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BravoRepository.Services.Classes
{
    public class Repository<T> : IDisposable, IRepository<T> where T : class, IBaseEntity 
    {
        private readonly DbSet<T> _entities;
        public BravoDbContext BravoDbContext { get; set; }
        public Repository()
        {
            DbConfig config = new();
            BravoDbContext =  config.ConnectTo("BravoDbStep");
            _entities = BravoDbContext.Set<T>();
        }

        public T? Get(uint id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            BravoDbContext.Dispose();   
        }
    }
}
