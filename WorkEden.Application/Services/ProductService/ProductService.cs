using AutoMapper;
using EdenWorks.Application.Models.DTOs.ProductDTO;
using EdenWorks.Application.Models.VMs.CategoryVM;
using EdenWorks.Application.Models.VMs.ProductVM;
using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Enums;
using EdenWorks.Domain.Repositories;
using EdenWorks.Infrastructure.Utilities;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepo _productRepo;
        private readonly ICategoryRepo _categoryRepo;

        public ProductService(IMapper mapper, IProductRepo productRepo, ICategoryRepo categoryRepo)
        {
            _mapper = mapper;
            _productRepo = productRepo;
            _categoryRepo = categoryRepo;
        }

        public void Create(CreateProductDTO model)
        {
            var product = _mapper.Map<Product>(model);
            if (model.UploadPath != null)
            {
                using var image = Image.Load(model.UploadPath.OpenReadStream());
                image.Mutate(x => x.Resize(256, 256));
                string guid = Guid.NewGuid().ToString();
                image.Save("wwwroot/image/products/" + guid + ".jpg");
                product.ImagePath = "/image/products/" + guid + ".jpg";
            }
            _productRepo.Create(product);
        }

        public async Task Update(UpdateProductDTO model)//updated bilgilerini burada handle edicem,VM e,hidden inputlarda gerek kalmıcak. DENEME
        {
            var product = _mapper.Map<Product>(model);
            if (model.UploadPath != null)
            {
                using var image = Image.Load(model.UploadPath.OpenReadStream());
                image.Mutate(x => x.Resize(256, 256));
                string guid = Guid.NewGuid().ToString();
                image.Save("wwwroot/image/products/" + guid + ".jpg");
                product.ImagePath = "/image/products/" + guid + ".jpg";
            }
            product.Status = Status.Modified;
            product.UpdatedDate = DateTime.Now;
            product.UpdatedIpAddress = CatchIP.IpAddress;
            product.UpdatedMachineName = Environment.MachineName;
            await _productRepo.Update(product);

        }
        public async Task Delete(int id)
        {
            var product = await _productRepo.GetDefault(x => x.Id == id);
            product.Status = Status.Passive;
            product.DeletedDate = DateTime.Now;
            product.DeletedIpAddress = CatchIP.IpAddress;
            product.DeletedMachineName = Environment.MachineName;

            await _productRepo.Delete(product);
        }

        public async Task<UpdateProductDTO> GetById(int id)
        {
            var product = await _productRepo.GetFilteredFirstOrDefault(
                select: x => new ProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    ImagePath = x.ImagePath,

                },
                where: x => x.Id == id && x.Status != Status.Passive);

            var model = _mapper.Map<UpdateProductDTO>(product);

            model.Categories = await _categoryRepo.GetFilteredList(
                select: x => new CategoryListVM
                {
                    Id = x.Id,
                    CategoryName = x.CategoryName
                },
                where: x => x.Status != Status.Passive,
                orderBy: X => X.OrderBy(x => x.Id));

            return model;
        }

        public async Task<List<ProductVM>> GetPassives()
        {
            var products = await _productRepo.GetFilteredList(
                select: x => new ProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                    CategoryName = x.Category.CategoryName,

                },
                where: x => x.Status == Status.Passive,
                orderBy: x => x.OrderBy(x => x.Id),
                include: x => x.Include(x => x.Category));

            return products;
        }

        public async Task<List<ProductVM>> GetProducts()
        {
            var products = await _productRepo.GetFilteredList(
                select: x => new ProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    ImagePath = x.ImagePath,
                    CategoryName = x.Category.CategoryName
                },
                where: x => x.Status != Status.Passive,
                orderBy: x => x.OrderBy(x => x.Category.CategoryName),
                include: x => x.Include(x => x.Category));

            return products;
        }

        public async Task<List<ProductVM>> GetProductsByCategory(int categoryId)
        {
            var products = await _productRepo.GetFilteredList(
                select: x => new ProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    ImagePath = x.ImagePath,
                    CategoryName = x.Category.CategoryName
                },
                where: x => x.CategoryId == categoryId && x.Status != Status.Passive,
                orderBy: x => x.OrderBy(x => x.Name),
                include: x => x.Include(x => x.Category));

            return products;
        }

        public async Task<bool> isProductExist(string name)
        {
            var result = await _productRepo.Any(x => x.Name == name);

            return result;
        }

        public async Task SetActive(int id)
        {
            var product = await _productRepo.GetDefault(x => x.Id == id);

            product.Status = Status.Modified;
            product.UpdatedDate = DateTime.Now;
            product.UpdatedIpAddress = CatchIP.IpAddress;
            product.UpdatedMachineName = Environment.MachineName;

            await _productRepo.SetActive(product);
        }


    }
}
