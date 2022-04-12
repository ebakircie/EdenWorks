using EdenWorks.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Domain.Entites
{
    public class Product : IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

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

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
