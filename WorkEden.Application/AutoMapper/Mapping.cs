using AutoMapper;
using EdenWorks.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkEden.Application.Models.DTOs.CategoryDTO;
using WorkEden.Application.Models.VMs.CategoryVM;

namespace WorkEden.Application.AutoMapper
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<CategoryVM,UpdateCategoryDTO>().ReverseMap();
        }
    }
}
