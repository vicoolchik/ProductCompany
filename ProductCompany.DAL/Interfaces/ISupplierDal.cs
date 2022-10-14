using ProductСompany.DTO;
using System.Collections.Generic;

namespace ProductCompany.DAL.Interfaces
{
    public interface ISupplierDal
    {
        List<SupplierDTO> GetAllSuppliers();
    }
}
