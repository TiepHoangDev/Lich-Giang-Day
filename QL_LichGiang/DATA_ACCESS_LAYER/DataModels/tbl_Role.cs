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
    
    public partial class tbl_Role
    {
        public tbl_Role()
        {
            this.tbl_Account = new HashSet<tbl_Account>();
        }
    
        public System.Guid RoleId { get; set; }
        public string RName { get; set; }
        public Nullable<bool> Isdeleted { get; set; }
    
        public virtual ICollection<tbl_Account> tbl_Account { get; set; }
    }
}
