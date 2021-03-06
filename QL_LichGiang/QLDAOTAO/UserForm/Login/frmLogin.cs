﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESS_LOGIC_LAYER.BCL;
using BUSINESS_OBJECT.Objects;
using IMIC.CONTROLLERS.Ultils;

namespace QL_LICHGIANGDAY.UserForm.Login
{
    public partial class frmLogin : Form
    {
        private AccountObject m_AccountObject;
        private List<PermisstionObject> m_lisPer;
        public frmLogin(AccountObject objUserID, List<PermisstionObject> lisPer)
        {
            InitializeComponent();
            m_AccountObject = objUserID;
            m_lisPer = lisPer;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginExecute();
        }
        private void LoginExecute()
        {
            dxErrorProvider1.ClearErrors();
            if (!Validations.IsFilled(txtUsername.Text))
            {
                dxErrorProvider1.SetError(txtUsername, "Bạn cần nhập tài khoản đăng nhập");
                txtUsername.Focus();
            }
            if (!Validations.IsFilled(txtPassword.Text))
            {
                dxErrorProvider1.SetError(txtPassword, "Bạn cần nhập mật khẩu đăng nhập");
                txtPassword.Focus();
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                AccountObject objU = new AccountObject();
                objU.Username = txtUsername.Text.Trim();
                objU.PassWord = txtPassword.Text;

                AccountBCL objController = new AccountBCL();
                List<AccountObject> lisEmp = objController.CheckLogin(objU);

                if (lisEmp.Count > 0)
                {
                    AccountObject objE = lisEmp.ElementAt(0);
                    if (objE.LoginSuccess)
                    {
                        //Lấy các thuộc tính của Employee
                        m_AccountObject.UserId = objE.UserId;
                        m_AccountObject.FullName = objE.FullName;
                        m_AccountObject.Username = objE.Username;
                        m_AccountObject.Email = objE.Email;
                        m_AccountObject.LoginSuccess = true;
                        m_AccountObject.RoleId = objE.RoleId;
                        m_AccountObject.Roldeobj = new RoleBCL().GetByRoleId((Guid)m_AccountObject.RoleId);

                        //Lấy một lis các permission của employee
                        List<PermisstionObject> lisTemp = new PermisstionBCL().GetAll().Where(q => q.UserId == objE.UserId).ToList();
                        foreach (PermisstionObject item in lisTemp)
                        {
                            m_lisPer.Add(item);
                        }

                        //m_lisPer = new PermissionController().ExecOf_GetElementByEmpId(m_AccountObject.EmpId);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản không đúng. Vui lòng nhập lại", "Thông báo");
                    dxErrorProvider1.SetError(txtUsername, "Thông tin tài khoản không đúng. Vui lòng nhập lại");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            m_AccountObject.LoginSuccess = false;
            this.Close();
        }
    }
}
