using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzimEx.Controllers
{
    public class PanelController : Controller
    {
        [Authorize(Policy = "Email")]
        public async Task<IActionResult>? Admin()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult>? User()
        {
            return View();
        }
    }
}
