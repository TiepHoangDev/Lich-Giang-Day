
using BUSINESS_OBJECT.Objects;
using System;
using System.Collections.Generic;
using DATA_ACCESS_LAYER.DataModels;
namespace DATA_ACCESS_LAYER.Dao
{
    public class AccountDao
    {

        public bool Insert(AccountObject ob)
        {
            var db = new eTrainingScheduleEntities();
            return db.sp_tbl_Account_INSERT(ob.UserId, ob.FullName, ob.PassWord, ob.Username, ob.Email, ob.Phone, ob.Description, ob.Isdeleted, ob.RoleId) > 0;
        }


        public bool Update(AccountObject ob)
        {
            var db = new eTrainingScheduleEntities();
            return db.sp_tbl_Account_UPDATE(ob.UserId, ob.FullName, ob.PassWord, ob.Username, ob.Email, ob.Phone, ob.Description, ob.Isdeleted, ob.RoleId) > 0;
        }


        public List<AccountObject> GetAll()
        {
            List<AccountObject> lst = new List<AccountObject>();
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_Account_GetAll();
            foreach (var item in list)
            {
                if (item.Isdeleted == true) continue;
                AccountObject ob = new AccountObject();
                ob.UserId = item.UserId; ob.FullName = item.FullName; ob.PassWord = item.PassWord; ob.Username = item.Username; ob.Email = item.Email; ob.Phone = item.Phone; ob.Description = item.Description; ob.Isdeleted = item.Isdeleted; ob.RoleId = item.RoleId;
                ob.LoginSuccess = false;
                lst.Add(ob);
            }
            return lst;
        }


        public List<AccountObject> GetByUserId(Guid ID)
        {
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_Account_GetByUserId(ID);
            List<AccountObject> lst = new List<AccountObject>();
            foreach (var item in list)
            {
                AccountObject obj = new AccountObject();
                obj.UserId = item.UserId; obj.FullName = item.FullName; obj.PassWord = item.PassWord; obj.Username = item.Username; obj.Email = item.Email; obj.Phone = item.Phone; obj.Description = item.Description; obj.Isdeleted = item.Isdeleted; obj.RoleId = item.RoleId;
                lst.Add(obj);
            }
            return lst;
        }


        public bool Delete(Guid ID)
        {
            var db = new eTrainingScheduleEntities();
            var obj = GetByUserId(ID);
            if (obj == null || obj.Count <= 0) return false;
            foreach (var item in obj)
            {
                item.Isdeleted = true;
                Update(item);
            }
            return true;
        }

        public List<AccountObject> CheckLogin(AccountObject obj)
        {
            List<AccountObject> lst = new List<AccountObject>();
            var db = new eTrainingScheduleEntities();
            var list = db.sp_Account_CheckLogin(obj.Username, obj.PassWord);
            foreach (var item in list)
            {
                AccountObject ob = new AccountObject();
                ob.UserId = item.UserId; ob.FullName = item.FullName; ob.PassWord = item.PassWord; ob.Username = item.Username; ob.Email = item.Email; ob.Phone = item.Phone; ob.Description = item.Description; ob.Isdeleted = item.Isdeleted; ob.RoleId = item.RoleId;
                ob.LoginSuccess = true;
                lst.Add(ob);
            }
            return lst;
        }
    }
}
