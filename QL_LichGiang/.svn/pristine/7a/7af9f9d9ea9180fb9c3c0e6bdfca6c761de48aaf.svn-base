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
    public partial class UcSchedStudentDetailt : UserControl
    {
        private SchedStudentDetailtBCL obj = new SchedStudentDetailtBCL();
        private PermisstionObject m_objPer;
        public SchedulersObjects objSchedulersObjects { get; set; }
        public UcSchedStudentDetailt(PermisstionObject objPer,Guid? ID_Schedulers = null)
        {
            m_objPer = null;
            m_objPer = objPer;
            InitializeComponent();
            ucBaseControl1.EnableDisnableButtom(m_objPer);
            ucBaseControl1.onSuaThongTin += new EventHandler(ucBaseControl1_onSuaThongTin);
            ucBaseControl1.onThemThongTin += new EventHandler(ucBaseControl1_onThemThongTin);
            ucBaseControl1.onXoaThongTin += new EventHandler(ucBaseControl1_onXoaThongTin);
            if (ID_Schedulers == null) MessageBox.Show("ID_Schedulers null");
            objSchedulersObjects = new SchedulersBCL().GetByScId((Guid)ID_Schedulers);
        }

        void ucBaseControl1_onXoaThongTin(object sender, EventArgs e)
        {
            Guid ID = (Guid)cardView1.GetFocusedRowCellValue("ScsId");
            var obj = new SchedStudentDetailtBCL().GetByScsId(ID);
            if (MessageBox.Show("Bạn có muốn xóa? ", "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new SchedStudentDetailtBCL().Delete(ID))
                {
                    MessageBox.Show("Xóa thành công ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_SchedStudentDetailt();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void ucBaseControl1_onSuaThongTin(object sender, EventArgs e)
        {
            Guid ID = (Guid)cardView1.GetFocusedRowCellValue("ScsId");
            new UserForm.SchedStudentDetailt.UsEditSchedStudentDetailt(ID).ShowDialog();
            Load_SchedStudentDetailt();
        }

        void ucBaseControl1_onThemThongTin(object sender, EventArgs e)
        {
            new UserForm.SchedStudentDetailt.UsAddSchedStudentDetailt(objSchedulersObjects.ScId).ShowDialog();
            Load_SchedStudentDetailt();
        }

        
        private void grcSchedStudentDetailt_Load(object sender, EventArgs e)
        {
            Load_SchedStudentDetailt();
        }

        private void Load_SchedStudentDetailt()
        {
            grcSchedStudentDetailt.DataSource = obj.GetJoin().Where(q => q.ScId == objSchedulersObjects.ScId).ToList();
        }
    }
}
