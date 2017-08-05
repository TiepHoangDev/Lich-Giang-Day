using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUSINESS_LOGIC_LAYER.BCL;
using BUSINESS_OBJECT.Objects;

namespace QL_LICHGIANGDAY.UserControll
{
    public partial class UcAccount : DevExpress.XtraEditors.XtraUserControl
    {
        AccountObject AccLogin;
        public UcAccount(AccountObject AccLogin)
        {
            InitializeComponent();
            ucBaseControl1.onThemThongTin += new EventHandler(ucBaseControl1_onThemThongTin);
            ucBaseControl1.onSuaThongTin += new EventHandler(ucBaseControl1_onSuaThongTin);
            ucBaseControl1.onXoaThongTin += new EventHandler(ucBaseControl1_onXoaThongTin);
            this.AccLogin = AccLogin;
        }
        void ucBaseControl1_onXoaThongTin(object sender, EventArgs e)
        {
            var ID = Guid.Parse("" + gridView1.GetFocusedRowCellValue("UserId"));
            DialogResult obj = MessageBox.Show("Bạn muốn xóa không?",
                "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (obj == DialogResult.Yes)
            {
                var x = new AccountBCL().Delete(ID);
                Load_DataCourses();
                MessageBox.Show(string.Format("Bạn đã xóa {0}", x ? "thành công" : "thất bại"));
            }
        }

        void ucBaseControl1_onSuaThongTin(object sender, EventArgs e)
        {
            AccountObject objCoursesEntity = (AccountObject)gridView1.GetFocusedRow();
            UserForm.Account.UsEditAccount frm = new UserForm.Account.UsEditAccount(objCoursesEntity.UserId);
            frm.ShowDialog();
            Load_DataCourses();
        }

        void ucBaseControl1_onThemThongTin(object sender, EventArgs e)
        {
            UserForm.Account.UsAddAccount frm = new UserForm.Account.UsAddAccount(AccLogin);
            frm.ShowDialog();
            Load_DataCourses();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            Load_DataCourses();
        }
        //Degree == Cấp bậc
        public enum eDegree
        {
            SuperAdmin = 0,
            Admin = 1,
            User = 2,
            Guest = 3
        }

        /// <summary>
        /// Get cấp bậc của một tài khoản
        /// </summary>
        /// <param name="ID_Account"></param>
        /// <returns></returns>
        eDegree GetDegree(Guid ID_Account)
        {
            AccountObject acc = new AccountBCL().GetByUserId(ID_Account).First();
            var role = new RoleBCL().GetByRoleId((Guid)acc.RoleId);
            switch (role.RName)
            {
                case "SuperAdmin":
                    return eDegree.SuperAdmin;
                case "Admin":
                    return eDegree.Admin;
                case "User":
                    return eDegree.User;
                default:
                    return eDegree.Guest;
            }
        }
        void Load_DataCourses()
        {
            var RoleOfUser = GetDegree(AccLogin.UserId);
            List<AccountObject> lisAccount = new AccountBCL().GetAll().Where(q => GetDegree(q.UserId) > RoleOfUser).ToList();
            gridControl1.DataSource = lisAccount;
            uluCV.DataSource = new RoleBCL().GetAll();
        }

    }
}
