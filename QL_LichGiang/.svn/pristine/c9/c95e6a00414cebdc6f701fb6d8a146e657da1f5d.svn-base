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
    public partial class UcShiftDay : UserControl
    {
        private ShiftDayBCL obj = new ShiftDayBCL();
        private PermisstionObject m_objPer;
        public UcShiftDay(PermisstionObject objPer)
        {
            m_objPer = null;
            m_objPer = objPer;
            InitializeComponent();
            ucBaseControl1.EnableDisnableButtom(m_objPer);
            ucBaseControl1.onSuaThongTin += new EventHandler(ucBaseControl1_onSuaThongTin);
            ucBaseControl1.onThemThongTin += new EventHandler(ucBaseControl1_onThemThongTin);
            ucBaseControl1.onXoaThongTin += new EventHandler(ucBaseControl1_onXoaThongTin);
        }

        void ucBaseControl1_onXoaThongTin(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa Ca học này?", "Xóa ca học", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Guid ShiftId = (Guid)cardView1.GetFocusedRowCellValue("ShiftId");
                ShiftDayBCL mShifDayBCL = new ShiftDayBCL();
                mShifDayBCL.Delete(ShiftId);
                MessageBox.Show("Xóa Ca học thành công!");
                Load_ShiftDay();
            }
        }

        void ucBaseControl1_onThemThongTin(object sender, EventArgs e)
        {
            UserForm.ShiftDay.CaHoc frm1 = new UserForm.ShiftDay.CaHoc();
            frm1.ShowDialog();
            Load_ShiftDay();
        }

        void ucBaseControl1_onSuaThongTin(object sender, EventArgs e)
        {
            Guid ShiftId = (Guid)cardView1.GetFocusedRowCellValue("ShiftId");
            UserForm.ShiftDay.CaHoc frm1 = new UserForm.ShiftDay.CaHoc(new ShiftDayBCL().GetByShiftId(ShiftId));
            frm1.ShowDialog();
            Load_ShiftDay();
        }

        private void grcShiftDay_Load(object sender, EventArgs e)
        {
            Load_ShiftDay();
        }

        private void Load_ShiftDay()
        {
            grcShiftDay.DataSource = obj.GetAll();
        }
    }
}
