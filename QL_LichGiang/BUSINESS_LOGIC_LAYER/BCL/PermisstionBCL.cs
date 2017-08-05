
using BUSINESS_OBJECT.Objects;
using DATA_ACCESS_LAYER.Dao;
using System;
using System.Collections.Generic;
namespace BUSINESS_LOGIC_LAYER.BCL
{
    public class PermisstionBCL
    {

        public bool Insert(PermisstionObject ob)
        {
            return new PermisstionDao().Insert(ob);
        }


        public bool Update(PermisstionObject ob)
        {
            return new PermisstionDao().Update(ob);
        }


        public List<PermisstionObject> GetAll()
        {
            return new PermisstionDao().GetAll();
        }
        public PermisstionObject GetAll_object(string FeaId, Guid UserId)
        {
            return new PermisstionDao().GetAll_object(FeaId, UserId);
        }
        public List<PermisstionObject> GetByPerID(Guid ID)
        {
            return new PermisstionDao().GetByPerID(ID);
        }


        public bool Delete(Guid ID)
        {
            return new PermisstionDao().Delete(ID);
        }


    }
}