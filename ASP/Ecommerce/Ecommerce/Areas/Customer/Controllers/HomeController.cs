using Ecommerce.Models;
using EcommerceDataAccess.Data.Models;
using EcommerceDataAccess.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ecommerce.Areas.Customer.Controllers
{
    [Area("Customer")]
    //[Authorize(Roles = SessionStatus.Role_User_Indi)]
    //[Authorize(Roles = SessionStatus.Role_Admin)]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork? _unitOfWork;



        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Product>? products = _unitOfWork!.Product!.GetAll(includeProperties: "Category,CoverType");
            return View(products);
        }

        public IActionResult Details(int productId)
        {
            if (productId != 0)
            {
                var product = _unitOfWork!.Product!.GetFirstOrDefault(x => x.Id == productId, includeProperties:"Category,CoverType");
                ShoppingCart? cart = new()
                {
                    Product = product!,
                    Count = 1
                };

                return View(cart);
            }
            return NotFound();
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