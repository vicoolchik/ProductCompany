using Moq;
using NUnit.Framework;
using ProductCompany.BusinessLogic.Concrete;
using ProductCompany.DAL.Interfaces;
using ProductСompany.DTO;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Tests
{
    [TestFixture]
    class AuthManagerTests
    {
        private Mock<IUserDal> userDal;
        private AuthManager manager;

        [SetUp]
        public void Setup()
        {
            userDal = new Mock<IUserDal>(MockBehavior.Strict);
            manager = new AuthManager(userDal.Object);
        }

        [Test]
        public void LoginUserTest()
        {
            string username = "user";
            string password = "pass";
            userDal.Setup(d => d.Login(username, password)).Returns(true);
            var res = manager.Login(username, password);

            Assert.IsTrue(res);
        }

        [Test]
        public void IsManagerTest()
        {
            UserDTO user = new UserDTO(); 
            userDal.Setup(d => d.IsManager(user)).Returns(true);
            var res = manager.IsManager(user);

            Assert.IsTrue(res);
        }

        [Test]
        public void GetUsersTest()
        {
            List<UserDTO> users = new List<UserDTO>();
            userDal.Setup(d => d.GetUsers()).Returns(users);
            var res = manager.GetUsers();

            Assert.IsNotNull(res);
            Assert.AreEqual(users.Count(), res.Count());;
        }

        [Test]
        public void GetUserByLoginTest()
        {
            string username = "user";
            UserDTO users = new UserDTO
            {
                UserID = 1,
                Login = username
            };
            userDal.Setup(d => d.GetUserByLogin(username)).Returns(users);
            var res = manager.GetUserByLogin(username);

            Assert.IsNotNull(res);
            Assert.AreEqual(users.UserID, res.UserID); ;
        }
    }
}
