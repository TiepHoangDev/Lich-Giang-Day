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
    public partial class UcCourses : UserControl
    {
        private CoursesBCL objBclCoureses = new CoursesBCL();
        private CoursesObjects objCoursesEntity = new CoursesObjects();
        private PermisstionObject m_objPer;
        public UcCourses(PermisstionObject objPer)
        {
            m_objPer = null;
            m_objPer = objPer;
            InitializeComponent();
            ucBaseControl1.EnableDisnableButtom(m_objPer);
            ucBaseControl1.onThemThongTin += new EventHandler(ucBaseControl1_onThemThongTin);
            ucBaseControl1.onSuaThongTin += new EventHandler(ucBaseControl1_onSuaThongTin);
            ucBaseControl1.onXoaThongTin +=new EventHandler(ucBaseControl1_onXoaThongTin);
            //getallCousrses();
        }

        void ucBaseControl1_onXoaThongTin(object sender, EventArgs e)
        {
            objCoursesEntity.CoId = Guid.Parse("" + cardView1.GetFocusedRowCellValue("CoId"));
            DialogResult obj = MessageBox.Show("Bạn muốn xóa không",
                "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (obj == DialogResult.Yes)
            {
                objBclCoureses.Delete(objCoursesEntity.CoId);
                MessageBox.Show("Bạn đã xóa thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã xóa thất bại");
            }
            Load_DataCourses();
        }

        void ucBaseControl1_onSuaThongTin(object sender, EventArgs e)
        {
            CoursesObjects objCoursesEntity = (CoursesObjects)cardView1.GetFocusedRow();
            UserForm.UsCourses.UsUpdateCourses frm = new UserForm.UsCourses.UsUpdateCourses(objCoursesEntity);
            frm.ShowDialog();
            Load_DataCourses();
        }

        void ucBaseControl1_onThemThongTin(object sender, EventArgs e)
        {
            UserForm.UsCourses.UsAddCourses frm = new UserForm.UsCourses.UsAddCourses();
            frm.ShowDialog();
            Load_DataCourses();
        }

        private void grcCourses_Load(object sender, EventArgs e)
        {
            Load_DataCourses();
        }
        void Load_DataCourses()
        {
            grcCourses.DataSource = objBclCoureses.GetAll();
        }

        private void ucBaseControl1_Load(object sender, EventArgs e)
        {

        }
        //public void getallCousrses()
        //{
        //    grcCourses.DataSource = new CoursesBCL().GetAll();
        //}
    }
}
