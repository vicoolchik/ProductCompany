using ProductСompany.DTO;
using System.Collections.Generic;

namespace ProductCompany.DAL.Interfaces
{
    public interface ICategoryDal
    {
        List<CategoryDTO> GetAllCategories();
        CategoryDTO CreateCategory(CategoryDTO category);
        CategoryDTO DeleteCategoryByID(int id);
        CategoryDTO EditCategoryyByID(CategoryDTO category, int id);
    }
}
