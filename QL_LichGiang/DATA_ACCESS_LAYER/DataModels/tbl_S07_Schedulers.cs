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
    
    public partial class tbl_S07_Schedulers
    {
        public tbl_S07_Schedulers()
        {
            this.tbl_S07_SchedStudentDetailt = new HashSet<tbl_S07_SchedStudentDetailt>();
        }
    
        public System.Guid ScId { get; set; }
        public Nullable<System.Guid> WeId { get; set; }
        public Nullable<System.Guid> ShiftId { get; set; }
        public Nullable<System.Guid> CoId { get; set; }
        public string Description { get; set; }
    
        public virtual tbl_S07_Courses tbl_S07_Courses { get; set; }
        public virtual ICollection<tbl_S07_SchedStudentDetailt> tbl_S07_SchedStudentDetailt { get; set; }
        public virtual tbl_S07_Weekdays tbl_S07_Weekdays { get; set; }
        public virtual tbl_S07_ShiftDay tbl_S07_ShiftDay { get; set; }
    }
}