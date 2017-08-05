
using BUSINESS_OBJECT.Objects;
using System;
using System.Collections.Generic;
using DATA_ACCESS_LAYER.DataModels;
namespace DATA_ACCESS_LAYER.Dao
{
    public class FeaIdDao
    {

        public bool Insert(FeaIdObject ob)
        {
            var db = new eTrainingScheduleEntities();
            return db.sp_tbl_FeaId_INSERT(ob.FeaId, ob.FeaName, ob.Isdeleted) > 0;
        }


        public bool Update(FeaIdObject ob)
        {
            var db = new eTrainingScheduleEntities();
            return db.sp_tbl_FeaId_UPDATE(ob.FeaId, ob.FeaName, ob.Isdeleted) > 0;
        }


        public List<FeaIdObject> GetAll()
        {
            List<FeaIdObject> lst = new List<FeaIdObject>();
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_FeaId_GetAll();
            foreach (var item in list)
            {
                if (item.Isdeleted == true) 
                    continue;
                FeaIdObject ob = new FeaIdObject();
                ob.FeaId = item.FeaId; ob.FeaName = item.FeaName; ob.Isdeleted = item.Isdeleted;
                lst.Add(ob);
            }
            return lst;
        }


        public List<FeaIdObject> GetByFeaId(string ID)
        {
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_FeaId_GetByFeaId(ID);
            List<FeaIdObject> lst = new List<FeaIdObject>();
            foreach (var item in list)
            {
                FeaIdObject obj = new FeaIdObject();
                obj.FeaId = item.FeaId; obj.FeaName = item.FeaName; obj.Isdeleted = item.Isdeleted;
                lst.Add(obj);
            }
            return lst;
        }


        public bool Delete(string ID)
        {
            var db = new eTrainingScheduleEntities();
            var obj = GetByFeaId(ID);
            if (obj == null) return false;
            foreach (var item in obj)
            {
                item.Isdeleted = true;
                Update(item);
            }
            return true;
        }


    }
}
