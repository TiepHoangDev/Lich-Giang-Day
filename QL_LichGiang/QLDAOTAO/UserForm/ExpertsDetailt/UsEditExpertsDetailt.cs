using System;
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

namespace QL_LICHGIANGDAY.UserForm.ExpertsDetailt
{
    public partial class UsEditExpertsDetailt : DevExpress.XtraEditors.XtraForm
    {
        public UsEditExpertsDetailt(ExpertsDetailtObjects obj)
        {

            InitializeComponent();
            sluMaChuyenGia.EditValue = (Guid)obj.ExpertId;            
            sluMaKhoaHoc.EditValue = (Guid)obj.CoId;
            txtMota.Text = obj.Description;           
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        

        private void Load_DataExpertDetailt()
        {
            CoursesBCL objCoursesBC = new CoursesBCL();
            ExpertsBCL objExpertsBCL = new ExpertsBCL();
            sluMaChuyenGia.Properties.DataSource = objExpertsBCL.GetAll();
            sluMaKhoaHoc.Properties.DataSource = objCoursesBC.GetAll();
        }

        private void groupControl1_Enter(object sender, EventArgs e)
        {
            Load_DataExpertDetailt();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            ExpertsDetailtObjects objE = new ExpertsDetailtObjects
            {
                ExpertId = (Guid)sluMaChuyenGia.EditValue,
                CoId = (Guid)sluMaKhoaHoc.EditValue,
                Description = txtMota.Text
            };

            ExpertsDetailtBCL mExpertDetailBCL = new ExpertsDetailtBCL();
            mExpertDetailBCL.Update(objE);
            MessageBox.Show("Sửa Chi tiết Giảng Viên thành công!");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}