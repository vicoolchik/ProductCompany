using Moq;
using NUnit.Framework;
using ProductCompany.BusinessLogic.Concrete;
using ProductCompany.DAL.Interfaces;

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
    }
}
