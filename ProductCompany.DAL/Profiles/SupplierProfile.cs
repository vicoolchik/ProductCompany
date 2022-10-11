using AutoMapper;
using ProductСompany.DTO;

namespace ProductCompany.DAL.Profiles
{
    class SupplierProfile : Profile
    {
        public SupplierProfile()

        {
            CreateMap<Supplier, SupplierDTO>().ReverseMap();
        }
    }
}
