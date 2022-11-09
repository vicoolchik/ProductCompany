using AutoMapper;
using ProductСompany.DTO;
using System.Linq;

namespace ProductCompany.DAL.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Role, RoleDTO>();

            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Roles,
                src => src.MapFrom(u => u.UserRoles.Select(up => up.Role)));

            CreateMap<UserDTO, User>()
                .ForMember(dest => dest.UserRoles,
                src => src.MapFrom(u => u.Roles.Select(p => new UserRole
                {
                    UserID = u.UserID,
                    RoleID = p.RoleID,
                    RowInsertTime = System.DateTime.Now,
                    RowUpdateTime = System.DateTime.Now

                })));
        }
    }
}
