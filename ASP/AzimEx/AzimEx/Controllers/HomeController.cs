using AzimEx.DbContexts;
using AzimEx.Models;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> Index()
        {
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
    }
}