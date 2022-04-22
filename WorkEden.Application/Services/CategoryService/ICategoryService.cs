
using WorkEden.Application.Models.DTOs.CategoryDTO;
using WorkEden.Application.Models.VMs.CategoryVM;

namespace WorkEden.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        void Create(CreateCategoryDTO model);
        void Update(UpdateCategoryDTO model);
        Task Delete(int id);

        Task SetActive(int id);
        Task<List<CategoryVM>> GetCategories();
        Task<List<CategoryVM>> GetPassives();
        Task<UpdateCategoryDTO> GetById(int id);
        Task<bool> isCategoryExist(string name);


    }
}
