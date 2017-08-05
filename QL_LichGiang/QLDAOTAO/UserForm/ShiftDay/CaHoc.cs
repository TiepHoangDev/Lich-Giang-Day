﻿using System;
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

namespace QL_LICHGIANGDAY.UserForm.ShiftDay
{
    public partial class CaHoc : DevExpress.XtraEditors.XtraForm
    {
        public CaHoc()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
        }

        public CaHoc(ShiftDayObjects obj)
        {
            InitializeComponent();
            if (obj != null)
            {
                txtTenCaHoc.Text = obj.ShiftName;
                txtMota.Text = obj.Description;
                btnThemMoi.Enabled = false;
            }

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ShiftDayObjects objShiftDay = new ShiftDayObjects
            {
                ShiftId = Guid.NewGuid(),
                ShiftName = txtTenCaHoc.Text,
                Description = txtMota.Text
            };

            ShiftDayBCL mShiftDayBCL = new ShiftDayBCL();
            mShiftDayBCL.Insert(objShiftDay);
            MessageBox.Show("Thêm Ca học thành công!");
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ShiftDayObjects objShiftDay = new ShiftDayObjects
            {                
                ShiftName = txtTenCaHoc.Text,
                Description = txtMota.Text
            };
            ShiftDayBCL mShiftDayBCL = new ShiftDayBCL();
            mShiftDayBCL.Update(objShiftDay);
            MessageBox.Show("Cập nhật Ca học thành công!");
            Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}