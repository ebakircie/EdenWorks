using EdenWorks.Domain.Enums;
using EdenWorks.Infrastructure.Utilities;

namespace WorkEden.Application.Models.DTOs.CategoryDTO
{
    public class UpdateCategoryDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public DateTime UpdatedDate => DateTime.Now;
        public string UpdatedIpAddress => CatchIP.IpAddress;
        public string UpdatedMachineName => Environment.MachineName;
        public Status Status => Status.Modified;

        public DateTime CreatedDate { get; set; }
        public string CreatedIpAddress { get; set; }
        public string CreatedMachineName { get; set; }
    }
}
