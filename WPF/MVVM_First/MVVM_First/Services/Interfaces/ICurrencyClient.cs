using MVVM_First.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_First.Services.Interfaces
{
    public interface ICurrencyClient
    {
        public string GetJson(string currencyName);
        public CurrencyModel GetCurrencyData(string currencyName);
    }
}
