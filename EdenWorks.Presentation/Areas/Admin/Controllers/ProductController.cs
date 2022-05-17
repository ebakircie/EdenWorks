using EdenWorks.Application.Extensions;
using EdenWorks.Application.Models.DTOs.ProductDTO;
using EdenWorks.Application.Services.CategoryService;
using EdenWorks.Application.Services.ProductService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdenWorks.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [NeedAuthentication]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Create()
        {
            CreateProductDTO model = new CreateProductDTO();
            model.Categories = await _categoryService.GetCategoriesList(); // service e category listesi dönen ama farklı vm le bir sınıf eklendi.
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDTO model)
        {
            if (ModelState.IsValid)
            {
                TempData["Success"] = "Product has been added!";
                _productService.Create(model);
                return RedirectToAction("List");
            }
            else
            {
                TempData["Error"] = "The Product hasn't been added..!";
                return RedirectToAction("Create");
            }
        }

        public async Task<IActionResult> List()
        {
            return View(await _productService.GetProducts());
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _productService.GetById(id);

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductDTO model)
        {
            if (ModelState.IsValid)
            {
                TempData["Success"] = "Product has been added!";
                await _productService.Update(model);
                return RedirectToAction("List");
            }
            else
            {
                TempData["Error"] = "The Product hasn't been updated..!";
                //return View(model);  hata aldığında, tekrar gidiyor model e fakat, getbyid category getirirken boş getiriyor. update e gidip kendi doldurması lazım.
                return RedirectToAction("Update");
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Delete(id);
            return RedirectToAction("List");
        }

        public async Task<IActionResult> PassiveList()
        {
            return View(await _productService.GetPassives());
        }

        public async Task<IActionResult> SetActive(int id)
        {
            await _productService.SetActive(id);
            return RedirectToAction("PassiveList");

        }

        public async Task<IActionResult> Details(int id)
        {
            var result = await _productService.GetById(id);
            return View(result);
        }

        public async Task<IActionResult> GetProductsByCategory(int id)
        {
            var result = await _productService.GetProductsByCategory(id);
            return View(result);
        }

        public async Task<IActionResult> ProductSearch (string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var result = await _productService.GetProductsByName(name);
                return View(result);
            }
            else
            {
                return View();
            }  
        }

    }
}
