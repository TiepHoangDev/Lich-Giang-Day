
using BUSINESS_OBJECT.Objects;
using System;
using System.Collections.Generic;
using DATA_ACCESS_LAYER.DataModels;
namespace DATA_ACCESS_LAYER.Dao
{
    public class SchedStudentDetailtDao
    {

        public bool Insert(SchedStudentDetailtObjects ob)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_SchedStudentDetailt_INSERT(ob.ScsId, ob.StudetId, ob.ScId, ob.Description);
            return true;
        }


        public bool Update(SchedStudentDetailtObjects ob)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_SchedStudentDetailt_UPDATE(ob.ScsId, ob.StudetId, ob.ScId, ob.Description);
            return true;
        }


        public List<SchedStudentDetailtObjects> GetAll()
        {
            List<SchedStudentDetailtObjects> lst = new List<SchedStudentDetailtObjects>();
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_S07_SchedStudentDetailt_GetAll();
            foreach (var item in list)
            {
                SchedStudentDetailtObjects ob = new SchedStudentDetailtObjects();
                ob.ScsId = item.ScsId;
                ob.Description = item.Description;
                ob.ScId = item.ScId;
                ob.StudetId = item.StudetId;
                lst.Add(ob);
            }
            return lst;
        }

        public List<SchedStudentDetailtObjects> GetJoin()
        {
            List<SchedStudentDetailtObjects> lst = new List<SchedStudentDetailtObjects>();
            var db = new eTrainingScheduleEntities();
            var list = db.sp_SchedStudentDetailt_Join();
            foreach (var item in list)
            {
                SchedStudentDetailtObjects ob = new SchedStudentDetailtObjects();
                ob.ScsId = item.ScsId; ob.StudetId = item.StudetId; ob.ScId = item.ScId; ob.Description = item.DescriptionSchedStudentDetailt;
                ob.SchedulersJoin = new SchedulersObjects()
                {
                    CoId = item.CoId,
                    Description = item.DescriptionSchedulers,
                    ScId = (Guid)item.ScId,
                    ShiftId = item.ShiftId,
                    WeId = item.WeId
                };
                ob.StudentJoin = new StudentObjects()
                {
                    Address = item.Address,
                    Deleted = item.Deleted,
                    Email = item.Email,
                    FullName = item.FullName,
                    Mobile = item.Mobile,
                    Status = item.Status,
                    StudetId = (Guid)item.StudetId
                };
                lst.Add(ob);
            }
            return lst;
        }

        public SchedStudentDetailtObjects GetByScsId(Guid ID)
        {
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_S07_SchedStudentDetailt_GetByScsId(ID);
            SchedStudentDetailtObjects obj = new SchedStudentDetailtObjects();
            foreach (var item in list)
            {
                obj.ScsId = item.ScsId; obj.StudetId = item.StudetId; obj.ScId = item.ScId; obj.Description = item.Description;
            }
            return obj;
        }

        public bool Delete(Guid id)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_SchedStudentDetailt_DELETE(id);
            return true;

        }
    }
}
