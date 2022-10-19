using AutoMapper;
using NUnit.Framework;
using ProductCompany.DAL.Concrete;
using System;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using ProductСompany.DTO;
using System.Data;

namespace Dal.Tests
{
    [TestFixture]
    class ProductDalTests 
    {
        private IMapper Mapper;
        private string _testProduct;
        private SqlConnection _connection;
        ProductDTO newProduct;

        [OneTimeSetUp]
        public void SetupOnce()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(ProductDal).Assembly)
                );
            Mapper = config.CreateMapper();

            string connStr = ConfigurationManager.ConnectionStrings["Product Company"].ConnectionString;
            _connection = new SqlConnection(connStr);
            _connection.Open();

            InsertTestProduct();
        }

        [OneTimeTearDown]
        public void TearDownOnce()
        {
            DeleteTestProduct();
            _connection.Close();
        }

        private void DeleteTestProduct()
        {
            using (var comm = _connection.CreateCommand())
            {
                comm.CommandText = "delete Products where ProductName = @Product1";
                comm.Parameters.Add(new SqlParameter("Product1", _testProduct));

                comm.ExecuteNonQuery();
            }
        }

        private void InsertTestProduct()
        {
            _testProduct = Guid.NewGuid().ToString(); 

            using (var comm = _connection.CreateCommand())
            {
                comm.CommandText = "insert into Products (ProductName, SupplierID,CategoryID,UnitPrice,UnitsInStock,UnitsOnOnder,Discontinued) values (@Product1, 1, 1, 0, 0,0 ,1)";
                comm.Parameters.Add(new SqlParameter("Product1", _testProduct));

                comm.ExecuteNonQuery();
            }
        }

        [Test]
        public void CanReadFromDB()
        {
            //Arrange
            var dal = new ProductDal(Mapper);

            //Act
            var productsList = dal.GetAllProductsByCategoryID(1);

            //Assert
            Assert.IsNotNull(productsList);
            Assert.Contains(_testProduct, productsList.Select(d => d.ProductName).ToList());
        }

        [Test]
        public void CreateProductTest()
        {
            var dal = new ProductDal(Mapper);

            newProduct = new ProductDTO
            {
                ProductName = "NewCategory",
                SupplierID = 1,
                CategoryID = 1,
                UnitPrice = 0,
                UnitsInStock = 0,
                UnitsOnOnder = 0,
                Discontinued = true
            };

            Assert.IsTrue(dal.CreateProduct(newProduct).CategoryID != 0);
        }


        [Test]
        public void DeleteProductTest()
        {
            var dal = new ProductDal(Mapper);

            var productsList = dal.GetAllProductsByCategoryID(1);
            var id= productsList.SingleOrDefault(x => x.ProductName == "NewCategory").ProductID;

            Assert.IsTrue(dal.DeleteProductByID(id).ProductID == id);
        }

        [Test]
        public void EditProductTest()
        {
            ProductDTO newProduct = new ProductDTO
            {
                UnitPrice = 10
            };

            var dal = new ProductDal(Mapper);

            var productsList = dal.GetAllProductsByCategoryID(1);
            int id = productsList.SingleOrDefault(x => x.ProductName == _testProduct).ProductID;

            Assert.IsTrue(dal.EditProductByID(newProduct, id).UnitPrice == newProduct.UnitPrice);
        }

    }
}
