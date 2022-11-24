using ProductСompany.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCompany.BusinessLogic.Interfaces
{
    public interface IProductCompanyManager
    {
        List<CategoryDTO> GetListOfCategories();
        CategoryDTO AddCategory(CategoryDTO category);
        CategoryDTO DeleteCategoryByID(int id);
        CategoryDTO UpdateCategoryyByID(CategoryDTO category, int id);

        List<ProductDTO> GetListOfProductsByCategoryID(int categoryID);
        ProductDTO AddProduct(ProductDTO product);
        ProductDTO UpdateProductByID(ProductDTO product, int id);
        ProductDTO DeleteProductByID(int id);
        List<ProductDTO> GetListOfProducts();
        ProductDTO BlockProductByID(int id);


        bool EditAllowed(UserDTO user);

        List<SupplierDTO> GetAllSuppliers();

    }
}
