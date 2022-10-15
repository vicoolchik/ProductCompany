using AutoMapper;
using NUnit.Framework;
using ProductCompany.DAL.Concrete;
using System;
using System.Linq;
using System.EnterpriseServices;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;
using ProductСompany.DTO;

namespace Dal.Tests
{
    [TestFixture]
    [Transaction(TransactionOption.RequiresNew), ComVisible(true)]
    class CategoryDalTestWithTransaction : ServicedComponent
    {
        private IMapper _mapper;

        [OneTimeSetUp]
        public void SetupOnce()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(CategoryDal).Assembly)
                );
            _mapper = config.CreateMapper();
        }

        //[Test]
        //public void CteateTest()
        //{
        //    CategoryDal dal = new CategoryDal(_mapper);

        //    var result = dal.CreateCategory(new CategoryDTO
        //    {
        //        RowInsertTime = System.DateTime.Now,
        //        RowUpdateTime = System.DateTime.Now,
        //        CategoryName = "NewCategory"
        //    });

        //    Assert.IsTrue(result.CategoryID != 0);
        //}


        [TearDown]
        public void TearDown()
        {
            if (ContextUtil.IsInTransaction)
            {
                ContextUtil.SetAbort();
            }
        }
    }
}
