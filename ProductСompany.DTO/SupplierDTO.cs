using System;

namespace ProductСompany.DTO
{
    public class SupplierDTO
    {
        public string CompanyName { get; set; }
        public int SupplierID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }
    }
}
