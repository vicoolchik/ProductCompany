using AutoMapper;
using ProductCompany.DAL.Interfaces;
using ProductСompany.DTO;
using System.Collections.Generic;
using System.Linq;

namespace ProductCompany.DAL.Concrete
{
    public class SupplierDal: ISupplierDal
    {
        private readonly IMapper _mapper;
        public SupplierDal(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<SupplierDTO> GetAllSuppliers()
        {
            using (var entities = new Product_companyEntities())
            {
                var suppliers = entities.Suppliers.ToList();
                return _mapper.Map<List<SupplierDTO>>(suppliers);
            }
        }
    }
}
