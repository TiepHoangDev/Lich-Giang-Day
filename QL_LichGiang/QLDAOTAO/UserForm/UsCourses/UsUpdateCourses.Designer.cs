﻿namespace QL_LICHGIANGDAY.UserForm.UsCourses
{
    partial class UsUpdateCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsUpdateCourses));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lblDepcription = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStatusTime = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.rECDepcription = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.DtimeEndTime = new DevExpress.XtraEditors.DateEdit();
            this.DtimeStatusTime = new DevExpress.XtraEditors.DateEdit();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeEndTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeStatusTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeStatusTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.cbStatus);
            this.groupControl1.Controls.Add(this.lblDepcription);
            this.groupControl1.Controls.Add(this.lblEndTime);
            this.groupControl1.Controls.Add(this.lblStatusTime);
            this.groupControl1.Controls.Add(this.lblNumber);
            this.groupControl1.Controls.Add(this.labName);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.num);
            this.groupControl1.Controls.Add(this.rECDepcription);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.DtimeEndTime);
            this.groupControl1.Controls.Add(this.DtimeStatusTime);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtMKH);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(452, 542);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Cập nhật thông tin cho khóa học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "+ Đã bắt đầu học: ";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(128, 273);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(139, 17);
            this.cbStatus.TabIndex = 46;
            this.cbStatus.Text = "Bắt đầu / Chưa bắt đầu";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // lblDepcription
            // 
            this.lblDepcription.AutoSize = true;
            this.lblDepcription.Location = new System.Drawing.Point(8, 310);
            this.lblDepcription.Name = "lblDepcription";
            this.lblDepcription.Size = new System.Drawing.Size(82, 13);
            this.lblDepcription.TabIndex = 20;
            this.lblDepcription.Text = "+  Mô tả ngắn :";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(5, 234);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(113, 13);
            this.lblEndTime.TabIndex = 21;
            this.lblEndTime.Text = "+ Thời gian kết thúc  :";
            // 
            // lblStatusTime
            // 
            this.lblStatusTime.AutoSize = true;
            this.lblStatusTime.Location = new System.Drawing.Point(5, 200);
            this.lblStatusTime.Name = "lblStatusTime";
            this.lblStatusTime.Size = new System.Drawing.Size(108, 13);
            this.lblStatusTime.TabIndex = 22;
            this.lblStatusTime.Text = "+ Thời gian bắt đầu :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(5, 164);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(106, 13);
            this.lblNumber.TabIndex = 23;
            this.lblNumber.Text = "+ Tổng số học viên :";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(5, 129);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(89, 13);
            this.labName.TabIndex = 24;
            this.labName.Text = "+ Tên khóa học :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "+ Khóa học :";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(128, 162);
            this.num.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(293, 21);
            this.num.TabIndex = 19;
            // 
            // rECDepcription
            // 
            this.rECDepcription.EnableToolTips = true;
            this.rECDepcription.Location = new System.Drawing.Point(128, 310);
            this.rECDepcription.Name = "rECDepcription";
            this.rECDepcription.Options.CopyPaste.MaintainDocumentSectionSettings = false;
            this.rECDepcription.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.rECDepcription.Options.MailMerge.KeepLastParagraph = false;
            this.rECDepcription.Size = new System.Drawing.Size(293, 179);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(115, 495);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Cập nhật ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DtimeEndTime
            // 
            this.DtimeEndTime.EditValue = null;
            this.DtimeEndTime.Location = new System.Drawing.Point(128, 231);
            this.DtimeEndTime.Name = "DtimeEndTime";
            this.DtimeEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtimeEndTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtimeEndTime.Size = new System.Drawing.Size(293, 20);
            this.DtimeEndTime.TabIndex = 3;
            // 
            // DtimeStatusTime
            // 
            this.DtimeStatusTime.EditValue = null;
            this.DtimeStatusTime.Location = new System.Drawing.Point(128, 197);
            this.DtimeStatusTime.Name = "DtimeStatusTime";
            this.DtimeStatusTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtimeStatusTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtimeStatusTime.Size = new System.Drawing.Size(293, 20);
            this.DtimeStatusTime.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(293, 21);
            this.txtName.TabIndex = 2;
            // 
            // txtMKH
            // 
            this.txtMKH.Location = new System.Drawing.Point(128, 91);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(293, 21);
            this.txtMKH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Vui lòng chọn đối tượng cần Cập Nhật lại thông tin từ \"Danh sách vừa thêm mới\"." +
    "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsUpdateCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 542);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UsUpdateCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT KHÓA HỌC";
            this.Load += new System.EventHandler(this.UsUpdateCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeEndTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeStatusTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtimeStatusTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit DtimeEndTime;
        private DevExpress.XtraEditors.DateEdit DtimeStatusTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMKH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraRichEdit.RichEditControl rECDepcription;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblDepcription;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStatusTime;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbStatus;
    }
}