﻿namespace QL_LICHGIANGDAY.UserForm.SchedStudentDetailt
{
    partial class UsEditSchedStudentDetailt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsEditSchedStudentDetailt));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditStudentID = new DevExpress.XtraEditors.LookUpEdit();
            this.rtbDescription = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.schedulersObjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStudentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulersObjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.lookUpEditStudentID);
            this.groupControl1.Controls.Add(this.rtbDescription);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnInsert);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(413, 322);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Sửa thông tin chi tiết học viên vắng mặt: ";
            // 
            // lookUpEditStudentID
            // 
            this.lookUpEditStudentID.Location = new System.Drawing.Point(108, 58);
            this.lookUpEditStudentID.Name = "lookUpEditStudentID";
            this.lookUpEditStudentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStudentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Name18")});
            this.lookUpEditStudentID.Properties.DisplayMember = "FullName";
            this.lookUpEditStudentID.Properties.NullText = "-----------------Chọn một học viên-----------------";
            this.lookUpEditStudentID.Properties.ValueMember = "StudetId";
            this.lookUpEditStudentID.Size = new System.Drawing.Size(256, 20);
            this.lookUpEditStudentID.TabIndex = 35;
            // 
            // rtbDescription
            // 
            this.rtbDescription.EnableToolTips = true;
            this.rtbDescription.Location = new System.Drawing.Point(108, 84);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Options.CopyPaste.MaintainDocumentSectionSettings = false;
            this.rtbDescription.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.rtbDescription.Options.MailMerge.KeepLastParagraph = false;
            this.rtbDescription.Size = new System.Drawing.Size(256, 142);
            this.rtbDescription.TabIndex = 34;
            this.rtbDescription.Text = " ";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(223, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 43);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Hủy";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(62, 262);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(127, 43);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.Text = "Sửa";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "- Miêu tả: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "- Học viên: ";
            // 
            // schedulersObjectsBindingSource
            // 
            this.schedulersObjectsBindingSource.DataSource = typeof(BUSINESS_OBJECT.Objects.SchedulersObjects);
            // 
            // UsEditSchedStudentDetailt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 322);
            this.Controls.Add(this.groupControl1);
            this.Name = "UsEditSchedStudentDetailt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỈNH SỬA HỌC SINH VẮNG MẶT";
            this.Load += new System.EventHandler(this.UsEditSchedStudentDetailt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStudentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulersObjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStudentID;
        private DevExpress.XtraRichEdit.RichEditControl rtbDescription;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource schedulersObjectsBindingSource;

    }
}