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
    
    public partial class sp_CoursesJournal_Join_Result
    {
        public System.Guid CJId { get; set; }
        public Nullable<System.Guid> CoId { get; set; }
        public Nullable<System.DateTime> DayOf { get; set; }
        public string Contents { get; set; }
        public string DescriptionCoursesJournal { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public Nullable<byte> TotalNumber { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public string DescriptionCourses { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}