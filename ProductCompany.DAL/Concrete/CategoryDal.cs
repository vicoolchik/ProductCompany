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

        public CategoryDTO GetCategoryByID(int id)
        {
            using (var entities = new Product_companyEntities())
            {
                var categoryID = entities.Categories.Select(x => x.CategoryID).ToList();
                var category = entities.Categories.Where(x => categoryID.Contains(id)).ToList();
                return _mapper.Map<CategoryDTO>(category[0]);
            }
        }

        public CategoryDTO EditCategoryyByID(CategoryDTO category, int _id)
        {
            using (var entites = new Product_companyEntities())
            {
                var catedoryInDB = _mapper.Map<Category>(category);
                catedoryInDB =entites.Categories.SingleOrDefault(x => x.CategoryID == _id);
                if (catedoryInDB != null)
                {
                    catedoryInDB.RowUpdateTime = System.DateTime.Now;
                    catedoryInDB.CategoryName= category.CategoryName;
                    catedoryInDB.Description= category.Description;
                    entites.SaveChanges();
                }
                return _mapper.Map<CategoryDTO>(catedoryInDB);
            }
        }

        public CategoryDTO DeleteCategoryByID(int id)
        {
            using (var entites = new Product_companyEntities())
            {
                var catedoryInDB = entites.Categories.SingleOrDefault(x => x.CategoryID == id);
                //catedoryInDB = _mapper.Map<Category>(catedoryInDB);
                if (catedoryInDB != null)
                {
                    entites.Categories.Remove(catedoryInDB);
                    entites.SaveChanges();
                }
                return _mapper.Map<CategoryDTO>(catedoryInDB);
            }
        }

    }
}
