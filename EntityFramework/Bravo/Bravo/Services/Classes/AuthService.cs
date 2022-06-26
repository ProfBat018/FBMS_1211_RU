using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Bravo.Model;
using Bravo.Services.Interfaces;

namespace Bravo.Services.Classes
{
    internal class AuthService : IAuthService
    {
        public List<User>? GetUsers()
        {
            using FileStream fs = new(@"Resources\Data\users.json", FileMode.Open);
            using StreamReader sr = new(fs);


            return JsonSerializer.Deserialize<List<User>>(sr.ReadToEnd());
        }
    }
}
