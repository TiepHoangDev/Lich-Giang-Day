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
    
    public partial class sp_tbl_S07_Schedulers_GetByScId_Result
    {
        public System.Guid ScId { get; set; }
        public Nullable<System.Guid> WeId { get; set; }
        public Nullable<System.Guid> ShiftId { get; set; }
        public Nullable<System.Guid> CoId { get; set; }
        public string Description { get; set; }
    }
}
