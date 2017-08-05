
using System;
namespace BUSINESS_OBJECT.Objects
{
    public class  SchedStudentDetailtObjects
    {
         public Guid ScsId { get; set; }  
        public Nullable<Guid> StudetId { get; set; }  
        public Nullable<Guid> ScId { get; set; }  
        public string Description { get; set; }

        public StudentObjects StudentJoin { get; set; }
        public SchedulersObjects SchedulersJoin { get; set; }
    }
}
