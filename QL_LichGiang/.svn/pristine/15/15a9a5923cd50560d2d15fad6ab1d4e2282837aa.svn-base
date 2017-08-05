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

namespace QL_LICHGIANGDAY.UserForm.Experts
{
    public partial class UsAddExperts : DevExpress.XtraEditors.XtraForm
    {
        public UsAddExperts()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdress.Text)) MessageBox.Show("Không để rỗng địa chỉ.", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtEmail.Text)) MessageBox.Show("Không để rỗng Email ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtFullName.Text)) MessageBox.Show("Không để rỗng Tên đầy đủ ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtMobile.Text)) MessageBox.Show("Không để rỗng Số điện thoại ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtSpecialize.Text)) MessageBox.Show("Không để rỗng Chuyên môn ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                var data = new ExpertsBCL().Insert(new ExpertsObjects()
                {
                    Address = txtAdress.Text,
                    Deleted = false,
                    Description = rtbDescription.Text,
                    Email = txtEmail.Text,
                    ExpertId = Guid.NewGuid(),
                    FullName = txtFullName.Text,
                    Mobile = txtMobile.Text,
                    Specialize = txtSpecialize.Text,
                    StartDate = datetimeStart.Value,
                    Status = cbStatus.Checked
                });
                if (data == true)
                {
                    MessageBox.Show("Thêm giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm giảng viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void UsAddExperts_Load(object sender, EventArgs e)
        {
            datetimeStart.Value = DateTime.Now;
            rtbDescription.Text = string.Format("Thêm vào ngày {0}", DateTime.Now.ToLongDateString());
        }

    }
}