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
    
    public partial class GET_ALL_OBJECT_Result
    {
        public System.Guid PerID { get; set; }
        public Nullable<bool> F_ADD { get; set; }
        public Nullable<bool> F_EDIT { get; set; }
        public Nullable<bool> F_DELETE { get; set; }
        public Nullable<bool> F_SEARCH { get; set; }
        public string FeaId { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
    }
}
