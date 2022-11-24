using ProductCompany.BusinessLogic.Interfaces;
using ProductCompany.DAL.Interfaces;
using ProductСompany.DTO;
using System.Collections.Generic;

namespace ProductCompany.BusinessLogic.Concrete
{
    public class ProductCompanyManager: IProductCompanyManager
    {
        private readonly ICategoryDal categoryDal;
        private readonly IProductDal productDal;
        private readonly ISupplierDal supplierDal;
        private readonly IAuthManager authManager;

        public ProductCompanyManager(ICategoryDal categoryDal, IProductDal productDal, ISupplierDal supplierDal, IAuthManager authManager)
        {
            this.categoryDal = categoryDal;
            this.productDal = productDal;
            this.supplierDal = supplierDal;
            this.authManager = authManager;
        }

        public ProductDTO AddProduct(ProductDTO product)
        {
            return productDal.CreateProduct(product);
        }

        public List<ProductDTO> GetListOfProductsByCategoryID(int categoryID)
        {
            return productDal.GetAllProductsByCategoryID(categoryID);
        }

        public List<CategoryDTO> GetListOfCategories()
        {
            return categoryDal.GetAllCategories();
        }

        public CategoryDTO AddCategory(CategoryDTO category)
        {
            return categoryDal.CreateCategory(category);
        }

        public CategoryDTO DeleteCategoryByID(int id)
        {
            return categoryDal.DeleteCategoryByID(id);
        }

        public CategoryDTO UpdateCategoryyByID(CategoryDTO category, int id)
        {
            return categoryDal.EditCategoryyByID(category, id);
        }

        public ProductDTO UpdateProductByID(ProductDTO product, int id)
        {
            return productDal.EditProductByID(product, id);
        }

        public ProductDTO DeleteProductByID(int id)
        {
            return productDal.DeleteProductByID(id);
        }

        public List<ProductDTO> GetListOfProducts()
        {
            return productDal.GetAllProducts();
        }
        public bool EditAllowed(UserDTO user)
        {
            return  authManager.IsManager(user);             
        }
        public  List<SupplierDTO> GetAllSuppliers()
        {
            return supplierDal.GetAllSuppliers();
        }

        public ProductDTO BlockProductByID(int id)
        {
            return productDal.BlockProductByID(id);
        }
    }
}
