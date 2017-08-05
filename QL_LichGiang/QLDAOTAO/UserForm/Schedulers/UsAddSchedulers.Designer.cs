﻿namespace QL_LICHGIANGDAY.UserForm.Schedulers
{
    partial class UsAddSchedulers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsAddSchedulers));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditCourseID = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditShiftID = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditWeekDayID = new DevExpress.XtraEditors.LookUpEdit();
            this.rtbDescription = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCourseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditShiftID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWeekDayID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.lookUpEditCourseID);
            this.groupControl1.Controls.Add(this.lookUpEditShiftID);
            this.groupControl1.Controls.Add(this.lookUpEditWeekDayID);
            this.groupControl1.Controls.Add(this.rtbDescription);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnInsert);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(399, 366);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thêm thông tin lịch học:";
            // 
            // lookUpEditCourseID
            // 
            this.lookUpEditCourseID.Location = new System.Drawing.Point(108, 110);
            this.lookUpEditCourseID.Name = "lookUpEditCourseID";
            this.lookUpEditCourseID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCourseID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Khóa học")});
            this.lookUpEditCourseID.Properties.DisplayMember = "CourseName";
            this.lookUpEditCourseID.Properties.NullText = "-------------- Chọn một khóa học--------------";
            this.lookUpEditCourseID.Properties.ValueMember = "CoId";
            this.lookUpEditCourseID.Size = new System.Drawing.Size(256, 20);
            this.lookUpEditCourseID.TabIndex = 39;
            // 
            // lookUpEditShiftID
            // 
            this.lookUpEditShiftID.Location = new System.Drawing.Point(108, 84);
            this.lookUpEditShiftID.Name = "lookUpEditShiftID";
            this.lookUpEditShiftID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditShiftID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftName", "Ca")});
            this.lookUpEditShiftID.Properties.DisplayMember = "ShiftName";
            this.lookUpEditShiftID.Properties.NullText = "-------------- Chọn một ca học --------------";
            this.lookUpEditShiftID.Properties.ValueMember = "ShiftId";
            this.lookUpEditShiftID.Size = new System.Drawing.Size(256, 20);
            this.lookUpEditShiftID.TabIndex = 40;
            // 
            // lookUpEditWeekDayID
            // 
            this.lookUpEditWeekDayID.Location = new System.Drawing.Point(108, 58);
            this.lookUpEditWeekDayID.Name = "lookUpEditWeekDayID";
            this.lookUpEditWeekDayID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditWeekDayID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WeName", "Thời gian")});
            this.lookUpEditWeekDayID.Properties.DisplayMember = "WeName";
            this.lookUpEditWeekDayID.Properties.NullText = "--------------Chọn thời gian học--------------";
            this.lookUpEditWeekDayID.Properties.ValueMember = "WeId";
            this.lookUpEditWeekDayID.Size = new System.Drawing.Size(256, 20);
            this.lookUpEditWeekDayID.TabIndex = 41;
            // 
            // rtbDescription
            // 
            this.rtbDescription.EnableToolTips = true;
            this.rtbDescription.Location = new System.Drawing.Point(108, 136);
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
            this.btnExit.Location = new System.Drawing.Point(243, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 43);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Hủy";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(116, 295);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 43);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "- Miêu tả: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "- Khóa học: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "- Ca: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "- Thời gian: ";
            // 
            // UsAddSchedulers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 366);
            this.Controls.Add(this.groupControl1);
            this.Name = "UsAddSchedulers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM LỊCH HỌC";
            this.Load += new System.EventHandler(this.UsAddSchedulers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCourseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditShiftID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWeekDayID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraRichEdit.RichEditControl rtbDescription;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCourseID;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditShiftID;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditWeekDayID;
    }
}