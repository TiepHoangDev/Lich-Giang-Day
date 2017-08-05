using BUSINESS_OBJECT.Objects;
using DATA_ACCESS_LAYER.Dao;
using System;
using System.Collections.Generic;
using DATA_ACCESS_LAYER.DataModels;
namespace BUSINESS_LOGIC_LAYER.BCL
{
    public class ExpertsBCL
    {

        public bool Insert(ExpertsObjects ob)
        {
            return new ExpertsDao().Insert(ob);
        }


        public bool Update(ExpertsObjects ob)
        {
            return new ExpertsDao().Update(ob);
        }


        public List<ExpertsObjects> GetAll()
        {
            return new ExpertsDao().GetAll();
        }


        public ExpertsObjects GetByExpertId(Guid ID)
        {
            return new ExpertsDao().GetByExpertId(ID);
        }


        public bool Delete(Guid ID)
        {
            return new ExpertsDao().Delete(ID);
        }


    }
}
