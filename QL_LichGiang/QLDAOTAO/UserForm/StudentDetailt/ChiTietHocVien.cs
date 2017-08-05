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

namespace QL_LICHGIANGDAY.UserForm.StudentDetailt
{
    public partial class ChiTietHocVien : DevExpress.XtraEditors.XtraForm
    {
        public ChiTietHocVien()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
            suluMaHV.Properties.DataSource = new StudentBCL().GetAll();
            suluMaKhoaHoc.Properties.DataSource = new CoursesBCL().GetAll();
        }

        public ChiTietHocVien(StudentDetailtObjects obj)
        {
            InitializeComponent();
            if (obj != null)
            {
                txtMota.Text = obj.Description;
                suluMaHV.EditValue = obj.StudetId;
                suluMaKhoaHoc.EditValue = obj.CoId;
                btnThemMoi.Enabled = false;

            }


        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
          
            StudentDetailtObjects objStudentDetailt = new StudentDetailtObjects
            {
                StdId = Guid.NewGuid(),
                Description = txtMota.Text,
                StudetId = (Guid)suluMaHV.EditValue,
                CoId = (Guid)suluMaKhoaHoc.EditValue
            };
            
            StudentDetailtBCL mStudentDetailtBCL = new StudentDetailtBCL();
            
            mStudentDetailtBCL.Insert(objStudentDetailt);
            MessageBox.Show("Thêm Chi tiết Học viên thành công!");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {           
           // StudentObjects obj = (StudentObjects)cboMaHocVien.SelectedItem;
            
            StudentDetailtObjects objStudentDetailtObject = new StudentDetailtObjects
            {
                StudetId = (Guid)suluMaHV.EditValue,
                CoId = (Guid)suluMaKhoaHoc.EditValue,
                Description = txtMota.Text
               
            };

            StudentDetailtBCL mStudentDetailtBCL = new StudentDetailtBCL();
            mStudentDetailtBCL.Update(objStudentDetailtObject);
            MessageBox.Show("Cập nhật Chi tiết Học viên thành công!");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataChiTietHocVien()
        {
            CoursesBCL objCoursesBCL = new CoursesBCL();
            StudentBCL objStudentBCL = new StudentBCL();
            suluMaHV.Properties.DataSource = objStudentBCL.GetAll();
            suluMaKhoaHoc.Properties.DataSource = objCoursesBCL.GetAll();
        }

        private void groupControl1_Enter(object sender, EventArgs e)
        {
            LoadDataChiTietHocVien();
        }

      


    }
}