using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services.Classes
{
    public class CityInfoService
    {
        private static WebClient webClient = new();

        public static string GetInfo(string city)
        {
            string json = webClient.DownloadString($"https://serpapi.com/search.json?engine=google&q={city}&google_domain=google.com&tbm=isch&ijn=0&api_key=00a557dca0a1726e568916c898aa2f7f48332cc7f80bcd3d95523f3a079e319e");

            return json;
        }
    }
}
