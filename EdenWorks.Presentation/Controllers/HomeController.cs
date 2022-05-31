using EdenWorks.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EdenWorks.Application.Services.CategoryService;
using EdenWorks.Application.Services.ProductService;

namespace EdenWorks.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public HomeController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetProducts();
            return View(result);
        }

    }
}