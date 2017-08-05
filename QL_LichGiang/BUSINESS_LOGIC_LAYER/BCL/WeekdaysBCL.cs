
using BUSINESS_OBJECT.Objects;
using DATA_ACCESS_LAYER.Dao;
using System;
using System.Collections.Generic;
namespace BUSINESS_LOGIC_LAYER.BCL
{
    public class WeekdaysBCL
    {

        public bool Insert(WeekdaysObjects ob)
        {
            return new WeekdaysDao().Insert(ob);
        }


        public bool Update(WeekdaysObjects ob)
        {
            return new WeekdaysDao().Update(ob);
        }


        public List<WeekdaysObjects> GetAll()
        {
            return new WeekdaysDao().GetAll();
        }


        public WeekdaysObjects GetByWeId(WeekdaysObjects ob)
        {
            return new WeekdaysDao().GetByWeId(ob);
        }


        public bool Delete(Guid ID)
        {
            return new WeekdaysDao().Delete(ID);
        }


    }
}
