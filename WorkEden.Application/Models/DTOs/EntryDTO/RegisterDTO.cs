using EdenWorks.Domain.Enums;
using EdenWorks.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Models.DTOs.EntryDTO
{
    public class RegisterDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }

        public DateTime CreatedDate => DateTime.Now;
        public string CreatedIpAddress => CatchIP.IpAddress;
        public string CreatedMachineName => Environment.MachineName;
        public Status Status => Status.Active;
    }
}
