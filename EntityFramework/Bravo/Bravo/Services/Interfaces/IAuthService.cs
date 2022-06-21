using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bravo.Model;

namespace Bravo.Services.Interfaces
{
    internal interface IAuthService
    {
        public List<User>? GetUsers();
    }
}
