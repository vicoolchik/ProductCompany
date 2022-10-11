using System;

namespace ProductСompany.DTO
{
    public class CategoryDTO
    {
        public string CategoryName { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }

        public override string ToString()
        {

            return $"|{CategoryID,-3}|{CategoryName,-10}|";
        }
    }
}
