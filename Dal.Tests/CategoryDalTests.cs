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
    class CategoryDalTests 
    {
        private IMapper Mapper;
        private string _testCategory;
        private SqlConnection _connection;
        CategoryDTO newCtegory;

        [OneTimeSetUp]
        public void SetupOnce()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(CategoryDal).Assembly)
                );
            Mapper = config.CreateMapper();

            string connStr = ConfigurationManager.ConnectionStrings["Product Company"].ConnectionString;
            _connection = new SqlConnection(connStr);
            _connection.Open();

            InsertTestCategory();
        }

        [OneTimeTearDown]
        public void TearDownOnce()
        {
            DeleteTestCategory();
            _connection.Close();
        }

        private void DeleteTestCategory()
        {
            using (var comm = _connection.CreateCommand())
            {
                comm.CommandText = "delete Categories where CategoryName = @Category1";
                comm.Parameters.Add(new SqlParameter("Category1", _testCategory));

                comm.ExecuteNonQuery();
            }
        }

        private void InsertTestCategory()
        {
            _testCategory = Guid.NewGuid().ToString(); 

            using (var comm = _connection.CreateCommand())
            {
                comm.CommandText = "insert into Categories (CategoryName) values (@Category1)";
                comm.Parameters.Add(new SqlParameter("Category1", _testCategory));

                comm.ExecuteNonQuery();
            }
        }

        [Test]
        public void CanReadFromDB()
        {
            //Arrange
            var dal = new CategoryDal(Mapper);

            //Act
            var categoriesList = dal.GetAllCategories();

            //Assert
            Assert.IsNotNull(categoriesList);
            Assert.Contains(_testCategory, categoriesList.Select(d => d.CategoryName).ToList());
        }

        [Test]
        public void CreateCategoryTest()
        {
            var dal = new CategoryDal(Mapper);

            newCtegory = new CategoryDTO
            {
                CategoryName = "NewCategory"
            };

            Assert.IsTrue(dal.CreateCategory(newCtegory).CategoryID != 0);
        }


        [Test]
        public void DeleteCategoryTest()
        {
            var dal = new CategoryDal(Mapper);

            var categoriesList = dal.GetAllCategories();
            var id= categoriesList.SingleOrDefault(x => x.CategoryName == "NewCategory").CategoryID;

            Assert.IsTrue(dal.DeleteCategoryByID(id).CategoryID == id);
        }

        [Test]
        public void EditCategoryTest()
        {
            CategoryDTO newCtegory = new CategoryDTO
            {
                CategoryName = "NewCategory2"
            };

            var dal = new CategoryDal(Mapper);

            var categoriesList = dal.GetAllCategories();
            int id = categoriesList.SingleOrDefault(x => x.CategoryName == _testCategory).CategoryID;

            _testCategory = newCtegory.CategoryName;
            Assert.IsTrue(dal.EditCategoryyByID(newCtegory, id).CategoryName== _testCategory);
        }

    }
}
