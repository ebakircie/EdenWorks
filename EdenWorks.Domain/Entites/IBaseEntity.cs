using EdenWorks.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Domain.Entites
{
    public interface IBaseEntity
    {
        //Basic Audit fields for all entities. 
         DateTime CreatedDate { get; set; }
         string CreatedIpAddress { get; set; }
         string CreatedMachineName { get; set; }
   
        DateTime? UpdatedDate { get; set; }
        string UpdatedIpAddress { get; set; }
        string UpdatedMachineName { get; set; }
        
        DateTime? DeletedDate { get; set; }
        string DeletedIpAddress { get; set; }
        string DeletedMachineName { get; set; }
        Status Status { get; set; }
    }
}
