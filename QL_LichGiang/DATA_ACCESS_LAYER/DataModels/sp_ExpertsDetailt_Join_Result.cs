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
    
    public partial class sp_ExpertsDetailt_Join_Result
    {
        public System.Guid ExId { get; set; }
        public Nullable<System.Guid> ExpertId { get; set; }
        public Nullable<System.Guid> CoId { get; set; }
        public string DescriptionExpertsDetailt { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Specialize { get; set; }
        public string DescriptionExperts { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public Nullable<byte> TotalNumber { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string DescriptionCourses { get; set; }
        public Nullable<System.DateTime> StartDateExperts { get; set; }
        public Nullable<bool> StatusExperts { get; set; }
        public Nullable<bool> DeletedExperts { get; set; }
        public Nullable<System.DateTime> StartDateCourses { get; set; }
        public Nullable<bool> StatusCourses { get; set; }
        public Nullable<bool> DeletedCourses { get; set; }
    }
}
