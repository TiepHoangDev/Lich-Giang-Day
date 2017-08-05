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

namespace QL_LICHGIANGDAY.UserForm.Schedulers
{
    public partial class UsAddSchedulers : DevExpress.XtraEditors.XtraForm
    {
        public UsAddSchedulers()
        {
            InitializeComponent();
        }

        private void UsAddSchedulers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.Cursor = Cursors.WaitCursor;
            lookUpEditCourseID.Properties.DataSource = new CoursesBCL().GetAll();
            lookUpEditShiftID.Properties.DataSource = new ShiftDayBCL().GetAll();
            lookUpEditWeekDayID.Properties.DataSource = new WeekdaysBCL().GetAll();
            this.Cursor = Cursors.Default;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lookUpEditCourseID.EditValue == null) MessageBox.Show("Chọn một Khóa học.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (lookUpEditShiftID.EditValue == null) MessageBox.Show("Chọn một Ca học.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (lookUpEditWeekDayID.EditValue == null) MessageBox.Show("Chọn một Thời gian học.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var result = new SchedulersBCL().Insert(new SchedulersObjects()
                {
                    CoId = (Guid)lookUpEditCourseID.EditValue,
                    Description = rtbDescription.Text,
                    ScId = Guid.NewGuid(),
                    ShiftId = (Guid)lookUpEditShiftID.EditValue,
                    WeId = (Guid)lookUpEditWeekDayID.EditValue
                });
                if (result == true)
                {
                    MessageBox.Show(string.Format("Thêm lịch học thành công"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(string.Format("Thêm lịch học thất bại"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}