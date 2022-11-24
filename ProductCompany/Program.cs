using AutoMapper;
using ProductCompany.DAL.Concrete;
using ProductСompany.DTO;
using System.Collections.Generic;

namespace ProductCompanyConsole
{
    class Program
    {
        static IMapper Mapper = SetupMapper();

        private static IMapper SetupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(UserDal).Assembly)
                );
            return config.CreateMapper();
        }
        static void Main(string[] args)
        {
            ProductManagerMenu menu = new ProductManagerMenu();
            //menu.runMenu();
            UserDal n = new UserDal(Mapper);
            //n.CreateUser("user2", "user2", "user2@gmail.com");
            List<UserDTO> l= n.GetUsers();
            n.GetUserByLogin("user2");
            n.GetUserById(1);

        }
    }
}
