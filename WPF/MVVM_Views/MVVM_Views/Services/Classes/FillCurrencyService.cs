using MVVM_Views.Model;
using MVVM_Views.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Views.Services.Classes
{
    public class FillCurrencyService : IFillCurrencyService
    {
        public List<string> FillCurrency()
        {
            Data data = new Data();
            var tmp = new List<string>();

            PropertyInfo[] props = data.GetType().GetProperties();
            // This change for 12017AZ

            foreach (PropertyInfo prop in props)
            {
                tmp.Add(prop.Name);
            }
            return tmp;
        }
    }
}
