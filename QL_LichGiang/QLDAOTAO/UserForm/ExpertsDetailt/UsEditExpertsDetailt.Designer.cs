﻿namespace QL_LICHGIANGDAY.UserForm.ExpertsDetailt
{
    partial class UsEditExpertsDetailt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsEditExpertsDetailt));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sluMaKhoaHoc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.grdMaKhoaHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sluMaChuyenGia = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.grdChuyenGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ExpertId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sluMaKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaKhoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluMaChuyenGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdChuyenGia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.sluMaKhoaHoc);
            this.groupControl1.Controls.Add(this.sluMaChuyenGia);
            this.groupControl1.Controls.Add(this.txtMota);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(425, 348);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Sửa thông tin chi tiết chuyên gia: ";
            this.groupControl1.Enter += new System.EventHandler(this.groupControl1_Enter);
            // 
            // sluMaKhoaHoc
            // 
            this.sluMaKhoaHoc.Location = new System.Drawing.Point(103, 86);
            this.sluMaKhoaHoc.Name = "sluMaKhoaHoc";
            this.sluMaKhoaHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sluMaKhoaHoc.Properties.DisplayMember = "CourseName";
            this.sluMaKhoaHoc.Properties.NullText = "";
            this.sluMaKhoaHoc.Properties.ValueMember = "CoId";
            this.sluMaKhoaHoc.Properties.View = this.grdMaKhoaHoc;
            this.sluMaKhoaHoc.Size = new System.Drawing.Size(310, 20);
            this.sluMaKhoaHoc.TabIndex = 1;
            // 
            // grdMaKhoaHoc
            // 
            this.grdMaKhoaHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CoId,
            this.CourseName});
            this.grdMaKhoaHoc.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdMaKhoaHoc.Name = "grdMaKhoaHoc";
            this.grdMaKhoaHoc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdMaKhoaHoc.OptionsView.ShowGroupPanel = false;
            // 
            // CoId
            // 
            this.CoId.Caption = "Mã Khóa Học";
            this.CoId.FieldName = "CoId";
            this.CoId.Name = "CoId";
            this.CoId.Visible = true;
            this.CoId.VisibleIndex = 0;
            // 
            // CourseName
            // 
            this.CourseName.Caption = "Tên Khóa Học";
            this.CourseName.FieldName = "CourseName";
            this.CourseName.Name = "CourseName";
            this.CourseName.Visible = true;
            this.CourseName.VisibleIndex = 1;
            // 
            // sluMaChuyenGia
            // 
            this.sluMaChuyenGia.EditValue = "";
            this.sluMaChuyenGia.Location = new System.Drawing.Point(103, 55);
            this.sluMaChuyenGia.Name = "sluMaChuyenGia";
            this.sluMaChuyenGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sluMaChuyenGia.Properties.DisplayMember = "FullName";
            this.sluMaChuyenGia.Properties.NullText = "";
            this.sluMaChuyenGia.Properties.ValueMember = "ExpertId";
            this.sluMaChuyenGia.Properties.View = this.grdChuyenGia;
            this.sluMaChuyenGia.Size = new System.Drawing.Size(310, 20);
            this.sluMaChuyenGia.TabIndex = 0;
            // 
            // grdChuyenGia
            // 
            this.grdChuyenGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ExpertId,
            this.FullName});
            this.grdChuyenGia.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdChuyenGia.Name = "grdChuyenGia";
            this.grdChuyenGia.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdChuyenGia.OptionsView.ShowGroupPanel = false;
            // 
            // ExpertId
            // 
            this.ExpertId.Caption = "Mã Chuyên Gia";
            this.ExpertId.FieldName = "ExpertId";
            this.ExpertId.Name = "ExpertId";
            this.ExpertId.Visible = true;
            this.ExpertId.VisibleIndex = 0;
            // 
            // FullName
            // 
            this.FullName.Caption = "Tên Chuyên Gia";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(103, 114);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(310, 131);
            this.txtMota.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(285, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Hủy";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(134, 268);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 43);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "- Mô tả: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "- Khóa học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "- Chuyên gia: ";
            // 
            // UsEditExpertsDetailt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 348);
            this.Controls.Add(this.groupControl1);
            this.Name = "UsEditExpertsDetailt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA CHI TIẾT CHUYÊN GIA";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sluMaKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaKhoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluMaChuyenGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdChuyenGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtMota;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SearchLookUpEdit sluMaKhoaHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView grdMaKhoaHoc;
        private DevExpress.XtraEditors.SearchLookUpEdit sluMaChuyenGia;
        private DevExpress.XtraGrid.Views.Grid.GridView grdChuyenGia;
        private DevExpress.XtraGrid.Columns.GridColumn CoId;
        private DevExpress.XtraGrid.Columns.GridColumn CourseName;
        private DevExpress.XtraGrid.Columns.GridColumn ExpertId;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;

    }
}