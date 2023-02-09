using EcommerceDataAccess.Data.Models;
using EcommerceDataAccess.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SessionStatus.Role_Admin)]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork? _unitOfWork;

        public CoverTypeController(IUnitOfWork? unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<CoverType>? objCoverTypeList = _unitOfWork!.CoverType!.GetAll();
            return View(objCoverTypeList!);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CoverType? coverType)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork!.CoverType!.Add(coverType!);
                _unitOfWork!.Save();
                TempData["success"] = "CoverType created successfully";
                return RedirectToAction("Index");
            }
            return View(coverType!);
        }

        public IActionResult Edit(int id)
        {
            var CoverTypeFromDbFirst = _unitOfWork!.CoverType!.FindById(id);

            if (CoverTypeFromDbFirst == null)
            {
                return NotFound();
            }

            return View(CoverTypeFromDbFirst);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CoverType? coverType)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork!.CoverType?.Update(coverType);
                _unitOfWork!.Save();
                TempData["success"] = "CoverType updated successfully";
                return RedirectToAction("Index");
            }
            return View(coverType!);
        }

        public IActionResult Delete(int id)
        {
            var CoverTypeFromDbFirst = _unitOfWork!.CoverType!.FindById(id);

            if (CoverTypeFromDbFirst == null)
            {
                return NotFound();
            }

            return View(CoverTypeFromDbFirst);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int id)
        {
            var coverType = _unitOfWork!.CoverType!.FindById(id);
            if (coverType == null)
            {
                return NotFound();
            }

            _unitOfWork!.CoverType!.Remove(coverType!);
            _unitOfWork!.Save();
            TempData["success"] = "CoverType deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
