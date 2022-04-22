using EdenWorks.Domain.Enums;

namespace EdenWorks.Domain.Entites
{
    public class Category:IBaseEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

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

        public List<Product> Products { get; set; }
    }
}
