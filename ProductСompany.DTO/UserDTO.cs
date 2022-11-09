using System.Collections.Generic;

namespace ProductСompany.DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string EMail { get; set; }
        public byte[] Password { get; set; }
        public System.Guid Salt { get; set; }
        public System.DateTime RowInsertTime { get; set; }
        public System.DateTime RowUpdateTime { get; set; }
        public List<RoleDTO> Roles { get; set; }

        public override string ToString()
        {

            return $"|{UserID,-5}|{Login,-15}|{EMail,-20}|";
        }
    }
}
