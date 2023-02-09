using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesMVC.Models;
using MoviesMVC.Services.Inrerfaces;
using System.Diagnostics;

namespace MoviesMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataDownloaderService _downloaderService;
        private readonly IDeserializationService _deserializerService;
        public HomeController(ILogger<HomeController> logger, IDataDownloaderService downloaderService, IDeserializationService deserializerService)
        {
            _logger = logger;
            _downloaderService = downloaderService;
            _deserializerService = deserializerService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Search(string? search, int page=1)
        {
            string? data = await _downloaderService?.DownloadAsync(search, "2af856c7", page)!;

            var model = await _deserializerService?.DeserializeAsync<MoviesViewModel?>(data!)!;

            model!.CurrentPage = page;
            model!.Request = search;

            return View("Index", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public void Info(string? request)
        {
            Console.WriteLine(request);

            //return PartialView("_InfoPartial", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}