
using WorkEden.Application.Models.DTOs.CategoryDTO;
using WorkEden.Application.Models.VMs.CategoryVM;

namespace WorkEden.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        void Create(CreateCategoryDTO model);
        void Update(UpdateCategoryDTO model);
        void Delete(int id);

        List<CategoryVM> GetCategories();
        List<CategoryVM> GetPassives();
        UpdateCategoryDTO GetById(int id);
        bool isCategoryExist(string name);


    }
}
