using EdenWorks.Application.Models.VMs.CategoryVM;
using EdenWorks.Domain.Enums;
using EdenWorks.Infrastructure.Utilities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Models.DTOs.ProductDTO
{
    public class CreateProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        public IFormFile? UploadPath { get; set; }

        public DateTime CreatedDate => DateTime.Now;
        public string CreatedIpAddress => CatchIP.IpAddress;
        public string CreatedMachineName => Environment.MachineName;

        public Status Status => Status.Active;

        public int? CategoryId { get; set; }
        public List<CategoryListVM>? Categories { get; set; }



    }
}
