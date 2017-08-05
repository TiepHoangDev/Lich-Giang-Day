﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESS_LOGIC_LAYER.BCL;
using BUSINESS_OBJECT.Objects;
namespace QL_LICHGIANGDAY.UserControll
{
    public partial class UcPermisstion : UserControl
    {
        private PermissChange objPerChangeEntity = new PermissChange();
        private AccountObject objAccountEtity = new AccountObject();
        private PermisstionObject objPerEitity = new PermisstionObject();
        private PermisstionBCL objPerControll = new PermisstionBCL();
        public AccountObject AccLogin { get; set; }
        public UcPermisstion(AccountObject objPer)
        {
            AccLogin = objPer;
            InitializeComponent();
            trVEmployee.Nodes.Add("Danh sách các Username");
            trVEmployee.Nodes[0].Expand();
            trVEmployee.Nodes[0].Tag = "0";
            addPermisstion();
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
        public void addPermisstion()
        {
            var RoleOfUser = GetDegree(AccLogin.UserId);
            List<AccountObject> lisAccount = new AccountBCL().GetAll().Where(q => GetDegree(q.UserId) > RoleOfUser).ToList();
            int a = 0;
            foreach (var item in lisAccount)
            {
                trVEmployee.Nodes[0].Nodes.Add("" + item.UserId, item.FullName);
                trVEmployee.Nodes[0].Nodes[a].Tag = "1";
                objPerChangeEntity.nodeLeve = 0;
                a++;
            }
        }

        private void trVEmployee_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (("" + trVEmployee.SelectedNode.Tag).Equals("1"))
            {
                if (objPerChangeEntity.nodeLeve != 1)
                {
                    objPerChangeEntity.nodeLeve = 1;
                    objPerChangeEntity.Changed = false;
                }
                else
                {
                    if (objPerChangeEntity.Changed == true)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            SaveChane();
                        }
                        objPerChangeEntity.Changed = false;
                    }

                }
            }
            else//node duoc chon la lvl 0
            {
                objPerChangeEntity.nodeLeve = 0;
                objPerChangeEntity.Changed = false;
                lblUser.Text = "<chọn một user>";
                lblRole.Text = "<chọn một user>";
            }

            TreeNode tree = trVEmployee.SelectedNode;
            string UserID = trVEmployee.SelectedNode.Name;
            grCUserID.DataSource = new PermisstionBCL().GetAll().Where(q => q.UserId.ToString() == UserID).ToList();

            LoadComboboxPermission();
            lblUser.Text = new AccountBCL().GetByUserId(Guid.Parse(UserID)).First().FullName;
            lblRole.Text = GetDegree(Guid.Parse(UserID)).ToString();
        }

        private void SaveChane()
        {
            List<PermisstionObject> list = new List<PermisstionObject>();
            for (int i = 0; i < grDUserID.RowCount; i++)
            {
                PermisstionObject objPerEntity = (PermisstionObject)grDUserID.GetRow(i);
                list.Add(objPerEntity);
            }
            foreach (PermisstionObject ob in list)
            {
                objPerControll.Update(ob);
            }
        }

        void LoadComboboxPermission()
        {
            Guid User_ID = Guid.Parse(trVEmployee.SelectedNode.Name);
            var lstFeaOfUser = new PermisstionBCL().GetAll().Where(q => q.UserId == User_ID).ToList();
            var lstFea = new FeaIdBCL().GetAll().Where(q => !lstFeaOfUser.Any(x => x.FeaId.Trim().ToLower() == q.FeaId.Trim().ToLower())).ToList();
            uluPQ.Properties.DataSource = lstFea;
            uluPQ.Properties.NullText = "----------------  CHỨC NĂNG NGHIỆP VỤ ----------------";
            uluPQ.Update();
        }

        private void grDUserID_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (objPerChangeEntity.Changed == false)
            {
                objPerChangeEntity.Changed = true;
            }
        }

        private void grCUserID_Load(object sender, EventArgs e)
        {
            //Load_grcPermission();
        }

        private void uluPQ_Click(object sender, EventArgs e)
        {

        }

        private void uluPQ_EditValueChanged(object sender, EventArgs e)
        {
            if (objPerChangeEntity.Changed==true) SaveChane();
            List<PermisstionObject> list = new List<PermisstionObject>();
            for (int i = 0; i < grDUserID.RowCount; i++)
            {
                PermisstionObject objPerEntity = (PermisstionObject)grDUserID.GetRow(i);
                list.Add(objPerEntity);
            }
            foreach (PermisstionObject ob in list)
            {
                objPerControll.Update(ob);
            }
            if (MessageBox.Show("Bạn có muốn thêm quyền cho người dùng hay không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var x = uluPQ.EditValue;
                FeaIdObject obj = x as FeaIdObject;
                string FeiD = obj.FeaId;
                string UserID = trVEmployee.SelectedNode.Name;
                PermisstionObject objper = new PermisstionObject();
                objper.PerID = Guid.NewGuid();
                objper.F_ADD = false;
                objper.F_EDIT = false;
                objper.F_DELETE = false;
                objper.F_SEARCH = false;
                objper.FeaId = FeiD;
                objper.UserId = Guid.Parse(UserID);
                grCUserID.DataSource = new PermisstionBCL().Insert(objper);
                grCUserID.DataSource = new PermisstionBCL().GetAll().Where(q => q.UserId.ToString() == UserID).ToList();
            }
            LoadComboboxPermission();
        }


    }
}
