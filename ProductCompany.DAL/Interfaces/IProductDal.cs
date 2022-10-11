using System.Collections.Generic;
using ProductСompany.DTO;

namespace ProductCompany.DAL.Interfaces
{
    public interface IProductDal
    {
        List<ProductDTO> GetAllProducts();
        ProductDTO CreateProduct(ProductDTO product);
    }
}
