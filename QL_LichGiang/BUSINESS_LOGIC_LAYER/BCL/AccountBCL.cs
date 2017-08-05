
using BUSINESS_OBJECT.Objects;
using DATA_ACCESS_LAYER.Dao;
using System;
using System.Collections.Generic;
namespace BUSINESS_LOGIC_LAYER.BCL
{
    public class AccountBCL
    {

        public bool Insert(AccountObject ob)
        {
            return new AccountDao().Insert(ob);
        }


        public bool Update(AccountObject ob)
        {
            return new AccountDao().Update(ob);
        }


        public List<AccountObject> GetAll()
        {
            return new AccountDao().GetAll();
        }


        public List<AccountObject> GetByUserId(Guid ID)
        {
            return new AccountDao().GetByUserId(ID);
        }


        public bool Delete(Guid ID)
        {
            return new AccountDao().Delete(ID);
        }

        public List<AccountObject> CheckLogin(AccountObject obj)
        {
            return new AccountDao().CheckLogin(obj);
        }
    }
}
