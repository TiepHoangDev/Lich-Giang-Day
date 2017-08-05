using BUSINESS_OBJECT.Objects;
using DATA_ACCESS_LAYER.Dao;
using System;
using System.Collections.Generic;
namespace BUSINESS_LOGIC_LAYER.BCL
{
    public class SchedulersBCL
    {

        public bool Insert(SchedulersObjects ob)
        {
            return new SchedulersDao().Insert(ob);
        }


        public bool Update(SchedulersObjects ob)
        {
            return new SchedulersDao().Update(ob);
        }


        public List<SchedulersObjects> GetAll()
        {
            return new SchedulersDao().GetAll();
        }

        public List<SchedulersObjects> GetJoin()
        {
            return new SchedulersDao().GetJoin();
        }

        public SchedulersObjects GetByScId(Guid ID)
        {
            return new SchedulersDao().GetByScId(ID);
        }


        public bool Delete(Guid ID)
        {
            return new SchedulersDao().Delete(ID);
        }


    }
}
