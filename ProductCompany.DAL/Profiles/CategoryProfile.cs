using AutoMapper;
using ProductСompany.DTO;

namespace ProductCompany.DAL.Profiles
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}