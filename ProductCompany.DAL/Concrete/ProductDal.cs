using AutoMapper;
using ProductCompany.DAL.Interfaces;
using ProductСompany.DTO;
using System.Collections.Generic;
using System.Linq;

namespace ProductCompany.DAL.Concrete
{
    public class ProductDal : IProductDal
    {
        private readonly IMapper _mapper;
        public ProductDal(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ProductDTO CreateProduct(ProductDTO product)
        {
            using (var entites = new Product_companyEntities())
            {
                var productInDB = _mapper.Map<Product>(product);
                productInDB.RowInsertTime = System.DateTime.Now;
                productInDB.RowUpdateTime = System.DateTime.Now;
                entites.Products.Add(productInDB);
                entites.SaveChanges();
                return _mapper.Map<ProductDTO>(productInDB);
            }
        }

        public List<ProductDTO> GetAllProductsByCategoryID(int categoryID)
        {
            using (var entities = new Product_companyEntities())
            {
                var productInDB = entities.Products.Where(x => x.CategoryID == categoryID && x.Discontinued == true).ToList();
                if (productInDB.Count == 0 || productInDB == null) return null;
                return _mapper.Map<List<ProductDTO>>(productInDB);
            }
        }

        public ProductDTO EditProductByID(ProductDTO product, int id)
        {
            using (var entites = new Product_companyEntities())
            {
                var productInDB = _mapper.Map<Product>(product);
                productInDB = entites.Products.SingleOrDefault(x => x.ProductID == id);
                if (productInDB != null)
                {
                    productInDB.RowUpdateTime = System.DateTime.Now;
                    productInDB.UnitPrice = product.UnitPrice;
                    entites.SaveChanges();
                }
                return _mapper.Map<ProductDTO>(productInDB);
            }
        }

        public ProductDTO DeleteProductByID(int id)
        {
            using (var entites = new Product_companyEntities())
            {
                var productsInDB = entites.Products.SingleOrDefault(x => x.ProductID == id);
                if (productsInDB != null)
                {
                    entites.Products.Remove(productsInDB);
                    entites.SaveChanges();
                }
                return _mapper.Map<ProductDTO>(productsInDB);
            }
        }

        public ProductDTO BlockProductByID(ProductDTO product, int id)
        {
            using (var entites = new Product_companyEntities())
            {
                var productInDB = _mapper.Map<Product>(product);
                productInDB = entites.Products.SingleOrDefault(x => x.ProductID == id);
                if (productInDB != null)
                {
                    productInDB.RowUpdateTime = System.DateTime.Now;
                    productInDB.Discontinued = product.Discontinued;
                    entites.SaveChanges();
                }
                return _mapper.Map<ProductDTO>(productInDB);
            }
        }
    }
}
