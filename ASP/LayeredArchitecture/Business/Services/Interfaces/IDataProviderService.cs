using ShowroomRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces
{
    public interface IDataProviderService
    {
        public IEnumerable<IEntity> GetAllData();
        public IEntity GetData(int id);
    }
}
