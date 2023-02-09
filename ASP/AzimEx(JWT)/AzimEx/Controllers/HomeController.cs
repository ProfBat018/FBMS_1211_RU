using AzimEx.Data.DbContexts;
using AzimEx.Data.Models;
using AzimEx.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Diagnostics;

namespace AzimEx.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserDbContext? _userDbContext;
        public HomeController(ILogger<HomeController> logger, UserDbContext context)
        {
            _logger = logger;
            _userDbContext = context;
        }

        public async Task<IActionResult> Index(LoginResult? res)
        {
            StringValues vals;
            HttpContext.Request.Headers.TryGetValue("Authorization", out vals);
            
            ViewBag.Token = vals.ToString();
            
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult>? UnAuthorized()
        {
            return RedirectToAction("Login", "Auth", new UserViewModel());
        }
    }
}