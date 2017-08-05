using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUSINESS_LOGIC_LAYER.BCL;
using BUSINESS_OBJECT.Objects;

namespace QL_LICHGIANGDAY.UserForm.Account
{
    public partial class UsAddAccount : DevExpress.XtraEditors.XtraForm
    {
        AccountObject AccLogin=new AccountObject();
        public UsAddAccount(AccountObject AccLogin)
        {
            InitializeComponent();
            this.AccLogin = AccLogin;
        }
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
        eDegree GetDegreetRold(Guid ID_RoleId)
        {
            var role = new RoleBCL().GetByRoleId(ID_RoleId);
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
        //public void addPermisstion()
        //{
        //    var RoleOfUser = GetDegree(AccLogin.UserId);
        //    List<AccountObject> lisAccount = new AccountBCL().GetAll().Where(q => GetDegree(q.UserId) > RoleOfUser).ToList();
        //}
        private void UsAddAccount_Load(object sender, EventArgs e)
        {
            var RoleOfUser = GetDegree(AccLogin.UserId);
            lookUpEdit_RoleID.Properties.DataSource = new RoleBCL().GetAll().Where(q=>GetDegreetRold(q.RoleId) > RoleOfUser).ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) MessageBox.Show("Không để rỗng Email.", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtFullName.Text)) MessageBox.Show("Không để rỗng Họ tên ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtPhone.Text)) MessageBox.Show("Không để rỗng Số điện thoại ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtPassword.Text)) MessageBox.Show("Không để rỗng Mật khẩu ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (lookUpEdit_RoleID.EditValue == null) MessageBox.Show("Không để rỗng Chức vụ ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtUsername.Text)) MessageBox.Show("Không để rỗng Tên đăng nhập", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                var data = new AccountBCL().Insert(new AccountObject()
                {
                    Description = rtbDescription.Text,
                    Email = txtEmail.Text,
                    FullName = txtFullName.Text,
                    Isdeleted = false,
                    PassWord = txtPassword.Text,
                    Phone = txtPhone.Text,
                    RoleId = (Guid)lookUpEdit_RoleID.EditValue,
                    UserId = Guid.NewGuid(),
                    Username = txtUsername.Text
                });
                if (data == true)
                {
                    MessageBox.Show("Thêm Tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm Tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }
    }
}