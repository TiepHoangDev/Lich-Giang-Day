using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESS_OBJECT.Objects;
namespace QL_LICHGIANGDAY.UserControll
{
    public partial class UcBaseControl : UserControl
    {
        public event EventHandler onThemThongTin = null;
        public event EventHandler onSuaThongTin = null;
        public event EventHandler onXoaThongTin = null;
        public UcBaseControl()
        {
            InitializeComponent();

        }

        private void bLBI_ThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (onThemThongTin != null)
                onThemThongTin(sender, e);
        }

        private void bLBI_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (onSuaThongTin != null)
                onSuaThongTin(sender, e);
        }

        private void bLBI_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (onXoaThongTin != null)
                onXoaThongTin(sender, e);
        }
        public void EnableDisnableButtom(PermisstionObject objper)
        {
            if (objper == null)
            {
                btnthem.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
            else
            {
                btnthem.Enabled = (bool)objper.F_ADD;
                btnsua.Enabled = (bool)objper.F_EDIT;
                btnxoa.Enabled = (bool)objper.F_DELETE;
                objper.F_SEARCH = false;
            }
        }

    }
}
