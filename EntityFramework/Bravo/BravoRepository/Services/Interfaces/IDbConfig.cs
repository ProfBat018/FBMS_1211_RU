using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BravoRepository.EntityContext;

namespace BravoRepository.Services.Interfaces
{
    internal interface IDbConfig
    {
        public BravoDbContext ConnectTo(string? dbName);
    }
}
