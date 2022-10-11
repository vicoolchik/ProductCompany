using AutoMapper;
using ProductCompany.DAL.Concrete;
using ProductСompany.DTO;
using System;

namespace ProductCompany
{
    internal class ProductManagerCategoryCommand
    {
        static IMapper Mapper = SetupMapper();

        private static IMapper SetupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg=>cfg.AddMaps(typeof(ProductDal).Assembly)
                );
            return config.CreateMapper();
        }

        internal void CreateProductCommand(string productName, string description)
        {
            var dal = new ProductDal(Mapper);

            var product = new ProductDTO
            {
                ProductName = productName,
                Description = description
            };
            product = dal.CreateProduct(product);
            Console.WriteLine($"New category ID : {product.CategoryID}");
        }

        internal void SelectCategoryCommand()
        {
            PrintAllCategoriesCommand();
        }

        internal void PrintAllCategoriesCommand()
        {
            var dal = new CategoryDal(Mapper);

            var categoriesList = dal.GetAllCategories();

            Console.WriteLine("\nCategories Name\n");
            foreach (var category in categoriesList)
            {
                Console.WriteLine(category.ToString());
            }
        }

        internal void EditCategoryCommand(int сategoryId, string categoryName, string description)
        {
            var dal = new CategoryDal(Mapper);

            var category = new CategoryDTO
            {
                CategoryName = categoryName,
                Description = description
            };
            category = dal.EditCategoryyByID(category, сategoryId);
            Console.WriteLine($"Edited category ID : {category.CategoryID}");
        }

        internal void DeleteCategoryCommand(int сategoryId)
        {
            var dal = new CategoryDal(Mapper);

            Console.WriteLine($"Edited category ID : {dal.DeleteCategoryByID(сategoryId).CategoryID}");
        }
    }
}
