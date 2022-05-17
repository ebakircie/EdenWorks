using EdenWorks.Application.Models.DTOs.ProductDTO;
using EdenWorks.Application.Models.VMs.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Services.ProductService
{
    public interface IProductService
    {
        void Create(CreateProductDTO model);
        Task Update(UpdateProductDTO model);
        Task Delete(int id);

        Task SetActive(int id);
        Task<List<ProductVM>> GetProducts();
        Task<List<ProductVM>> GetProductsByName(string name);
        Task<List<ProductVM>> GetProductsByCategory(int categoryId);
        Task<List<ProductVM>> GetPassives();
        Task<UpdateProductDTO> GetById(int id);
        Task<bool> isProductExist(string name);
    }
}
