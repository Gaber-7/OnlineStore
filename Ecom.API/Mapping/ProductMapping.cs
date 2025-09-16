using Ecom.Core.DTO;
using Ecom.Core.Entites.Product;

namespace Ecom.API.Mapping
{
    public class ProductMapping : AutoMapper.Profile    
    {
        public ProductMapping() 
        {
            CreateMap<Product, ProductDTO>()
                    .ForMember(dest => dest.CategoryName, 
                    opt => opt.MapFrom(src => src.Category.Name)).ReverseMap();
               
            CreateMap<Photo,PhotoDTO>().ReverseMap();


        }
    }
}
