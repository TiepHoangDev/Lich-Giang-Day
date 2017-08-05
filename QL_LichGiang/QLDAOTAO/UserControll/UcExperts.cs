﻿using System;
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
    public partial class UcExperts : UserControl
    {
        private ExpertsBCL objExperts = new ExpertsBCL();
        private PermisstionObject m_objPer;
        public UcExperts(PermisstionObject objPer)
        {
            m_objPer = null;
            m_objPer = objPer;
            InitializeComponent();
            ucBaseControl1.EnableDisnableButtom(m_objPer);
            ucBaseControl1.onThemThongTin += new EventHandler(ucBaseControl1_onThemThongTin);
            ucBaseControl1.onSuaThongTin += new EventHandler(ucBaseControl1_onSuaThongTin);
            ucBaseControl1.onXoaThongTin += new EventHandler(ucBaseControl1_onXoaThongTin);
        }
        void ucBaseControl1_onXoaThongTin(object sender, EventArgs e)
        {
            Guid ID = (Guid)cardView1.GetFocusedRowCellValue("ExpertId");
            var obj = new ExpertsBCL().GetByExpertId(ID);
            if (MessageBox.Show("Bạn có muốn xóa " + obj.FullName, "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new ExpertsBCL().Delete(ID))
                {
                    MessageBox.Show("Xóa thành công " + obj.FullName, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_DataExperts();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại " + obj.FullName, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void ucBaseControl1_onSuaThongTin(object sender, EventArgs e)
        {
            Guid ID = (Guid)cardView1.GetFocusedRowCellValue("ExpertId");
            new UserForm.Experts.UsEditExperts(ID).ShowDialog();
            Load_DataExperts();
        }

        void ucBaseControl1_onThemThongTin(object sender, EventArgs e)
        {
            new UserForm.Experts.UsAddExperts().ShowDialog();
            Load_DataExperts();
        }

       
        void Load_DataExperts()
        {
            grcExperts.DataSource = objExperts.GetAll();
        }

        private void grcExperts_Load(object sender, EventArgs e)
        {
            Load_DataExperts();
        }
    }
}
