using Ecommerce.Data.DbContexts;
using Ecommerce.Data.Models;
using EcommerceDataAccess.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SessionStatus.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork? _unitOfWork;
        public CategoryController(IUnitOfWork? unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Category>? categories = _unitOfWork!.Category!.GetAll();
            return View(categories!);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var category = _unitOfWork!.Category!.FindById(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        public IActionResult Delete(int id)
        {
            var category = _unitOfWork!.Category!.FindById(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category? category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork!.Category!.Add(category);
                _unitOfWork!.Save();
                TempData["success"] = "Category created succsessfully";
                return RedirectToAction("Index", "Category");
            }
            throw new ArgumentException("Category is not valid...");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "The Display cannot exactly match the Name field");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork!.Category!.Update(category!);
                _unitOfWork!.Save();
                TempData["success"] = "Category updated succsessfully";

                return RedirectToAction("Index", "Category");
            }
            throw new ArgumentException("Category is not valid...");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var category = _unitOfWork!.Category!.FindById(id);

            if (category == null)
            {
                return NotFound();
            }

            _unitOfWork.Category!.Remove(category!);
            _unitOfWork!.Save();
            TempData["success"] = "Category was deleted succsessfully";

            return RedirectToAction("Index");
        }
    }
}
