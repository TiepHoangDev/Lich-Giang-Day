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

namespace QL_LICHGIANGDAY.UserForm.Schedulers
{
    public partial class UsEditSchedulers : DevExpress.XtraEditors.XtraForm
    {
        private SchedulersObjects objScheduler;
        public UsEditSchedulers(Guid ID_Scheduler)
        {
            InitializeComponent();
            objScheduler = new SchedulersBCL().GetByScId(ID_Scheduler);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lookUpEditCourseID.EditValue == null) MessageBox.Show("Chọn một Khóa học.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (lookUpEditShiftID.EditValue == null) MessageBox.Show("Chọn một Ca học.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (lookUpEditWeekDayID.EditValue == null) MessageBox.Show("Chọn một Thời gian học.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                objScheduler.CoId = (Guid)lookUpEditCourseID.EditValue;
                objScheduler.ShiftId = (Guid)lookUpEditShiftID.EditValue;
                objScheduler.WeId = (Guid)lookUpEditWeekDayID.EditValue;
                objScheduler.Description = rtbDescription.Text;
                var result = new SchedulersBCL().Update(objScheduler);
                if (result == true)
                {
                    MessageBox.Show(string.Format("Sửa lịch học thành công"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(string.Format("Sửa lịch học thất bại"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UsEditSchedulers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.Cursor = Cursors.WaitCursor;
            lookUpEditCourseID.Properties.DataSource = new CoursesBCL().GetAll();
            lookUpEditShiftID.Properties.DataSource = new ShiftDayBCL().GetAll();
            lookUpEditWeekDayID.Properties.DataSource = new WeekdaysBCL().GetAll();

            lookUpEditCourseID.EditValue = objScheduler.CoId;
            lookUpEditShiftID.EditValue = objScheduler.ShiftId;
            lookUpEditWeekDayID.EditValue = objScheduler.WeId;
            this.Cursor = Cursors.Default;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }
    }
}