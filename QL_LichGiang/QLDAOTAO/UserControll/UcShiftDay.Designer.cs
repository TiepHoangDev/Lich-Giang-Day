﻿namespace QL_LICHGIANGDAY.UserControll
{
    partial class UcShiftDay
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
            this.grcShiftDay = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.ShiftName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcShiftDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseControl1
            // 
            this.ucBaseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseControl1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseControl1.Name = "ucBaseControl1";
            this.ucBaseControl1.Size = new System.Drawing.Size(671, 65);
            this.ucBaseControl1.TabIndex = 0;
            // 
            // grcShiftDay
            // 
            this.grcShiftDay.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcShiftDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcShiftDay.Location = new System.Drawing.Point(0, 65);
            this.grcShiftDay.MainView = this.cardView1;
            this.grcShiftDay.Name = "grcShiftDay";
            this.grcShiftDay.Size = new System.Drawing.Size(671, 352);
            this.grcShiftDay.TabIndex = 1;
            this.grcShiftDay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.grcShiftDay.Load += new System.EventHandler(this.grcShiftDay_Load);
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ShiftName,
            this.Description});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.grcShiftDay;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.ReadOnly = true;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // ShiftName
            // 
            this.ShiftName.Caption = "Tên ca học";
            this.ShiftName.FieldName = "ShiftName";
            this.ShiftName.Name = "ShiftName";
            this.ShiftName.Visible = true;
            this.ShiftName.VisibleIndex = 0;
            // 
            // Description
            // 
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 1;
            // 
            // UcShiftDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcShiftDay);
            this.Controls.Add(this.ucBaseControl1);
            this.Name = "UcShiftDay";
            this.Size = new System.Drawing.Size(671, 417);
            ((System.ComponentModel.ISupportInitialize)(this.grcShiftDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcBaseControl ucBaseControl1;
        private DevExpress.XtraGrid.GridControl grcShiftDay;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn ShiftName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
    }
}
