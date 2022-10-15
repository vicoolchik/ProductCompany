using AutoMapper;
using ProductCompany.DAL.Interfaces;
using ProductСompany.DTO;
using System.Collections.Generic;
using System.Linq;

namespace ProductCompany.DAL.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private readonly IMapper _mapper;
        public CategoryDal(IMapper mapper) 
        {
            _mapper = mapper;
        }


        public CategoryDTO CreateCategory(CategoryDTO category)
        {
           using (var entites = new Product_companyEntities())
            {
                var catedoryInDB = _mapper.Map<Category>(category);
                catedoryInDB.RowInsertTime = System.DateTime.Now;
                catedoryInDB.RowUpdateTime= System.DateTime.Now;
                entites.Categories.Add(catedoryInDB);
                entites.SaveChanges();
                return _mapper.Map<CategoryDTO>(catedoryInDB);
            }
        }

        public List<CategoryDTO> GetAllCategories()
        {
            using (var entities = new Product_companyEntities())
            {
                var categories = entities.Categories.ToList();
                return _mapper.Map<List<CategoryDTO>>(categories);
            }
        }

        public CategoryDTO EditCategoryyByID(CategoryDTO category, int id)
        {
            using (var entites = new Product_companyEntities())
            {
                var catedoryInDB = _mapper.Map<Category>(category);
                catedoryInDB =entites.Categories.SingleOrDefault(x => x.CategoryID == id);
                if (catedoryInDB != null)
                {
                    catedoryInDB.RowUpdateTime = System.DateTime.Now;
                    catedoryInDB.CategoryName= category.CategoryName;
                    catedoryInDB.Description= category.Description;
                    entites.SaveChanges();
                    return _mapper.Map<CategoryDTO>(catedoryInDB);
                }
                return null;
            }
        }

        public CategoryDTO DeleteCategoryByID(int id)
        {
            using (var entites = new Product_companyEntities())
            {
                var catedoryInDB = entites.Categories.SingleOrDefault(x => x.CategoryID == id);
                if (catedoryInDB != null)
                {
                    var productsInDB = entites.Products.Where(x => x.CategoryID == id).ToList();
                    foreach (var product in productsInDB)
                    {
                        product.RowUpdateTime = System.DateTime.Now;
                        product.Discontinued = false;
                        product.CategoryID = 0;
                    }
                    entites.Categories.Remove(catedoryInDB);
                    entites.SaveChanges();
                    return _mapper.Map<CategoryDTO>(catedoryInDB);
                }
                return null;
            }
        }

    }
}
