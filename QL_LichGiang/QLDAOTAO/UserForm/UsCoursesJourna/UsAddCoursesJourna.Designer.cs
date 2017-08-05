﻿namespace QL_LICHGIANGDAY.UserForm.UsCoursesJourna
{
    partial class UsAddCoursesJourna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsAddCoursesJourna));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.uluMKH = new DevExpress.XtraEditors.LookUpEdit();
            this.rEContent = new DevExpress.XtraRichEdit.RichEditControl();
            this.label8 = new System.Windows.Forms.Label();
            this.rECDepcription = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtimeStatusTime = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uluMKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeStatusTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeStatusTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.uluMKH);
            this.groupControl1.Controls.Add(this.rEContent);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.rECDepcription);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnInsert);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.DtimeStatusTime);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(469, 540);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thêm mới thông tin cho khóa học";
            // 
            // uluMKH
            // 
            this.uluMKH.Location = new System.Drawing.Point(115, 94);
            this.uluMKH.Name = "uluMKH";
            this.uluMKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uluMKH.Properties.Appearance.Options.UseFont = true;
            this.uluMKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uluMKH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", 150, "Tên khóa học"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CoId", 150, "Mã khóa học")});
            this.uluMKH.Properties.DisplayMember = "CourseName";
            this.uluMKH.Properties.NullText = "          --------- CHỌN MÃ KHÓA HỌC --------";
            this.uluMKH.Properties.ValueMember = "CoId";
            this.uluMKH.Size = new System.Drawing.Size(318, 22);
            this.uluMKH.TabIndex = 19;
            // 
            // rEContent
            // 
            this.rEContent.EnableToolTips = true;
            this.rEContent.Location = new System.Drawing.Point(115, 164);
            this.rEContent.Name = "rEContent";
            this.rEContent.Options.CopyPaste.MaintainDocumentSectionSettings = false;
            this.rEContent.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.rEContent.Options.MailMerge.KeepLastParagraph = false;
            this.rEContent.Size = new System.Drawing.Size(318, 135);
            this.rEContent.TabIndex = 18;
            this.rEContent.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "+  Mô tả ngắn :";
            // 
            // rECDepcription
            // 
            this.rECDepcription.EnableToolTips = true;
            this.rECDepcription.Location = new System.Drawing.Point(115, 317);
            this.rECDepcription.Name = "rECDepcription";
            this.rECDepcription.Options.CopyPaste.MaintainDocumentSectionSettings = false;
            this.rECDepcription.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.rECDepcription.Options.MailMerge.KeepLastParagraph = false;
            this.rECDepcription.Size = new System.Drawing.Size(318, 164);
            this.rECDepcription.TabIndex = 16;
            this.rECDepcription.Text = " ";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(301, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 35);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Đóng";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnInsert
            // 
            this.btnInsert.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInsert.Appearance.Options.UseFont = true;
            this.btnInsert.Appearance.Options.UseForeColor = true;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(115, 495);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 35);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Thêm mới";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "+ Nội dung :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "+  Ngày giảng dạy :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "+ Mã khóa học :";
            // 
            // DtimeStatusTime
            // 
            this.DtimeStatusTime.EditValue = null;
            this.DtimeStatusTime.Location = new System.Drawing.Point(115, 126);
            this.DtimeStatusTime.Name = "DtimeStatusTime";
            this.DtimeStatusTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtimeStatusTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtimeStatusTime.Size = new System.Drawing.Size(318, 20);
            this.DtimeStatusTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Vui lòng chọn đối tượng cần Thêm Mới  từ thông tin \" Danh sách nhật ký giảng dạ" +
    "y \".";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsAddCoursesJourna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(469, 540);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UsAddCoursesJourna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM NHẬT KÝ GIẢNG DẠY";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uluMKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeStatusTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeStatusTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private DevExpress.XtraRichEdit.RichEditControl rECDepcription;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit DtimeStatusTime;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraRichEdit.RichEditControl rEContent;
        private DevExpress.XtraEditors.LookUpEdit uluMKH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}