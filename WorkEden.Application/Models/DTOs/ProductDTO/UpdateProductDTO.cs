using EdenWorks.Application.Models.VMs.CategoryVM;
using EdenWorks.Domain.Enums;
using EdenWorks.Infrastructure.Utilities;
using Microsoft.AspNetCore.Http;

namespace EdenWorks.Application.Models.DTOs.ProductDTO
{
    public class UpdateProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //public string ImagePath {get; set;} denenmedi
        public IFormFile? UploadPath { get; set; }

        public DateTime UpdatedDate => DateTime.Now;
        public string UpdatedIpAddress => CatchIP.IpAddress;
        public string UpdatedMachineName => Environment.MachineName;
        public Status Status => Status.Modified;

        public DateTime CreatedDate { get; set; }
        public string CreatedIpAddress { get; set; }
        public string CreatedMachineName { get; set; }

        public int CategoryId { get; set; }
        public List<CategoryListVM>? Categories { get; set; }
    }
}
