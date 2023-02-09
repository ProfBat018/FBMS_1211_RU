using Ecommerce.Models;
using EcommerceDataAccess.Data.Models;
using EcommerceDataAccess.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using System.Data;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SessionStatus.Role_Admin)]

    public class CompanyController : Controller
    {
        private readonly IUnitOfWork? _unitOfWork;
        public CompanyController(IUnitOfWork? unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int id)
        {
            Company company = new();
            if (id == 0)
            {
                return View(company);
            }
            else
            {
                company = _unitOfWork!.Company!.FindById(id);
                return View(company);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Company? company)
        {
            if (ModelState.IsValid) 
            {
                if (company!.Id == 0)
                {
                    _unitOfWork!.Company!.Add(company);
                    TempData["success"] = "Company created successfully";
                }
                else
                {
                    _unitOfWork!.Company!.Update(company);
                    TempData["success"] = "Company created successfully";
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(company);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var company = _unitOfWork!.Company!.GetFirstOrDefault(u => u.Id == id);
            if (company == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }

		[HttpGet]
		public IActionResult GetAll()
		{
			var companyList = _unitOfWork!.Company!.GetAll();
			return Json(new { data = companyList });
		}
	}
}
