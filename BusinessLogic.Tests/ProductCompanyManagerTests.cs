using Moq;
using NUnit.Framework;
using ProductCompany.BusinessLogic.Concrete;
using ProductCompany.BusinessLogic.Interfaces;
using ProductCompany.DAL.Interfaces;
using ProductСompany.DTO;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Tests
{
    [TestFixture]
    class ProductCompanyManagerTests
    {
        private Mock<IProductDal> productDal;
        private Mock<ICategoryDal> categoryDal;
        private Mock<ISupplierDal> supplierDal;
        private Mock<IAuthManager> authManager;
        private ProductCompanyManager manager;

        [SetUp]
        public void SetUp()
        {
            productDal = new Mock<IProductDal>(MockBehavior.Strict);
            categoryDal = new Mock<ICategoryDal>(MockBehavior.Strict);
            supplierDal = new Mock<ISupplierDal>(MockBehavior.Strict);
            authManager = new Mock<IAuthManager>(MockBehavior.Strict);

            manager = new ProductCompanyManager(categoryDal.Object, productDal.Object, supplierDal.Object, authManager.Object);
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

        [Test]
        public void DeleteProductByIDTest()
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

            productDal.Setup(d => d.DeleteProductByID(inProduct.ProductID)).Returns(outProduct);
            var res = manager.DeleteProductByID(inProduct.ProductID);

            Assert.IsNotNull(res);
            Assert.AreEqual(outProduct.ProductID, res.ProductID);
        }

        [Test]
        public void UpdateProductByIDTest()
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

            productDal.Setup(d => d.DeleteProductByID(inProduct.ProductID)).Returns(outProduct);
            var res = manager.DeleteProductByID(inProduct.ProductID);

            Assert.IsNotNull(res);
            Assert.AreEqual(outProduct.ProductID, res.ProductID);
        }

        [Test]
        public void BlockProductByIDTest()
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

            productDal.Setup(d => d.BlockProductByID(inProduct.ProductID)).Returns(outProduct);
            var res = manager.BlockProductByID(inProduct.ProductID);

            Assert.IsNotNull(res);
            Assert.AreEqual(outProduct.ProductID, res.ProductID);
        }

        [Test]
        public void GetListOfProductsTest()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            productDal.Setup(d => d.GetAllProducts()).Returns(products);
            var res = manager.GetListOfProducts();

            Assert.IsNotNull(res);
            Assert.AreEqual(products.Count(), res.Count()); ;
        }

        [Test]
        public void GetListOfProductsByCategoryIDTest()
        {
            int categoryId = 1;
            List<ProductDTO> products = new List<ProductDTO>();
            productDal.Setup(d => d.GetAllProductsByCategoryID(categoryId)).Returns(products);
            var res = manager.GetListOfProductsByCategoryID(categoryId);

            Assert.IsNotNull(res);
            Assert.AreEqual(products.Count(), res.Count()); ;
        }

        [Test]
        public void AddCategoryTest()
        {
            CategoryDTO inCategory = new CategoryDTO
            {
                CategoryName = "Test",
                CategoryID = 1
            };
            CategoryDTO outCategory = new CategoryDTO { CategoryID = 1 };

            categoryDal.Setup(d => d.CreateCategory(inCategory)).Returns(outCategory);
            var res = manager.AddCategory(inCategory);

            Assert.IsNotNull(res);
            Assert.AreEqual(outCategory.CategoryID, res.CategoryID);
        }



        [Test]
        public void DeleteCategoryByIDTest()
        {
            CategoryDTO inCategory = new CategoryDTO
            {
                CategoryName = "Test",
                CategoryID = 1
            };
            CategoryDTO outCategory = new CategoryDTO { CategoryID = 1 };

            categoryDal.Setup(d => d.DeleteCategoryByID(inCategory.CategoryID)).Returns(outCategory);
            var res = manager.DeleteCategoryByID(inCategory.CategoryID);

            Assert.IsNotNull(res);
            Assert.AreEqual(outCategory.CategoryID, res.CategoryID);
        }

        [Test]
        public void GetListOfCategoriesTest()
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            categoryDal.Setup(d => d.GetAllCategories()).Returns(categories);
            var res = manager.GetListOfCategories();

            Assert.IsNotNull(res);
            Assert.AreEqual(categories.Count(), res.Count()); ;
        }

        [Test]
        public void UpdateCategoryyByIDTest()
        {
            CategoryDTO inCategory = new CategoryDTO
            {
                CategoryName = "Test",
                CategoryID = 1
            };
            CategoryDTO outCategory = new CategoryDTO { CategoryID = 1 };

            categoryDal.Setup(d => d.EditCategoryyByID(inCategory, inCategory.CategoryID)).Returns(outCategory);
            var res = manager.UpdateCategoryyByID(inCategory, inCategory.CategoryID);

            Assert.IsNotNull(res);
            Assert.AreEqual(outCategory.CategoryID, res.CategoryID);
        }
    }
}
