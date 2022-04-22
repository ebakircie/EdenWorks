using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEden.Application.Models.VMs.CategoryVM
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedIpAddress { get; set; }
        public string CreatedMachineName { get; set; }
    }
}
