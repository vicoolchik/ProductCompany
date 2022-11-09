using System;

namespace ProductСompany.DTO
{
    public  class UserRoleDTO
    {
        public Nullable<int> UserID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public System.DateTime RowInsertTime { get; set; }
        public System.DateTime RowUpdateTime { get; set; }
        public int UserRolesID { get; set; }

        public virtual RoleDTO Role { get; set; }
        public virtual UserDTO User { get; set; }

        public override string ToString()
        {
            return $"|{UserRolesID,-3}|{User.Login,-30}|{Role.Name,-20}|";
        }
    }
}
