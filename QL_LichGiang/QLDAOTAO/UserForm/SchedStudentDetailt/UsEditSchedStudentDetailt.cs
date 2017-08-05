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
using BUSINESS_LOGIC_LAYER.BCL;
using BUSINESS_OBJECT.Objects;

namespace QL_LICHGIANGDAY.UserForm.SchedStudentDetailt
{
    public partial class UsEditSchedStudentDetailt : DevExpress.XtraEditors.XtraForm
    {
        private SchedStudentDetailtObjects objSSDetailt;
        public UsEditSchedStudentDetailt(Guid ID_SSDetail)
        {
            InitializeComponent();
            objSSDetailt = new SchedStudentDetailtBCL().GetByScsId(ID_SSDetail);
        }
        private void LoadData()
        {
            this.Cursor = Cursors.WaitCursor;
            lookUpEditStudentID.Properties.DataSource = new StudentBCL().GetAll();
            lookUpEditStudentID.EditValue = objSSDetailt.StudetId;
            rtbDescription.Text = objSSDetailt.Description;
            this.Cursor = Cursors.Default;
        }

        private void LoadLookup(LookUpEdit lookupedit, object source, string displayMember, string valueMember)
        {
            lookupedit.Properties.DataSource = source;
            lookupedit.Properties.DisplayMember = displayMember;
            lookupedit.Properties.ValueMember = valueMember;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void UsEditSchedStudentDetailt_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lookUpEditStudentID.EditValue == null) MessageBox.Show("Chọn một Học viên.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn có chắc chắn sửa?.", "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                objSSDetailt.StudetId = (Guid)lookUpEditStudentID.EditValue;
                objSSDetailt.Description = rtbDescription.Text;
                var result = new SchedStudentDetailtBCL().Update(objSSDetailt);
                var student = new StudentBCL().GetByStudetId((Guid)lookUpEditStudentID.EditValue);
                if (result == true)
                {
                    MessageBox.Show(string.Format("Sửa học viên {0} thành công", student.FullName), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(string.Format("Sửa học viên {0} thất bại", student.FullName), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LoadData();
            }
        }
    }
}