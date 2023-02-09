using AzimEx.DbContexts;
using AzimEx.Models;
using AzimEx.Services.Hash;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AzimEx.Controllers
{
    public class AuthController : Controller
    {
        private UserDbContext _context;
        public AuthController(UserDbContext context)
        {
            _context = context;
            ViewBag.Confirm = "Test";
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

                var cookie = new CookieOptions()
                {
                    Expires = DateTime.Now.AddMinutes(10),
                    Secure = true
                };


                if (res)
                {
                    TempData["user"] = true;

                    List<Claim> claims = new()
                    {
                       new Claim(ClaimTypes.Email, user.Email!),
                    };

                    var identity = new ClaimsIdentity(claims, "Cookies");

                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext?.SignInAsync(principal!);

                    return RedirectToAction("Index", "Home", user);
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
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Auth");
        }
    }
}
