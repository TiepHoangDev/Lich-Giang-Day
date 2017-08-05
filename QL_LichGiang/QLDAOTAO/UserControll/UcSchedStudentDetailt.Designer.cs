namespace QL_LICHGIANGDAY.UserControll
{
    partial class UcSchedStudentDetailt
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
            this.grcSchedStudentDetailt = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcSchedStudentDetailt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseControl1
            // 
            this.ucBaseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseControl1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseControl1.Name = "ucBaseControl1";
            this.ucBaseControl1.Size = new System.Drawing.Size(680, 65);
            this.ucBaseControl1.TabIndex = 0;
            // 
            // grcSchedStudentDetailt
            // 
            this.grcSchedStudentDetailt.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcSchedStudentDetailt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcSchedStudentDetailt.Location = new System.Drawing.Point(0, 65);
            this.grcSchedStudentDetailt.MainView = this.cardView1;
            this.grcSchedStudentDetailt.Name = "grcSchedStudentDetailt";
            this.grcSchedStudentDetailt.Size = new System.Drawing.Size(680, 343);
            this.grcSchedStudentDetailt.TabIndex = 1;
            this.grcSchedStudentDetailt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.grcSchedStudentDetailt.Load += new System.EventHandler(this.grcSchedStudentDetailt_Load);
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.grcSchedStudentDetailt;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.ReadOnly = true;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Học sinh";
            this.gridColumn8.FieldName = "StudentJoin.FullName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Ghi chú";
            this.gridColumn9.FieldName = "Description";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // UcSchedStudentDetailt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcSchedStudentDetailt);
            this.Controls.Add(this.ucBaseControl1);
            this.Name = "UcSchedStudentDetailt";
            this.Size = new System.Drawing.Size(680, 408);
            ((System.ComponentModel.ISupportInitialize)(this.grcSchedStudentDetailt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcBaseControl ucBaseControl1;
        private DevExpress.XtraGrid.GridControl grcSchedStudentDetailt;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}
