
using BUSINESS_OBJECT.Objects;
using DATA_ACCESS_LAYER.Dao;
using System;
using System.Collections.Generic;
namespace BUSINESS_LOGIC_LAYER.BCL
{
    public class FeaIdBCL
    {

        public bool Insert(FeaIdObject ob)
        {
            return new FeaIdDao().Insert(ob);
        }


        public bool Update(FeaIdObject ob)
        {
            return new FeaIdDao().Update(ob);
        }


        public List<FeaIdObject> GetAll()
        {
            return new FeaIdDao().GetAll();
        }


        public List<FeaIdObject> GetByFeaId(string ID)
        {
            return new FeaIdDao().GetByFeaId(ID);
        }


        public bool Delete(string ID)
        {
            return new FeaIdDao().Delete(ID);
        }


    }
}
