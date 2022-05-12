using EdenWorks.Application.Extensions;
using EdenWorks.Application.Models.DTOs.CategoryDTO;
using EdenWorks.Application.Services.CategoryService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace EdenWorks.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [NeedAuthentication]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDTO model)
        {
            if (ModelState.IsValid)
            {
                bool result = await _categoryService.isCategoryExist(model.CategoryName);
                if (!result)
                {
                    TempData["Success"] = "Category has been added.!";
                    _categoryService.Create(model);
                    return RedirectToAction("List");
                }
                else
                {
                    TempData["Warning"] = model.CategoryName + " already exist.!";
                    return View(model);
                }
            }
            else
            {
                TempData["Error"] = "The Category hasn't been added.!";
                return View(model);
            }
        }

        public async Task<IActionResult> List()
        {
            return View(await _categoryService.GetCategories());
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _categoryService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCategoryDTO model)
        {
            if (ModelState.IsValid)
            {
                bool result = await _categoryService.isCategoryExist(model.CategoryName);
                if (!result)
                {
                    TempData["Success"] = "Category has been updated.!";
                    await _categoryService.Update(model);
                    return RedirectToAction("List");
                }
                else
                {
                    TempData["Warning"] = model.CategoryName + " already exist.!";
                    return View(model);
                }

            }
            else
            {
                TempData["Error"] = "Category hasnt been updated.!";
                return View(model);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.Delete(id);
            return RedirectToAction("List");
        }

        public async Task<IActionResult> PassiveList()
        {
            return View(await _categoryService.GetPassives());
        }

        public async Task<IActionResult> SetActive(int id)
        {
            await _categoryService.SetActive(id);
            return RedirectToAction("List");
        }


    }
}
