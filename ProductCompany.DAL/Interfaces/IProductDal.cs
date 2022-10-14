using System.Collections.Generic;
using ProductСompany.DTO;

namespace ProductCompany.DAL.Interfaces
{
    public interface IProductDal
    {
        List<ProductDTO> GetAllProductsByCategoryID(int categoryID);
        ProductDTO CreateProduct(ProductDTO product);
        ProductDTO EditProductByID(ProductDTO product, int id);
        ProductDTO DeleteProductByID(int id);
    }
}
