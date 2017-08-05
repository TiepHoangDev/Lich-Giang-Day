﻿namespace QL_LICHGIANGDAY.UserControll
{
    partial class UcStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucBaseControl1 = new QL_LICHGIANGDAY.UserControll.UcBaseControl();
            this.grcStudent = new DevExpress.XtraGrid.GridControl();
            this.grvStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseControl1
            // 
            this.ucBaseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseControl1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseControl1.Name = "ucBaseControl1";
            this.ucBaseControl1.Size = new System.Drawing.Size(725, 65);
            this.ucBaseControl1.TabIndex = 0;
            // 
            // grcStudent
            // 
            this.grcStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcStudent.Location = new System.Drawing.Point(0, 65);
            this.grcStudent.MainView = this.grvStudent;
            this.grcStudent.Name = "grcStudent";
            this.grcStudent.Size = new System.Drawing.Size(725, 363);
            this.grcStudent.TabIndex = 1;
            this.grcStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvStudent});
            // 
            // grvStudent
            // 
            this.grvStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FullName,
            this.Email,
            this.Mobile,
            this.Address,
            this.Status});
            this.grvStudent.GridControl = this.grcStudent;
            this.grvStudent.Name = "grvStudent";
            this.grvStudent.OptionsBehavior.Editable = false;
            this.grvStudent.OptionsBehavior.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.Caption = "Họ và Tên";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 0;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 1;
            // 
            // Mobile
            // 
            this.Mobile.Caption = "Mobile";
            this.Mobile.FieldName = "Mobile";
            this.Mobile.Name = "Mobile";
            this.Mobile.Visible = true;
            this.Mobile.VisibleIndex = 2;
            // 
            // Address
            // 
            this.Address.Caption = "Địa chỉ";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 3;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 4;
            // 
            // UcStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcStudent);
            this.Controls.Add(this.ucBaseControl1);
            this.Name = "UcStudent";
            this.Size = new System.Drawing.Size(725, 428);
            this.Load += new System.EventHandler(this.UcStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcBaseControl ucBaseControl1;
        private DevExpress.XtraGrid.GridControl grcStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView grvStudent;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Mobile;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
    }
}
