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
                entites.Products.Add(productInDB);
                entites.SaveChanges();
                return _mapper.Map<ProductDTO>(productInDB);
            }
        }

        public List<ProductDTO> GetAllProducts()
        {
            using (var entities = new Product_companyEntities())
            {
                var products = entities.Products.ToList();
                return _mapper.Map<List<ProductDTO>>(products);
            }
        }
    }
}
