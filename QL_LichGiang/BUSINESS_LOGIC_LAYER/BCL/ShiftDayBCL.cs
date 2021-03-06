using BUSINESS_OBJECT.Objects;
using DATA_ACCESS_LAYER.Dao;
using System;
using System.Collections.Generic;
namespace BUSINESS_LOGIC_LAYER.BCL
{
    public class ShiftDayBCL
    {

        public bool Insert(ShiftDayObjects ob)
        {
            return new ShiftDayDao().Insert(ob);
        }


        public bool Update(ShiftDayObjects ob)
        {
            return new ShiftDayDao().Update(ob);
        }


        public List<ShiftDayObjects> GetAll()
        {
            return new ShiftDayDao().GetAll();
        }


        public ShiftDayObjects GetByShiftId(Guid ID)
        {
            return new ShiftDayDao().GetByShiftId(ID);
        }


        public bool Delete(Guid ID)
        {
            return new ShiftDayDao().Delete(ID);
        }


    }
}
