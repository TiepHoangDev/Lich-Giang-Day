﻿namespace QL_LICHGIANGDAY.UserControll
{
    partial class UcWeekdaysDao
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
            this.grcWeekdaysDao = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.WeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcWeekdaysDao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseControl1
            // 
            this.ucBaseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseControl1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseControl1.Name = "ucBaseControl1";
            this.ucBaseControl1.Size = new System.Drawing.Size(636, 65);
            this.ucBaseControl1.TabIndex = 0;
            // 
            // grcWeekdaysDao
            // 
            this.grcWeekdaysDao.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcWeekdaysDao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcWeekdaysDao.Location = new System.Drawing.Point(0, 65);
            this.grcWeekdaysDao.MainView = this.cardView1;
            this.grcWeekdaysDao.Name = "grcWeekdaysDao";
            this.grcWeekdaysDao.Size = new System.Drawing.Size(636, 352);
            this.grcWeekdaysDao.TabIndex = 1;
            this.grcWeekdaysDao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WeName,
            this.Description});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.grcWeekdaysDao;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.ReadOnly = true;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // WeName
            // 
            this.WeName.Caption = "Tên Thứ ";
            this.WeName.FieldName = "WeName";
            this.WeName.Name = "WeName";
            this.WeName.Visible = true;
            this.WeName.VisibleIndex = 0;
            // 
            // Description
            // 
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 1;
            // 
            // UcWeekdaysDao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcWeekdaysDao);
            this.Controls.Add(this.ucBaseControl1);
            this.Name = "UcWeekdaysDao";
            this.Size = new System.Drawing.Size(636, 417);
            this.Load += new System.EventHandler(this.UcWeekdaysDao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcWeekdaysDao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcBaseControl ucBaseControl1;
        private DevExpress.XtraGrid.GridControl grcWeekdaysDao;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn WeName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
    }
}
