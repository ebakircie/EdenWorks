using AutoMapper;
using EdenWorks.Application.Models.DTOs.CategoryDTO;
using EdenWorks.Application.Models.DTOs.EntryDTO;
using EdenWorks.Application.Models.DTOs.ProductDTO;
using EdenWorks.Application.Models.VMs;
using EdenWorks.Application.Models.VMs.CategoryVM;
using EdenWorks.Application.Models.VMs.ProductVM;
using EdenWorks.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EdenWorks.Application.AutoMapper
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<CategoryVM,UpdateCategoryDTO>().ReverseMap();
            CreateMap<Category,CategoryVM>().ReverseMap();
            CreateMap<Category, CategoryListVM>().ReverseMap();

            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<ProductVM, UpdateProductDTO>().ReverseMap();

            CreateMap<AppUser, RegisterDTO>().ReverseMap();
            CreateMap<AppUser, LoginDTO>().ReverseMap();
            CreateMap<AppUser, AppUserVM>().ReverseMap();
            CreateMap<UpdateProductDTO,AppUserVM>().ReverseMap();
            
        }
    }
}
