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

namespace QL_LICHGIANGDAY.UserForm.UsCoursesJourna
{
    public partial class UsUpdateCousesJourna : DevExpress.XtraEditors.XtraForm
    {
        private CoursesJournalBCL objBclCouresesJour = new CoursesJournalBCL();
        private CoursesJournalObjects objCoursesJournalEntity = new CoursesJournalObjects();
        private CoursesBCL objCoursesBCL = new CoursesBCL();
        public UsUpdateCousesJourna(CoursesJournalObjects obj)
        {
            InitializeComponent();            
            if (obj != null)
            {
                bindding(obj);                
            }
        }
        void bindding(CoursesJournalObjects obj)
        {
            uluMKH.Properties.DataSource = objCoursesBCL.GetAll();
            uluMKH.EditValue = obj.CoId;          
            rEContent.Text = obj.Contents;
            rECDepcription.Text = obj.Description;
            DtimeStatusTime.Text = "" + obj.DayOf;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dxErrorProvider1.ClearErrors();
            if (string.IsNullOrEmpty(uluMKH.Text))
                dxErrorProvider1.SetError(uluMKH, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(DtimeStatusTime.Text))
                dxErrorProvider1.SetError(DtimeStatusTime, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(rEContent.Text))
                dxErrorProvider1.SetError(rEContent, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(rECDepcription.Text))
                dxErrorProvider1.SetError(DtimeStatusTime, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(rECDepcription.Text))
                dxErrorProvider1.SetError(rECDepcription, "Bạn không được dể trống dữ liệu");
            else
            {
                objCoursesJournalEntity.CoId = Guid.Parse("" + uluMKH.EditValue);
                objCoursesJournalEntity.DayOf = Convert.ToDateTime(DtimeStatusTime.Text);
                objCoursesJournalEntity.Contents = rEContent.Text;
                objCoursesJournalEntity.Description = rECDepcription.Text;
                DialogResult obj = MessageBox.Show("Bạn muốn cập nhật ký giảng dạy không",
                   "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (obj == DialogResult.Yes)
                {
                    objBclCouresesJour.Update(objCoursesJournalEntity);
                    MessageBox.Show("Bạn đã cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Bạn đã cập nhật thất bại");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}