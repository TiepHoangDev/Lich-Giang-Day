
using System;
namespace BUSINESS_OBJECT.Objects
{
    public class SchedulersObjects
    {
        public Guid ScId { get; set; }
        public Nullable<Guid> WeId { get; set; }
        public Nullable<Guid> ShiftId { get; set; }
        public Nullable<Guid> CoId { get; set; }
        public string Description { get; set; }

        public ShiftDayObjects ShiftDayJoin { get; set; }
        public WeekdaysObjects WeekdaysJoin { get; set; }
        public CoursesObjects CoursesJoin { get; set; }
    }
}
