using ProductСompany.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCompany.BusinessLogic.Interfaces
{
    public interface IAuthManager
    {
        bool Login(string username, string password);

        UserDTO GetUserByLogin(string username);
        UserDTO GetUserById(int id);
        List<UserDTO> GetUsers();
    }
}
