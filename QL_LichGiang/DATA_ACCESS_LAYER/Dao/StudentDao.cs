
using BUSINESS_OBJECT.Objects;
using System;
using System.Collections.Generic;
using DATA_ACCESS_LAYER.DataModels;
namespace DATA_ACCESS_LAYER.Dao
{
    public class StudentDao
    {

        public bool Insert(StudentObjects ob)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_Student_INSERT(ob.StudetId, ob.FullName, ob.Email, ob.Mobile, ob.Address, ob.Status, ob.Deleted);
            return true;
        }


        public bool Update(StudentObjects ob)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_Student_UPDATE(ob.StudetId, ob.FullName, ob.Email, ob.Mobile, ob.Address, ob.Status, ob.Deleted);
            return true;
        }


        public List<StudentObjects> GetAll()
        {
            List<StudentObjects> lst = new List<StudentObjects>();
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_S07_Student_GetAll();
            foreach (var item in list)
            {
                if (item.Deleted == true) continue;
                StudentObjects ob = new StudentObjects();
                ob.StudetId = item.StudetId; ob.FullName = item.FullName; ob.Email = item.Email; ob.Mobile = item.Mobile; ob.Address = item.Address; ob.Status = item.Status; ob.Deleted = item.Deleted;
                lst.Add(ob);
            }
            return lst;
        }


        public StudentObjects GetByStudetId(Guid ID)
        {
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_S07_Student_GetByStudetId(ID);
            StudentObjects obj = new StudentObjects();
            foreach (var item in list)
            {
                obj.StudetId = item.StudetId; obj.FullName = item.FullName; obj.Email = item.Email; obj.Mobile = item.Mobile; obj.Address = item.Address; obj.Status = item.Status; obj.Deleted = item.Deleted;
            }
            return obj;
        }


        public bool Delete(Guid ID)
        {
            var db = new eTrainingScheduleEntities();
            var ob = GetByStudetId(ID);
            if (ob == null) return false;
            ob.Deleted = true;
            Update(ob);
            return true;
        }
    }
}
