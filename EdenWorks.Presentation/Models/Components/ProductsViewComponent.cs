using EdenWorks.Application.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace EdenWorks.Presentation.Models.Components
{
    public class ProductsViewComponent:ViewComponent
    {
        private readonly IProductService _productService;
        public ProductsViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _productService.GetProductsByCategory(id));
        }
    }
}
