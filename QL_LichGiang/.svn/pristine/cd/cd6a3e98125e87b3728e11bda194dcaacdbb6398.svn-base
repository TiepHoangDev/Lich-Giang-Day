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
    public partial class UcSchedulers : UserControl
    {
        private SchedulersBCL obj = new SchedulersBCL();
        private PermisstionObject m_objPer;
        Nullable<Guid> ID_Course = null;

        public UcSchedulers(PermisstionObject objPer)
        {
            m_objPer = objPer;
            InitializeComponent();
            ucBaseControl1.EnableDisnableButtom(m_objPer);
            ucBaseControl1.onSuaThongTin += new EventHandler(ucBaseControl1_onSuaThongTin);
            ucBaseControl1.onThemThongTin += new EventHandler(ucBaseControl1_onThemThongTin);
            ucBaseControl1.onXoaThongTin += new EventHandler(ucBaseControl1_onXoaThongTin);
        }

        void ucBaseControl1_onXoaThongTin(object sender, EventArgs e)
        {
            Guid ID = (Guid)cardView1.GetFocusedRowCellValue("ScId");
            var obj = new SchedulersBCL().GetByScId(ID);
            if (MessageBox.Show("Bạn có muốn xóa? ", "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new SchedulersBCL().Delete(ID))
                {
                    MessageBox.Show("Xóa thành công ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
        }

        private void LoadData()
        {
            LoadSearchLookUpEdit();
            LoadGridControl();
        }

        private void LoadSearchLookUpEdit()
        {
            var data = new CoursesBCL().GetAll();
            searchLookUpEdit1.Properties.DataSource = data;
            if (ID_Course != null && data.Count > 0) searchLookUpEdit1.EditValue = ID_Course;
            else ID_Course = null;
        }

        private void LoadGridControl()
        {
            lblGiangVien.Text = "";
            if (ID_Course != null)
            {
                grcSchedulers.DataSource = new SchedulersBCL().GetJoin().Where(q => q.CoId == ID_Course).ToList();
                var lstGiangVien = new ExpertsDetailtBCL().GetJoin().Where(q => q.CoId == ID_Course).ToList();
                for (int i = 1; i < lstGiangVien.Count; i++)
                {
                    lblGiangVien.Text += string.Format(" {0}. {1}", i, lstGiangVien[i].ExpertsJoin.FullName);
                }
            }
        }

        void ucBaseControl1_onSuaThongTin(object sender, EventArgs e)
        {
            Guid ID = (Guid)cardView1.GetFocusedRowCellValue("ScId");
            new UserForm.Schedulers.UsEditSchedulers(ID).ShowDialog();
        }

        void ucBaseControl1_onThemThongTin(object sender, EventArgs e)
        {
            new UserForm.Schedulers.UsAddSchedulers().ShowDialog();
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var k = searchLookUpEdit1.EditValue;
            if (k != null)
            {
                ID_Course = (Guid)k;
                LoadGridControl();
            }
        }

        private void grcSchedulers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Guid ID = (Guid)cardView1.GetFocusedRowCellValue("ScId");
            new UserForm.frmDetail(m_objPer, ID).ShowDialog();
            LoadData();
        }

    }
}
