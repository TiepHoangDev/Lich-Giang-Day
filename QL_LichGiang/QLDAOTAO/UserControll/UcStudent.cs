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
    public partial class UcStudent : UserControl
    {
        private StudentBCL obj = new StudentBCL();
        private PermisstionObject m_objPer;
        public UcStudent(PermisstionObject objPer)
        {
            m_objPer = null;
            m_objPer = objPer;
            InitializeComponent();
            ucBaseControl1.EnableDisnableButtom(m_objPer);
            ucBaseControl1.onThemThongTin += new EventHandler(ThemHocVien);
            ucBaseControl1.onXoaThongTin += new EventHandler(XoaHocVien);
            ucBaseControl1.onSuaThongTin += new EventHandler(CapNhatHocVien);
        }

        void ThemHocVien(object sender, EventArgs e)
        {
            UserForm.Student.ThongTinHocVien frm1 = new UserForm.Student.ThongTinHocVien();
            frm1.ShowDialog();
            LoadStudent();
        }

        void CapNhatHocVien(object sender, EventArgs e)
        {
            Guid StudetId = (Guid)grvStudent.GetFocusedRowCellValue("StudetId");
            UserForm.Student.SuaHocVien frm1 = new UserForm.Student.SuaHocVien(new StudentBCL().GetByStudetId(StudetId));
            frm1.ShowDialog();
            LoadStudent();
        }

        void XoaHocVien(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa học viên này?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Guid StudetId = (Guid)grvStudent.GetFocusedRowCellValue("StudetId");
                StudentBCL mStudentBCL = new StudentBCL();
                mStudentBCL.Delete(StudetId);
                MessageBox.Show("Xóa Học viên thành công!");
                LoadStudent();
            }
        }

        private void UcStudent_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        void LoadStudent()
        {
            StudentBCL mStudentBCL = new StudentBCL();
            grcStudent.DataSource = mStudentBCL.GetAll();
        }

    }
}
