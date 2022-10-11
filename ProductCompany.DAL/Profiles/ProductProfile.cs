using AutoMapper;
using ProductСompany.DTO;

namespace ProductCompany.DAL.Profiles
{
    class ProductProfile : Profile
    {
        public ProductProfile()

        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}