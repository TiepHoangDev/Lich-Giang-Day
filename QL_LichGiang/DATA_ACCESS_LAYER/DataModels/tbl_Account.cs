//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA_ACCESS_LAYER.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Account
    {
        public tbl_Account()
        {
            this.tbl_Permisstion = new HashSet<tbl_Permisstion>();
        }
    
        public System.Guid UserId { get; set; }
        public string FullName { get; set; }
        public string PassWord { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Isdeleted { get; set; }
        public Nullable<System.Guid> RoleId { get; set; }
    
        public virtual tbl_Role tbl_Role { get; set; }
        public virtual ICollection<tbl_Permisstion> tbl_Permisstion { get; set; }
    }
}
