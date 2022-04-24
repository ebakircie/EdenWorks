using EdenWorks.Domain.Enums;
using EdenWorks.Infrastructure.Utilities;

namespace EdenWorks.Application.Models.DTOs.CategoryDTO
{
    public class CreateCategoryDTO
    {
        
        public string CategoryName { get; set; }

        public DateTime CreatedDate => DateTime.Now;
        public string CreatedIpAddress => CatchIP.IpAddress;
        public string CreatedMachineName => Environment.MachineName;
        public Status Status => Status.Active;
    }
}
