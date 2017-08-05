using BUSINESS_OBJECT.Objects;
using DATA_ACCESS_LAYER.Dao;
using System;
using System.Collections.Generic;
namespace BUSINESS_LOGIC_LAYER.BCL
{
    public class SchedStudentDetailtBCL
    {

        public bool Insert(SchedStudentDetailtObjects ob)
        {
            return new SchedStudentDetailtDao().Insert(ob);
        }


        public bool Update(SchedStudentDetailtObjects ob)
        {
            return new SchedStudentDetailtDao().Update(ob);
        }


        public List<SchedStudentDetailtObjects> GetAll()
        {
            return new SchedStudentDetailtDao().GetAll();
        }


        public SchedStudentDetailtObjects GetByScsId(Guid ID)
        {
            return new SchedStudentDetailtDao().GetByScsId(ID);
        }


        public bool Delete(Guid ID)
        {
            return new SchedStudentDetailtDao().Delete(ID);
        }

        public List<SchedStudentDetailtObjects> GetJoin()
        {
            return new SchedStudentDetailtDao().GetJoin();
        }
    }
}