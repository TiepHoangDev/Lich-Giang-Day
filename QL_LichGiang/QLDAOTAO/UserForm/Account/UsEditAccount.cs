﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUSINESS_OBJECT.Objects;
using BUSINESS_LOGIC_LAYER.BCL;

namespace QL_LICHGIANGDAY.UserForm.Account
{
    public partial class UsEditAccount : DevExpress.XtraEditors.XtraForm
    {
        private AccountObject objAccount;

        public UsEditAccount()
        {
            InitializeComponent();
        }
        public UsEditAccount(Guid ID_Account)
        {
            InitializeComponent();
            try
            {
                objAccount = new AccountBCL().GetByUserId(ID_Account)[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi: Người dùng không tồn tại");
                this.DialogResult = System.Windows.Forms.DialogResult.No;
                this.Close();
            }
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            objAccount.Email = txtEmail.Text;
            objAccount.FullName = txtFullName.Text;
            objAccount.Phone = txtPhone.Text;
            objAccount.Description = rtbDescription.Text;
            objAccount.Username = txtUsername.Text;
            var RoleOfUser = GetDegree(objAccount.UserId);
           lookUpEdit_RoleID.Properties.DataSource= new RoleBCL().GetAll().Where(q => GetDegreetRold(q.RoleId) > RoleOfUser).ToList();
            objAccount.RoleId = (Guid)lookUpEdit_RoleID.EditValue;
            var data = new AccountBCL().Update(objAccount);
            MessageBox.Show(string.Format("Sửa {0} người dùng {1} !", data ? "Thành công" : "Thất bại", objAccount.FullName), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (data)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void UsEditAccount_Load(object sender, EventArgs e)
        {
            var RoleOfUser = GetDegree(objAccount.UserId);
            lookUpEdit_RoleID.Properties.DataSource = new RoleBCL().GetAll().Where(q => GetDegreetRold(q.RoleId) > RoleOfUser).ToList();
            lookUpEdit_RoleID.Properties.DisplayMember = "RName";
            lookUpEdit_RoleID.Properties.ValueMember = "RoleId";
            lookUpEdit_RoleID.EditValue = objAccount.RoleId;

            txtEmail.Text = objAccount.Email;
            txtFullName.Text = objAccount.FullName;
            txtPhone.Text = objAccount.Phone;
            rtbDescription.Text = objAccount.Description;
            txtUsername.Text = objAccount.Username;
        }
    }
}