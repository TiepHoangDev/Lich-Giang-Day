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
    
    public partial class tbl_S07_Experts
    {
        public tbl_S07_Experts()
        {
            this.tbl_S07_ExpertsDetailt = new HashSet<tbl_S07_ExpertsDetailt>();
        }
    
        public System.Guid ExpertId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Specialize { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual ICollection<tbl_S07_ExpertsDetailt> tbl_S07_ExpertsDetailt { get; set; }
    }
}
