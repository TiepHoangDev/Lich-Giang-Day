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
using BUSINESS_OBJECT.Objects;
using BUSINESS_LOGIC_LAYER.BCL;

namespace QL_LICHGIANGDAY.UserForm.Weekdays
{
    public partial class ThuTrongTuan : DevExpress.XtraEditors.XtraForm
    {
        public ThuTrongTuan()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
        }

        public ThuTrongTuan(WeekdaysObjects obj)
        {
            InitializeComponent();
            
            if (obj != null)
            {
                txtMota.Text = obj.Description;
                cboTenThuTrongTuan.Text = obj.WeName;
                btnThemMoi.Enabled = false;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            WeekdaysObjects objWeekdays = new WeekdaysObjects
            {
               WeId = Guid.NewGuid(),
               WeName = cboTenThuTrongTuan.Text,
               Description = txtMota.Text             

            };

            WeekdaysBCL mWeekdaysBCL = new WeekdaysBCL();
            mWeekdaysBCL.Insert(objWeekdays);
            MessageBox.Show("Thêm Thứ Trong Tuần thành công!");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            WeekdaysObjects objWeekdays = new WeekdaysObjects
            {
                WeName = cboTenThuTrongTuan.Text,
                Description = txtMota.Text
            };
            WeekdaysBCL mWeekdaysBCL = new WeekdaysBCL();
            mWeekdaysBCL.Update(objWeekdays);
            MessageBox.Show("Cập nhật Thứ Trong Tuần thành công!");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }


        
    }
}