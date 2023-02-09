using Business.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShowroomRepository;
using ShowroomRepository.DbContexts;
using ShowroomRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Classes
{
    public class ShowRoomDataProvider<T> : IDataProviderService where T : class, IEntity
    {
        private readonly ShowroomContext _context = new ();

        private DbSet<T> _dbSet;

        public ShowRoomDataProvider()
        {
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<IEntity> GetAllData()
        {
            return _dbSet.ToArray();
        }

        public IEntity GetData(int id)
        {
            return _dbSet.First(x => x.Id == id);
        }
    }
}

