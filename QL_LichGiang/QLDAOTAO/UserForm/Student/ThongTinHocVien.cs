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

namespace QL_LICHGIANGDAY.UserForm.Student
{
    public partial class ThongTinHocVien : DevExpress.XtraEditors.XtraForm
    {

        public ThongTinHocVien()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text)) errorProvider1.SetError(txtHoVaTen, "Dữ liệu không hợp lệ");
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text)) errorProvider1.SetError(txtDiaChi, "Dữ liệu không hợp lệ");
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) errorProvider1.SetError(txtEmail, "Dữ liệu không hợp lệ");
            if (string.IsNullOrWhiteSpace(txtMobile.Text)) errorProvider1.SetError(txtMobile, "Dữ liệu không hợp lệ");
            else
            {
                var student = new StudentObjects();
                student.StudetId = Guid.NewGuid();
                student.FullName = txtHoVaTen.Text;
                student.Address = txtDiaChi.Text;
                student.Email = txtEmail.Text;
                student.Mobile = txtMobile.Text;
                student.Deleted = false;
                student.Status = cbStatus.Checked;
                StudentBCL mStudentBCL = new StudentBCL();
                mStudentBCL.Insert(student);
                MessageBox.Show("Cập nhật Học Viên thành công!");
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}