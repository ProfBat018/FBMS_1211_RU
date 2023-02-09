using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            throw new Exception("Aloha");
        }
    }
}
