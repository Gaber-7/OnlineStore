using Ecom.Core.Entites.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public String CategoryName { get; set; }
        
        public List<PhotoDTO> Photos { get; set; }
    }
    public class PhotoDTO
    {
        public string ImageName { get; set; }
        public int ProductId { get; set; }
    }
}
