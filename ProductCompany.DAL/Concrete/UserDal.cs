using AutoMapper;
using ProductCompany.DAL.Interfaces;
using ProductСompany.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ProductCompany.DAL.Concrete
{
    public class UserDal: IUserDal
    {
        protected readonly IMapper mapper;

        public UserDal(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public UserDTO CreateUser(string username, string password, string email)
        {
            using (var entities =new Product_companyEntities())
            {
                if (entities.Users.Any(u => u.Login == username))
                {
                    throw new Exception("User already exists!"); 
                }
                Guid salt = Guid.NewGuid();
                var user = new User
                {
                    Login = username,
                    EMail = email,
                    Salt = salt,
                    Password = hash(password, salt.ToString()),
                    RowInsertTime = System.DateTime.Now,
                    RowUpdateTime = System.DateTime.Now
                };
                entities.Users.Add(user);
                entities.SaveChanges();
                return mapper.Map<UserDTO>(user);
            }
        }

        public UserDTO GetUserById(int id)
        {
            using (var entities = new Product_companyEntities())
            {
                return mapper.Map<UserDTO>(entities.Users
                    .Include(db => db.UserRoles.Select(c => c.Role))
                    .SingleOrDefault(u => u.UserID == id)
                    );
            }
        }

        public bool Login(string username, string password)
        {
            using(var entities = new Product_companyEntities())
            {
                User user = entities.Users.SingleOrDefault(u => u.Login == username);
                return user != null && user.Password.SequenceEqual(hash(password, user.Salt.ToString()));
            }
        }

        private byte[] hash(string password, string salt)
        {
            var alg = SHA512.Create();
            return alg.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
        }

        public UserDTO GetUserByLogin(string username)
        {
            using (var entities = new Product_companyEntities())
            {
                return mapper.Map<UserDTO>(entities.Users
                    .Include(db => db.UserRoles.Select(c => c.Role))
                    .SingleOrDefault(u => u.Login == username)
                    );
            }
        }

        public List<UserDTO> GetUsers()
        {
            using (var entities = new Product_companyEntities())
            {
                return mapper.Map<List<UserDTO>>(entities.Users
                    .Include(db => db.UserRoles.Select(c => c.Role))
                    );
            }
        }

        public bool IsManager(UserDTO user)
        {
                var roles = user.Roles;
                foreach(RoleDTO r in roles)
                {
                    if (r.Name == "manager")
                    {
                        return true;
                    }
                }
                return false;         
        }
    }
}
