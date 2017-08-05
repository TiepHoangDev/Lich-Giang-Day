﻿namespace QL_LICHGIANGDAY.UserControll
{
    partial class UcStudentDetailt
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
            this.grcStudentDetailt = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.StudetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uluMaHV = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uluMKhoaHoc = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uluMaKhoaHoc = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.uluMaKH = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grcStudentDetailt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluMaHV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluMKhoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluMaKhoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluMaKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            // grcStudentDetailt
            // 
            this.grcStudentDetailt.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcStudentDetailt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcStudentDetailt.Location = new System.Drawing.Point(0, 65);
            this.grcStudentDetailt.MainView = this.cardView1;
            this.grcStudentDetailt.Name = "grcStudentDetailt";
            this.grcStudentDetailt.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.uluMaHV,
            this.uluMaKhoaHoc,
            this.uluMaKH,
            this.repositoryItemSearchLookUpEdit1,
            this.uluMKhoaHoc});
            this.grcStudentDetailt.Size = new System.Drawing.Size(680, 345);
            this.grcStudentDetailt.TabIndex = 1;
            this.grcStudentDetailt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StudetId,
            this.CoId,
            this.Description});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.grcStudentDetailt;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.ReadOnly = true;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // StudetId
            // 
            this.StudetId.Caption = "Mã Học Viên";
            this.StudetId.ColumnEdit = this.uluMaHV;
            this.StudetId.FieldName = "StudetId";
            this.StudetId.Name = "StudetId";
            this.StudetId.Visible = true;
            this.StudetId.VisibleIndex = 0;
            // 
            // uluMaHV
            // 
            this.uluMaHV.AutoHeight = false;
            this.uluMaHV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uluMaHV.DisplayMember = "FullName";
            this.uluMaHV.Name = "uluMaHV";
            this.uluMaHV.NullText = "";
            this.uluMaHV.ValueMember = "StudetId";
            this.uluMaHV.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.FullName});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Học Viên";
            this.gridColumn1.FieldName = "StudetId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // FullName
            // 
            this.FullName.Caption = "Tên Học Viên";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            // 
            // CoId
            // 
            this.CoId.Caption = "Mã Khóa Học";
            this.CoId.ColumnEdit = this.uluMKhoaHoc;
            this.CoId.FieldName = "CoId";
            this.CoId.Name = "CoId";
            this.CoId.Visible = true;
            this.CoId.VisibleIndex = 1;
            // 
            // uluMKhoaHoc
            // 
            this.uluMKhoaHoc.AutoHeight = false;
            this.uluMKhoaHoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uluMKhoaHoc.DisplayMember = "CourseName";
            this.uluMKhoaHoc.Name = "uluMKhoaHoc";
            this.uluMKhoaHoc.ValueMember = "CoId";
            this.uluMKhoaHoc.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKhoaHoc,
            this.TenKhoaHoc});
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // MaKhoaHoc
            // 
            this.MaKhoaHoc.Caption = "Mã Khóa Học";
            this.MaKhoaHoc.FieldName = "CoId";
            this.MaKhoaHoc.Name = "MaKhoaHoc";
            this.MaKhoaHoc.Visible = true;
            this.MaKhoaHoc.VisibleIndex = 0;
            // 
            // TenKhoaHoc
            // 
            this.TenKhoaHoc.Caption = "Tên Khóa Học";
            this.TenKhoaHoc.FieldName = "CourseName";
            this.TenKhoaHoc.Name = "TenKhoaHoc";
            this.TenKhoaHoc.Visible = true;
            this.TenKhoaHoc.VisibleIndex = 1;
            // 
            // Description
            // 
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 2;
            // 
            // uluMaKhoaHoc
            // 
            this.uluMaKhoaHoc.AutoHeight = false;
            this.uluMaKhoaHoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uluMaKhoaHoc.DisplayMember = "CourseName";
            this.uluMaKhoaHoc.Name = "uluMaKhoaHoc";
            this.uluMaKhoaHoc.NullText = "";
            this.uluMaKhoaHoc.ValueMember = "CoId";
            this.uluMaKhoaHoc.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // uluMaKH
            // 
            this.uluMaKH.AutoHeight = false;
            this.uluMaKH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uluMaKH.DisplayMember = "CourseName";
            this.uluMaKH.Name = "uluMaKH";
            this.uluMaKH.ValueMember = "CoId";
            this.uluMaKH.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Khóa Học";
            this.gridColumn2.FieldName = "CoId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Khóa Học";
            this.gridColumn3.FieldName = "CourseName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // UcStudentDetailt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcStudentDetailt);
            this.Controls.Add(this.ucBaseControl1);
            this.Name = "UcStudentDetailt";
            this.Size = new System.Drawing.Size(680, 410);
            this.Load += new System.EventHandler(this.UcStudentDetailt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcStudentDetailt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluMaHV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluMKhoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluMaKhoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluMaKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcBaseControl ucBaseControl1;
        private DevExpress.XtraGrid.GridControl grcStudentDetailt;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit uluMaHV;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit uluMaKhoaHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit uluMaKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit uluMKhoaHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhoaHoc;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn StudetId;
        private DevExpress.XtraGrid.Columns.GridColumn CoId;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
    }
}
