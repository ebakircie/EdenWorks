using EdenWorks.Application.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace EdenWorks.Presentation.Models.Components
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _categoryService.GetCategories());
        }
    }
}
