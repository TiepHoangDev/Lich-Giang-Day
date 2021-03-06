﻿namespace QL_LICHGIANGDAY.UserControll
{
    partial class UcSchedulers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSchedulers));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ucBaseControl1 = new QL_LICHGIANGDAY.UserControll.UcBaseControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.coursesObjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uluCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grcSchedulers = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.WeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShiftId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesObjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluCourse)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcSchedulers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseControl1
            // 
            this.ucBaseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseControl1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseControl1.Name = "ucBaseControl1";
            this.ucBaseControl1.Size = new System.Drawing.Size(652, 65);
            this.ucBaseControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchLookUpEdit1);
            this.panel1.Controls.Add(this.lblGiangVien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 33);
            this.panel1.TabIndex = 1;
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.EditValue = "TotalNumber";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(81, 6);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.coursesObjectsBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "CourseName";
            this.searchLookUpEdit1.Properties.NullText = "---------Chọn một lớp học---------";
            this.searchLookUpEdit1.Properties.ValueMember = "CoId";
            this.searchLookUpEdit1.Properties.View = this.uluCourse;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(175, 20);
            this.searchLookUpEdit1.TabIndex = 2;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // coursesObjectsBindingSource
            // 
            this.coursesObjectsBindingSource.DataSource = typeof(BUSINESS_OBJECT.Objects.CoursesObjects);
            // 
            // uluCourse
            // 
            this.uluCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.uluCourse.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.uluCourse.Name = "uluCourse";
            this.uluCourse.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.uluCourse.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên lớp";
            this.gridColumn2.FieldName = "CourseName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số học viên";
            this.gridColumn3.FieldName = "TotalNumber";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Status";
            this.gridColumn4.FieldName = "Status";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Location = new System.Drawing.Point(359, 9);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(73, 13);
            this.lblGiangVien.TabIndex = 0;
            this.lblGiangVien.Text = "+ Giảng viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "+ Giảng viên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "+ Lớp học: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grcSchedulers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 298);
            this.panel2.TabIndex = 1;
            // 
            // grcSchedulers
            // 
            this.grcSchedulers.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcSchedulers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcSchedulers.Location = new System.Drawing.Point(0, 0);
            this.grcSchedulers.MainView = this.cardView1;
            this.grcSchedulers.Name = "grcSchedulers";
            this.grcSchedulers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDetail});
            this.grcSchedulers.Size = new System.Drawing.Size(652, 298);
            this.grcSchedulers.TabIndex = 2;
            this.grcSchedulers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.grcSchedulers.Load += new System.EventHandler(this.grcSchedulers_Load);
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WeId,
            this.ShiftId,
            this.CoId,
            this.Description,
            this.gridColumn1});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.grcSchedulers;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // WeId
            // 
            this.WeId.Caption = "Thời gian";
            this.WeId.FieldName = "WeekdaysJoin.WeName";
            this.WeId.Name = "WeId";
            this.WeId.OptionsColumn.ReadOnly = true;
            this.WeId.Visible = true;
            this.WeId.VisibleIndex = 0;
            // 
            // ShiftId
            // 
            this.ShiftId.Caption = "Ca";
            this.ShiftId.FieldName = "ShiftDayJoin.ShiftName";
            this.ShiftId.Name = "ShiftId";
            this.ShiftId.OptionsColumn.ReadOnly = true;
            this.ShiftId.Visible = true;
            this.ShiftId.VisibleIndex = 1;
            // 
            // CoId
            // 
            this.CoId.Caption = "Khóa học";
            this.CoId.FieldName = "CoursesJoin.CourseName";
            this.CoId.Name = "CoId";
            this.CoId.OptionsColumn.ReadOnly = true;
            this.CoId.Visible = true;
            this.CoId.VisibleIndex = 2;
            // 
            // Description
            // 
            this.Description.Caption = "Miêu tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.OptionsColumn.ReadOnly = true;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Xem chi tiết";
            this.gridColumn1.ColumnEdit = this.btnDetail;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // btnDetail
            // 
            this.btnDetail.AutoHeight = false;
            this.btnDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDetail.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã lớp";
            this.gridColumn5.FieldName = "CourseId";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // UcSchedulers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucBaseControl1);
            this.Name = "UcSchedulers";
            this.Size = new System.Drawing.Size(652, 396);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesObjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluCourse)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcSchedulers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcBaseControl ucBaseControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView uluCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl grcSchedulers;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn WeId;
        private DevExpress.XtraGrid.Columns.GridColumn ShiftId;
        private DevExpress.XtraGrid.Columns.GridColumn CoId;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetail;
        private System.Windows.Forms.BindingSource coursesObjectsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
