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

namespace QL_LICHGIANGDAY.UserForm.SchedStudentDetailt
{
    public partial class UsAddSchedStudentDetailt : DevExpress.XtraEditors.XtraForm
    {
        Guid ID_Scheduler;
        public UsAddSchedStudentDetailt(Guid ID_Sche)
        {
            InitializeComponent();
            ID_Scheduler = ID_Sche;
        }

        private void UsAddSchedStudentDetailt_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            LoadData();
            this.Cursor = Cursors.Default;
        }

        private void LoadData()
        {
            //var maKhoaHoc = new SchedulersBCL().GetByScId(ID_Scheduler).CoId;
            //var listStd = new StudentDetailtBCL().GetAll().Where(q => q.CoId == maKhoaHoc).ToList();
            //if (listStd.Count <= 0) MessageBox.Show("Không có học viên nào trong khóa học này!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //List<StudentObjects> data = new List<StudentObjects>();
            //foreach (var item in listStd)
            //{
            //    data.Add(new StudentBCL().GetByStudetId((Guid)item.StudetId));
            //}
            var data = new StudentBCL().GetAll();
            LoadLookup(lookUpEditStudentID, data, "FullName", "StudetId");
            rtbDescription.Text = "Học viên nghỉ học ngày " + DateTime.Now.ToShortDateString();
        }

        private void LoadLookup(LookUpEdit lookupedit, object source, string displayMember, string valueMember)
        {
            lookupedit.Properties.DataSource = source;
            lookupedit.Properties.DisplayMember = displayMember;
            lookupedit.Properties.ValueMember = valueMember;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lookUpEditStudentID.EditValue == null) MessageBox.Show("Chọn một Học viên.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var result = new SchedStudentDetailtBCL().Insert(new SchedStudentDetailtObjects()
                {
                    Description = rtbDescription.Text,
                    ScId = ID_Scheduler,
                    ScsId = Guid.NewGuid(),
                    StudetId = (Guid)lookUpEditStudentID.EditValue
                });
                var student = new StudentBCL().GetByStudetId((Guid)lookUpEditStudentID.EditValue);
                if (result == true)
                {
                    MessageBox.Show(string.Format("Thêm học viên {0} thành công", student.FullName), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(string.Format("Thêm học viên {0} thất bại", student.FullName), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void lookUpEditScedulerID_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}