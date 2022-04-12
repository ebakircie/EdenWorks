using EdenWorks.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Domain.Entites
{
    public class AppUser : IdentityUser, IBaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedIpAddress { get; set; }
        public string CreatedMachineName { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public string UpdatedIpAddress { get; set; }
        public string UpdatedMachineName { get; set; }

        public DateTime? DeletedDate { get; set; }
        public string DeletedIpAddress { get; set; }
        public string DeletedMachineName { get; set; }
        public Status Status { get; set; }
    }
}
