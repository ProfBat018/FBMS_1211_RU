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
    public class ProductController : Controller
    {
        private readonly IUnitOfWork? _unitOfWork;
        private readonly IWebHostEnvironment? _webHostEnvironment;

        public ProductController(IUnitOfWork? unitOfWork, IWebHostEnvironment? webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int id)
        {
            ProductViewModel productVM = new()
            {
                Product = new(),
                CategoryList = _unitOfWork!.Category!.GetAll()!.Select(
                x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }),
                CoverTypeList = _unitOfWork!.CoverType!.GetAll()!.Select(
                x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                })
            };


            if (id == null || id == 0)
            {
                return View(productVM);
            }
            else
            {
                productVM.Product = _unitOfWork!.Product!.FindById(id);
                return View(productVM);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductViewModel? productVM, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string? wwwRootPath = _webHostEnvironment.WebRootPath;

                if (wwwRootPath != null)
                {
                    string? fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\products");
                    var extension = Path.GetExtension(file.FileName);

                    if (productVM!.Product!.ImageUrl != null)
                    {
                        var oldImage = Path.Combine(wwwRootPath, productVM!.Product!.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImage))
                        {
                            System.IO.File.Delete(oldImage);
                        }
                    }

                    using FileStream fs = new(Path.Combine(uploads, fileName + extension), FileMode.OpenOrCreate);

                    file.CopyTo(fs);

                    productVM!.Product!.ImageUrl = @"\images\products\" + fileName + extension;
                }
                if (productVM!.Product!.Id == 0)
                {
                    _unitOfWork!.Product!.Add(productVM!.Product!);
                    TempData["success"] = "Product created successfully";
                }
                else
                {
                    _unitOfWork!.Product!.Update(productVM!.Product!);
                    TempData["success"] = "Product updated successfully";
                }

                _unitOfWork.Save();

                return RedirectToAction("Index");
            }
            return View(productVM);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = _unitOfWork!.Product!.GetFirstOrDefault(u => u.Id == id);
            if (product == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            var oldImagePath = Path.Combine(_webHostEnvironment!.WebRootPath, product!.ImageUrl!.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Product.Remove(product);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }

        // не забыть объяснить Api Endpoint
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _unitOfWork!.Product!.GetAll(includeProperties: "Category,CoverType");
            return Json(new { data = products }); // return anonym data type
        }
    }
}
