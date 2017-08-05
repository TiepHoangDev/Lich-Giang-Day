using System;
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
    public partial class UcCoursesJourna : UserControl
    {
        private CoursesJournalBCL objBclCouresesJour = new CoursesJournalBCL();
        private CoursesJournalObjects objCoursesJournalEntity = new CoursesJournalObjects();
        private CoursesBCL objCoursesBCL = new CoursesBCL();
        public UcCoursesJourna()
        {
            InitializeComponent();
            ucBaseControl1.onThemThongTin += new EventHandler(ucBaseControl1_onThemThongTin);
            ucBaseControl1.onSuaThongTin += new EventHandler(ucBaseControl1_onSuaThongTin);
            ucBaseControl1.onXoaThongTin += new EventHandler(ucBaseControl1_onXoaThongTin);
           
        }
        void ucBaseControl1_onXoaThongTin(object sender, EventArgs e)
        {
            objCoursesJournalEntity.CJId = Guid.Parse("" + cardView1.GetFocusedRowCellValue("CJId"));
            DialogResult obj = MessageBox.Show("Bạn muốn xóa không",
                "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (obj == DialogResult.Yes)
            {
                objBclCouresesJour.Delete(objCoursesJournalEntity.CJId);
                MessageBox.Show("Bạn đã xóa thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã xóa thất bại");
            }
            Load_DataCoursesJourna();
        }

        void ucBaseControl1_onSuaThongTin(object sender, EventArgs e)
        {
            objCoursesJournalEntity.CJId = Guid.Parse("" + cardView1.GetFocusedRowCellValue("CJId"));
            var data = new CoursesJournalBCL().GetByCJId(objCoursesJournalEntity);
            UserForm.UsCoursesJourna.UsUpdateCousesJourna frm = new UserForm.UsCoursesJourna.UsUpdateCousesJourna(data);
            frm.ShowDialog();
            Load_DataCoursesJourna();
        }

        void ucBaseControl1_onThemThongTin(object sender, EventArgs e)
        {
            UserForm.UsCoursesJourna.UsAddCoursesJourna frm = new UserForm.UsCoursesJourna.UsAddCoursesJourna();
            frm.ShowDialog();
            Load_DataCoursesJourna();
        }

        //private void grcCourses_Load(object sender, EventArgs e)
        //{

           
        //    //grcCoursesJourna.DataSource = objBclCouresesJour.GetAll();
        //}
        void Load_DataCoursesJourna()
        {
            grcCoursesJourna.DataSource = objBclCouresesJour.GetAll();
            uluMKH.DataSource = objCoursesBCL.GetAll();
        }

        private void grcCoursesJourna_Load(object sender, EventArgs e)
        {
            Load_DataCoursesJourna();
        }
    }
}
