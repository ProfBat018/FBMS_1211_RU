using MVVM_Views.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Views.Services.Interfaces
{
    public interface ICurrencyClient
    {
        public string GetJson(string currencyName);
        public CurrencyModel GetCurrencyData(string currencyName);
    }

}
