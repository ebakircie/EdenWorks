using EdenWorks.Domain.Enums;
using EdenWorks.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Models.DTOs.EntryDTO
{
    public class UpdateProfileDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime UpdatedDate => DateTime.Now;
        public string UpdatedIpAddress => CatchIP.IpAddress;
        public string UpdatedMachineName => Environment.MachineName;
        public Status Status => Status.Modified;
        public DateTime CreatedDate { get; set; }
        public string CreatedIpAddress { get; set; }
        public string CreatedMachineName { get; set; }
    }
}
