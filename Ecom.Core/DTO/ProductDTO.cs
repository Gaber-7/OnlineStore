using Ecom.Core.Entites.Product;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public String CategoryName { get; set; }
        public List<PhotoDTO> Photos { get; set; }
    }
    public record ReturnProductDTO
    {
        public List<ProductDTO> Producties { get; set; }
        public int TotalCountx { get; set; }

    }

    public class PhotoDTO
    {
        public string ImageName { get; set; }
        public int ProductId { get; set; }
    }
    public record AddProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public int CategoryId { get; set; }
        public  IFormFileCollection Photo { get; set; }
    }
    public record UpdateProductDTO : AddProductDTO
    {
        public int Id { get; set; }
    }

}
