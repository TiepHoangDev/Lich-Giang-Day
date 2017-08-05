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
    public partial class UcExpertsDetailt : UserControl
    {
        public ExpertsDetailtBCL objExpertsDetailt = new ExpertsDetailtBCL();
        private PermisstionObject m_objPer;

        public Guid ID_Expert { get; set; }

        public UcExpertsDetailt(PermisstionObject objPer)
        {
            m_objPer = null;
            m_objPer = objPer;
            InitializeComponent();
            ucBaseControl1.EnableDisnableButtom(m_objPer);
            ucBaseControl1.onThemThongTin += new EventHandler(ucBaseControl1_onThemThongTin);
            ucBaseControl1.onSuaThongTin += new EventHandler(ucBaseControl1_onSuaThongTin);
            ucBaseControl1.onXoaThongTin += new EventHandler(ucBaseControl1_onXoaThongTin);

        }

        void ucBaseControl1_onXoaThongTin(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa Chi tiết giảng viên này?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ExpertsDetailtObjects obj = new ExpertsDetailtObjects
                {
                    ExId = (Guid)cardView1.GetFocusedRowCellValue("ExId")
                };
                ExpertsDetailtBCL mExpertsDetailBCL = new ExpertsDetailtBCL();
                mExpertsDetailBCL.Delete(obj.ExId);
                MessageBox.Show("Xóa Chi tiết Giảng viên thành công!");
                Load_DataExpertDetailt();
            }


        }

        void ucBaseControl1_onSuaThongTin(object sender, EventArgs e)
        {

            ExpertsDetailtObjects obj = new ExpertsDetailtObjects
            {
                ExId = (Guid)cardView1.GetFocusedRowCellValue("ExId"),
                ExpertId = (Guid)cardView1.GetFocusedRowCellValue("ExpertId"),
                CoId = (Guid)cardView1.GetFocusedRowCellValue("CoId"),
                Description = "" + cardView1.GetFocusedRowCellValue("Description")
            };

            UserForm.ExpertsDetailt.UsEditExpertsDetailt frm1 = new UserForm.ExpertsDetailt.UsEditExpertsDetailt(obj);
            frm1.ShowDialog();
            Load_DataExpertDetailt();

        }

        void ucBaseControl1_onThemThongTin(object sender, EventArgs e)
        {
            UserForm.ExpertsDetailt.UsAddExpertsDetailt frm1 = new UserForm.ExpertsDetailt.UsAddExpertsDetailt();
            frm1.ShowDialog();
            Load_DataExpertDetailt();
        }



        private void Load_DataExpertDetailt()
        {
            ExpertsDetailtBCL mExpertsDetailtBCL = new ExpertsDetailtBCL();
            CoursesBCL objCoursesBC = new CoursesBCL();
            ExpertsBCL objExpertsBCL = new ExpertsBCL();
            grcExpertsDetailt.DataSource = mExpertsDetailtBCL.GetAll();
            uluMGV.DataSource = objExpertsBCL.GetAll();
            uluMKH.DataSource = objCoursesBC.GetAll();
        }

        private void UcExpertsDetailt_Load(object sender, EventArgs e)
        {
            Load_DataExpertDetailt();
        }
    }
}
