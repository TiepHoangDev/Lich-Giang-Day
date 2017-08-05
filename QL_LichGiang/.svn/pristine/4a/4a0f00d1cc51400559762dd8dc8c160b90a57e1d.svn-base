using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESS_OBJECT.Objects;

namespace QL_LICHGIANGDAY.UserForm
{
    public partial class frmDetail : Form
    {
        PermisstionObject objPer;
        Guid ID_Schedulers;

        public frmDetail(PermisstionObject objPer, Guid ID_Schedulers)
        {
            InitializeComponent();
            this.objPer = objPer;
            this.ID_Schedulers = ID_Schedulers;
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {
            XtraTabPage xtraDetail = new XtraTabPage();
            xtraDetail.Controls.Add(new UserControll.UcSchedStudentDetailt(objPer,ID_Schedulers));

            xtraTabControl1.TabPages.Clear();
            xtraTabControl1.TabPages.Add(xtraDetail);
        }
    }
}
