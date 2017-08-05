using BUSINESS_OBJECT.Objects;
using DATA_ACCESS_LAYER.Dao;
using System;
using System.Collections.Generic;
namespace BUSINESS_LOGIC_LAYER.BCL
{
    public class CoursesJournalBCL
    {

        public bool Insert(CoursesJournalObjects ob)
        {
            return new CoursesJournalDao().Insert(ob);
        }


        public bool Update(CoursesJournalObjects ob)
        {
            return new CoursesJournalDao().Update(ob);
        }


        public List<SP_GetAll_CoursesJournalObject> GetAll()
        {
            return new CoursesJournalDao().GetAll();
        }


        public CoursesJournalObjects GetByCJId(CoursesJournalObjects ob)
        {
            return new CoursesJournalDao().GetByCJId(ob);
        }


        public bool Delete(Guid ID)
        {
            return new CoursesJournalDao().Delete(ID);
        }

        public List<CoursesJournalObjects> GetJoin()
        {
            return new CoursesJournalDao().GetJoin();
        }
    }
}
