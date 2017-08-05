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
    public partial class UsEditExperts : DevExpress.XtraEditors.XtraForm
    {
        public ExpertsObjects objExpert { get; private set; }

        public UsEditExperts(Guid ID_Expert)
        {
            InitializeComponent();

            this.objExpert = new ExpertsBCL().GetByExpertId(ID_Expert);

            txtAdress.Text = objExpert.Address;
            rtbDescription.Text = objExpert.Description;
            txtEmail.Text = objExpert.Email;
            txtFullName.Text = objExpert.FullName;
            txtMobile.Text = objExpert.Mobile;
            txtSpecialize.Text = objExpert.Specialize;
            datetimeStart.Value = (DateTime)objExpert.StartDate;
            cbStatus.Checked = objExpert.Status ?? true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdress.Text)) MessageBox.Show("Không để rỗng địa chỉ.", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtEmail.Text)) MessageBox.Show("Không để rỗng Email ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtFullName.Text)) MessageBox.Show("Không để rỗng Tên đầy đủ ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtMobile.Text)) MessageBox.Show("Không để rỗng Số điện thoại ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtSpecialize.Text)) MessageBox.Show("Không để rỗng Chuyên môn ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                objExpert.Address = txtAdress.Text;
                objExpert.Description = rtbDescription.Text;
                objExpert.Email = txtEmail.Text;
                objExpert.FullName = txtFullName.Text;
                objExpert.Mobile = txtMobile.Text;
                objExpert.Specialize = txtSpecialize.Text;
                objExpert.StartDate = datetimeStart.Value;
                objExpert.Status = cbStatus.Checked;

                var result = new ExpertsBCL().Update(objExpert);
                MessageBox.Show(string.Format("Sửa {0}", result ? "thành công" : "thất bại"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}