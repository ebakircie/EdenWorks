using EdenWorks.Application.Models.DTOs.CategoryDTO;
using EdenWorks.Application.Models.VMs.CategoryVM;

namespace EdenWorks.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        void Create(CreateCategoryDTO model);
        Task Update(UpdateCategoryDTO model);
        Task Delete(int id);

        Task SetActive(int id);
        Task<List<CategoryVM>> GetCategories();
        Task<List<CategoryListVM>> GetCategoriesList();
        Task<List<CategoryVM>> GetPassives();
        Task<UpdateCategoryDTO> GetById(int id);
        Task<bool> isCategoryExist(string name);


    }
}
