using AutoMapper;
using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Repositories;
using EdenWorks.Domain.Enums;
using WorkEden.Application.Models.DTOs.CategoryDTO;
using WorkEden.Application.Models.VMs.CategoryVM;
using EdenWorks.Infrastructure.Utilities;

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

        public async Task Delete(int id)
        {
            Category category = await _categoryRepo.GetDefault(x => x.Id == id);
            category.DeletedDate = DateTime.Now;
            category.DeletedIpAddress = CatchIP.IpAddress;
            category.DeletedMachineName = Environment.MachineName;
            category.Status = Status.Passive;
            await _categoryRepo.Delete(category);
        }

       public async Task SetActive(int id)
        {
            Category category = await _categoryRepo.GetDefault(x => x.Id == id);
            category.UpdatedDate = DateTime.Now;
            category.UpdatedIpAddress = CatchIP.IpAddress;
            category.UpdatedMachineName = Environment.MachineName;
            category.Status = Status.Modified;
            await _categoryRepo.SetActive(category);
        }
        public void Update(UpdateCategoryDTO model)
        {
            var category = _mapper.Map<Category>(model);
            _categoryRepo.Update(category);
        }


        public async Task<UpdateCategoryDTO> GetById(int id)
        {
            var category = await _categoryRepo.GetFilteredFirstOrDefault(
                select: x => new CategoryVM
                {
                    Id = x.Id,
                    CategoryName = x.CategoryName,
                    CreatedDate = x.CreatedDate,
                    CreatedIpAddress = x.CreatedIpAddress,
                    CreatedMachineName = x.CreatedMachineName,
                    
                },
                where: x => x.Id == id&&
                            x.Status != Status.Passive);

            var model = _mapper.Map<UpdateCategoryDTO>(category);
            return model;
        }

        public async Task<List<CategoryVM>> GetCategories()
        {
            var categories = await _categoryRepo.GetFilteredList(
                select: x => new CategoryVM
                {
                    Id = x.Id,
                    CategoryName = x.CategoryName
                },
                where: x => x.Status != Status.Passive,
                orderBy: x => x.OrderBy(x => x.Id));

            return categories;
        }
        public async Task<List<CategoryVM>> GetPassives()
        {
            var categories = await _categoryRepo.GetFilteredList(
                select: x => new CategoryVM
                {
                    Id = x.Id,
                    CategoryName = x.CategoryName
                },
                where: x => x.Status == Status.Passive);

            return categories;
        }

        public async Task<bool> isCategoryExist(string name)
        {
            var result = await _categoryRepo.Any(x => x.CategoryName == name);
            return result;
        }


    }
}
