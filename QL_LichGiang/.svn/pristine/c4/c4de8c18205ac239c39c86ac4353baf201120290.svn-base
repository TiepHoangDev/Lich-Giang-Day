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
namespace QL_LICHGIANGDAY.UserForm.UsCourses
{
    public partial class UsAddCourses : DevExpress.XtraEditors.XtraForm
    {
        private CoursesObjects objCoursesEntity = new CoursesObjects();
        private CoursesBCL objCoursesControler = new CoursesBCL();
        public UsAddCourses()
        {
            InitializeComponent();
        }

        private void btnInset_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtMKH.Text))
                errorProvider1.SetError(txtMKH, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(txtName.Text))
                errorProvider1.SetError(txtName, "Bạn không được dể trống dữ liệu");
            else if (num.Value >= 255)
                errorProvider1.SetError(num, "Số lượng học viên quá nhiều");
            else if (string.IsNullOrEmpty(DtimeStatusTime.Text))
                errorProvider1.SetError(DtimeStatusTime, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(DtimeEndTime.Text))
                errorProvider1.SetError(DtimeEndTime, "Bạn không được dể trống dữ liệu");
            else if (string.IsNullOrEmpty(rECDepcription.Text))
                errorProvider1.SetError(rECDepcription, "Bạn không được dể trống dữ liệu");
            else
            {
                objCoursesEntity.CoId = Guid.NewGuid();
                objCoursesEntity.CourseId = txtMKH.Text;
                objCoursesEntity.CourseName = txtName.Text;
                objCoursesEntity.StartDate = Convert.ToDateTime(DtimeStatusTime.Text);
                objCoursesEntity.EndDate = Convert.ToDateTime(DtimeEndTime.Text);
                objCoursesEntity.Description = rECDepcription.Text;
                objCoursesEntity.TotalNumber = (byte)num.Value;
                objCoursesEntity.Status = cbStatus.Checked;
                objCoursesEntity.Deleted = false;
                DialogResult obj = MessageBox.Show("Bạn muốn thêm khóa học không",
                   "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (obj == DialogResult.Yes)
                {
                    objCoursesControler.Insert(objCoursesEntity);
                    MessageBox.Show("Bạn đã thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsAddCourses_Load(object sender, EventArgs e)
        {
            
        }
    }
}