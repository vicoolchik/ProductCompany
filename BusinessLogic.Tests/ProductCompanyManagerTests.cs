using Moq;
using NUnit.Framework;
using ProductCompany.BusinessLogic.Concrete;
using ProductCompany.DAL.Interfaces;
using ProductСompany.DTO;

namespace BusinessLogic.Tests
{
    [TestFixture]
    class ProductCompanyManagerTests
    {
        private Mock<IProductDal> productDal;
        private Mock<ICategoryDal> categoryDal;
        private Mock<ISupplierDal> supplierDal;
        private ProductCompanyManager manager;

        [SetUp]
        public void SetUp()
        {
            productDal = new Mock<IProductDal>(MockBehavior.Strict);
            categoryDal = new Mock<ICategoryDal>(MockBehavior.Strict);
            supplierDal = new Mock<ISupplierDal>(MockBehavior.Strict);

            manager = new ProductCompanyManager(categoryDal.Object, productDal.Object, supplierDal.Object);
        }

        [Test]
        public void AddProductTest()
        {
            ProductDTO inProduct = new ProductDTO
            {
                ProductName = "Test",
                ProductID = 1,
                SupplierID = 1,
                CategoryID = 1,
                UnitPrice = 0,
                UnitsInStock = 0,
                UnitsOnOnder = 0,
                Discontinued = true
            };
            ProductDTO outProduct = new ProductDTO { ProductID = 1 };

            productDal.Setup(d => d.CreateProduct(inProduct)).Returns(outProduct);
            var res = manager.AddProduct(inProduct);

            Assert.IsNotNull(res);
            Assert.AreEqual(outProduct.ProductID, res.ProductID);
        }
    }
}
