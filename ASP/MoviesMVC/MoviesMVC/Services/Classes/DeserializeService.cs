using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MoviesMVC.Services.Inrerfaces;

namespace MoviesMVC.Services.Classes
{
    public class DeserializeService : IDeserializationService
    {
        public async Task<T?>? DeserializeAsync<T>(string json)
        {
            var res = JsonSerializer.Deserialize<T>(json);

            if (res != null)
            {
                return res;
            }
            throw new SerializationException();
        }
    }
}
