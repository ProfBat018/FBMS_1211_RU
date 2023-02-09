using AzimEx.Data.DbContexts;
using AzimEx.Data.Models;
using AzimEx.Models;
using AzimEx.Services.Configurations;
using AzimEx.Services.Hash;
using AzimEx.Services.Tokens;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using NuGet.Common;
using NuGet.Protocol.Plugins;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace AzimEx.Controllers
{
    public class AuthController : Controller
    {
        private UserDbContext _context;
        private readonly ITokenService _tokenService;
        private string? generatedToken;
        private readonly IConfigService _configService;
        private static UserViewModel? _userViewModel = new();

        public AuthController(UserDbContext context, ITokenService tokenService, IConfigService configService)
        {
            _tokenService = tokenService;
            _context = context;
            _configService = configService;
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserViewModel? user)
        {
            ModelState.Remove("ConfirmPassword");

            if (ModelState.IsValid)
            {
                var loaded = _context!.Users?.First(x => x.Email == user!.Email);

                bool res = HashValidateService.ValidateHashedPassword(loaded!.Password, user!.Password);

                if (res)
                {
                    var issuer = _configService.GetValue("Jwt:Issuer");
                    var audience = _configService.GetValue("Jwt:Audience");
                    var key = _configService.GetValue("Jwt:Key");

                    generatedToken = _tokenService.BuildToken(key, issuer, loaded);

                    if (generatedToken != null)
                    {
                        HttpContext.Session.SetString("Token", generatedToken);

                        HttpContext.Request.Headers.Add("Authorization", "Bearer " + generatedToken);

                        _userViewModel = user;

                        return RedirectToAction("User", "Panel");

                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel? user)
        {
            if (ModelState.IsValid)
            {
                user!.Password = HashGeneratorService.HashPassword(user!.Password);

                _context!.Users?.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public async Task<IActionResult> Forgot()
        {
            return NotFound();
        }


        public async Task<IActionResult> Logout()
        {
            var test = HttpContext!.Session.GetString("Token");

            await _tokenService.DeactivateAsync(test);

            return RedirectToAction("Index", "Home");
        }
    }
}
