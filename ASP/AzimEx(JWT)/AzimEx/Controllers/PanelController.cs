using AzimEx.Services.Configurations;
using AzimEx.Services.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AzimEx.Controllers
{
    public class PanelController : Controller
    {
        private readonly ITokenService _tokenService;   
        private readonly IConfigService _configService;
        public PanelController(ITokenService tokenService, IConfigService configService)
        {
            _tokenService = tokenService;
            _configService = configService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult>? Admin()
        {
            return View();
        }

        [Authorize(AuthenticationSchemes=JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public IActionResult User()
        {
            string token = HttpContext!.Session?.GetString("Token");

            var issuer = _configService.GetValue("Jwt:Issuer");
            var audience = _configService.GetValue("Jwt:Audience");
            var key = _configService.GetValue("Jwt:Key");


            if (token == null)
            {
                return (RedirectToAction("Index"));
            }
            if (!_tokenService.ValidateToken(key, issuer, audience, token))
            {
                return (RedirectToAction("Index"));
            }
            ViewBag.Message = token;

            return View();
        }

        private string BuildMessage(string stringToSplit, int chunkSize)
        {
            var data = Enumerable.Range(0, stringToSplit.Length / chunkSize).Select(i => stringToSplit.Substring(i * chunkSize, chunkSize));
            string result = "The generated token is:";
            foreach (string str in data)
            {
                result += Environment.NewLine + str;
            }
            return result;
        }
    }
}
