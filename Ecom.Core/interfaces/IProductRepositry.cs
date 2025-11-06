using Ecom.Core.DTO;
using Ecom.Core.Entites.Product;
using Ecom.Core.Sharing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.interfaces
{
    public interface IProductRepositry : IGenericRepositry<Product> 
    {
        // Add any additional methods specific to Product repository if needed
        Task<ReturnProductDTO> GetAllAsync(ProductParams productParams);
        Task<bool> AddAsync(AddProductDTO productDTO);
        Task<bool> UpdateAsync(UpdateProductDTO updateProductDTO);
        Task DeleteAsync(Product product);  
    }
}
