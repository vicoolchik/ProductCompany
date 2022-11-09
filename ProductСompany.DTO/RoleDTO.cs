namespace ProductСompany.DTO
{
    public  class RoleDTO
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        public System.DateTime RowInsertTime { get; set; }
        public System.DateTime RowUpdateTime { get; set; }

        public override string ToString()
        {

            return $"|{RoleID,-5}|{Name,-15}|";
        }
    }
}
