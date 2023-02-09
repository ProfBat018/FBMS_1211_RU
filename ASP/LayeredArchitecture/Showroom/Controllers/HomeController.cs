using Business.Services.Classes;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Showroom.Models;
using ShowroomRepository.Model;
using System.Diagnostics;

namespace Showroom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IDataProviderService _dataProvider;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cars()
        {
            _dataProvider = new ShowRoomDataProvider<Car>();

            return View(_dataProvider.GetAllData());
        }

        public IActionResult People()
        {
            _dataProvider = new ShowRoomDataProvider<Person>();

            return View(_dataProvider.GetAllData());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}