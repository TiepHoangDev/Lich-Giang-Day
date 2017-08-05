
using BUSINESS_OBJECT.Objects;
using System;
using System.Collections.Generic;
using DATA_ACCESS_LAYER.DataModels;
namespace DATA_ACCESS_LAYER.Dao
{
    public class CoursesJournalDao
    {

        public bool Insert(CoursesJournalObjects ob)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_CoursesJournal_INSERT(ob.CJId, ob.CoId, ob.DayOf, ob.Contents, ob.Description);
            return true;
        }


        public bool Update(CoursesJournalObjects ob)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_CoursesJournal_UPDATE(ob.CJId, ob.CoId, ob.DayOf, ob.Contents, ob.Description);
            return true;
        }


        public List<SP_GetAll_CoursesJournalObject> GetAll()
        {
            List<SP_GetAll_CoursesJournalObject> lst = new List<SP_GetAll_CoursesJournalObject>();
            var db = new eTrainingScheduleEntities().SP_GetAll_CoursesJournal();

            foreach (var item in db)
            {
                SP_GetAll_CoursesJournalObject ob = new SP_GetAll_CoursesJournalObject();
                ob.CJId = item.CJId;
                ob.Contents = item.Contents;
                ob.DayOf = item.DayOf;
                ob.CourseName = item.CourseName;
                ob.Description = item.Description;
                lst.Add(ob);
            }
            return lst;
        }

        public CoursesJournalObjects GetByCJId(CoursesJournalObjects ob)
        {
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_S07_CoursesJournal_GetByCJId(ob.CJId);
            CoursesJournalObjects obj = new CoursesJournalObjects();
            foreach (var item in list)
            {
                obj.CJId = item.CJId; obj.CoId = item.CoId; obj.DayOf = item.DayOf; obj.Contents = item.Contents; obj.Description = item.Description;
            }
            return obj;
        }


        public bool Delete(Guid ID)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_CoursesJournal_DELETE(ID);
            return true;
        }

        public List<CoursesJournalObjects> GetJoin()
        {
            List<CoursesJournalObjects> lst = new List<CoursesJournalObjects>();
            var db = new eTrainingScheduleEntities();
            var list = db.sp_CoursesJournal_Join();
            foreach (var item in list)
            {
                CoursesJournalObjects ob = new CoursesJournalObjects();
                ob.CJId = item.CJId; ob.CoId = item.CoId; ob.DayOf = item.DayOf; ob.Contents = item.Contents; ob.Description = item.DescriptionCoursesJournal;
                ob.CoursesJoin = new CoursesObjects()
                {
                    CoId = (Guid)item.CoId,
                    CourseId = item.CourseId,
                    CourseName = item.CourseName,
                    Deleted = item.Deleted,
                    Description = item.DescriptionCourses,
                    EndDate = item.EndDate,
                    StartDate = item.StartDate,
                    Status = item.Status,
                    TotalNumber = item.TotalNumber
                };
                lst.Add(ob);
            }
            return lst;
        }

    }
}
