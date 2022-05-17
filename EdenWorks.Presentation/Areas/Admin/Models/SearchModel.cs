using EdenWorks.Application.Models.VMs.ProductVM;
using EdenWorks.Domain.Entites;

namespace EdenWorks.Presentation.Areas.Admin.Models
{
    public class SearchModel
    {
        public List<ProductVM> Products { get; set; }
        public string Search { get; set; }
    }
}
