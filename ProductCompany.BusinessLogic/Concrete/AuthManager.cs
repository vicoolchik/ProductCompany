using ProductCompany.BusinessLogic.Interfaces;
using ProductCompany.DAL.Interfaces;
using ProductСompany.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCompany.BusinessLogic.Concrete
{
   public class AuthManager: IAuthManager
    {
        private readonly IUserDal userDal;
        public AuthManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }

        public UserDTO GetUserByLogin(string username)
        {
            return userDal.GetUserByLogin(username);
        }

        public UserDTO GetUserById(int id)
        {
            return userDal.GetUserById(id);
        }

        public List<UserDTO> GetUsers()
        {
            return userDal.GetUsers();
        }

        public bool Login(string username, string password)
        {
            return userDal.Login(username, password);
        }
    }
}
