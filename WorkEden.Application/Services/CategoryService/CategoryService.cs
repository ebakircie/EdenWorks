using AutoMapper;
using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Repositories;
using EdenWorks.Domain.Enums;
using WorkEden.Application.Models.DTOs.CategoryDTO;
using WorkEden.Application.Models.VMs.CategoryVM;

namespace WorkEden.Application.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepo categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public void Create(CreateCategoryDTO model)
        {
            var category = _mapper.Map<Category>(model);

            _categoryRepo.Create(category);
        }

        public void Delete(int id)
        {
            Category category = _categoryRepo.GetDefault(x => x.Id == id);
            category.DeletedDate = DateTime.Now;
            category.Status = Status.Passive;

            _categoryRepo.Delete(category);
        }
        public void Update(UpdateCategoryDTO model)
        {
            var updateCategory = _mapper.Map<Category>(model);
            _categoryRepo.Update(updateCategory);
        }
        

        public UpdateCategoryDTO GetById(int id)
        {
            var category = _categoryRepo.GetFilteredFirstOrDefault(
                select: x => new CategoryVM
                {
                    Id = x.Id,
                    CategoryName = x.CategoryName,
                },
                where: x => x.Id == id);

            var model = _mapper.Map<UpdateCategoryDTO>(category);
            return model;
        }

        public List<CategoryVM> GetCategories()
        {
            var categories = _categoryRepo.GetFilteredList(
                select: x => new CategoryVM
                {
                    Id = x.Id,
                    CategoryName = x.CategoryName
                },
                where: x => x.Status != Status.Passive,
                orderBy: x => x.OrderBy(x => x.CategoryName));

            return categories;
        }
        public List<CategoryVM> GetPassives()
        {
            var categories = _categoryRepo.GetFilteredList(
                select: x => new CategoryVM
                {
                    Id = x.Id,
                    CategoryName= x.CategoryName
                },
                where: x=> x.Status == Status.Passive);

            return categories;
        }

        public bool isCategoryExist(string name)
        {
            var result = _categoryRepo.Any(x => x.CategoryName == name);
            return result;
        }

   
    }
}
