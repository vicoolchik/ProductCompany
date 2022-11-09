using ProductСompany.DTO;
using System.Collections.Generic;

namespace ProductCompany.DAL.Interfaces
{
    public interface IUserDal
    {
        bool Login(string username, string password);

        UserDTO GetUserByLogin(string username);
        UserDTO GetUserById(int id);
        List<UserDTO> GetUsers();
    }
}
