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
    public partial class UsAddCoursesJourna : DevExpress.XtraEditors.XtraForm
    {
        private CoursesJournalBCL objBclCouresesJour = new CoursesJournalBCL();
        private CoursesJournalObjects objCoursesJournalEntity = new CoursesJournalObjects();
        private CoursesBCL objCoursesBCL=new CoursesBCL();
        public UsAddCoursesJourna()
        {
            InitializeComponent();
            bindding();
        }
        void bindding()
        {
            uluMKH.Properties.DataSource = objCoursesBCL.GetAll();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(uluMKH.Text))
                errorProvider1.SetError(uluMKH, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(DtimeStatusTime.Text))
                errorProvider1.SetError(DtimeStatusTime, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(rEContent.Text))
                errorProvider1.SetError(rEContent, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(rECDepcription.Text))
                errorProvider1.SetError(DtimeStatusTime, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(rECDepcription.Text))
                errorProvider1.SetError(rECDepcription, "Bạn không được dể trống dữ liệu");
            else
            {
                objCoursesJournalEntity.CJId = Guid.NewGuid();
                objCoursesJournalEntity.CoId = Guid.Parse(""+uluMKH.EditValue);
                objCoursesJournalEntity.DayOf = Convert.ToDateTime(DtimeStatusTime.Text);
                objCoursesJournalEntity.Contents = rEContent.Text;
                objCoursesJournalEntity.Description = rECDepcription.Text;
                DialogResult obj = MessageBox.Show("Bạn muốn thêm nhật ký học không",
                   "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (obj == DialogResult.Yes)
                {
                    objBclCouresesJour.Insert(objCoursesJournalEntity);
                    MessageBox.Show("Bạn đã thêm thành công");
                }
                else
                {
                    MessageBox.Show("Bạn đã thêm thất bại");
                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}