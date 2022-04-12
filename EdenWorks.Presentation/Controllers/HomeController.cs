using EdenWorks.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorkEden.Application.Services.CategoryService;

namespace EdenWorks.Presentation.Controllers
{
    public class HomeController : Controller
    {
      private readonly ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _categoryService.GetCategories();
            return View(result);
        }

    }
}