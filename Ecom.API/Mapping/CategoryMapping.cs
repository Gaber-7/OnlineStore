using AutoMapper;
using Ecom.Core.DTO;
using Ecom.Core.Entites.Product;

namespace Ecom.API.Mapping
{
    public class CategoryMapping : Profile
    { 
        public CategoryMapping()
        {

            // CreateMap<Source, Destination>();
            CreateMap<CategoryDTO , Category>().ReverseMap();

            CreateMap<UpdateCategoryDTO, Category>().ReverseMap();

        }
    }
}
