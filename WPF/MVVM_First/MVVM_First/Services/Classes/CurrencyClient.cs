using MVVM_First.Model;
using MVVM_First.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

// https://freecurrencyapi.net/api/v2/latest?apikey=b96e6270-978f-11ec-beeb-5b5d170f97d6&base_currency=AZN

namespace MVVM_First.Services.Classes
{
    public class CurrencyClient : ICurrencyClient
    {
        private WebClient webClient = new();

        private readonly string _apiKey = "b96e6270-978f-11ec-beeb-5b5d170f97d6";
        private readonly string _link = "https://freecurrencyapi.net/api/v2/latest?apikey=";

        public string GetJson(string currencyName)
        {
            string _url = $"{_link}{_apiKey}&base_currency={currencyName}";

            string json = webClient.DownloadString(_url);
            return json;
        }


        public CurrencyModel GetCurrencyData(string currencyName)
        {
            try
            {
                string json = GetJson(currencyName);

                var result = JsonSerializer.Deserialize<CurrencyModel>(json);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
