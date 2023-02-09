using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    internal interface IMoneyService<T> where T : IJsonReturnable
    {
        T GetJson(string json);
    }
}
