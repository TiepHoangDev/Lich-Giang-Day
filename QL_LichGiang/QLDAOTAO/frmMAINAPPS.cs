﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BUSINESS_LOGIC_LAYER.BCL;
using BUSINESS_OBJECT.Objects;

// ------ THEME -----------------------------------------------------------// 

//1. Khai báo không gian thư viện (dùng cho Theme)
using DevExpress.XtraBars.Localization;
using DevExpress.XtraBars.Helpers;

// ------ THEME -----------------------------------------------------------// 

// ------ XTRATABCONTROL -----------------------------------------------------------// 

//1. Khai báo không gian tên sử dụng cho xTraTabControl
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraNavBar;

// ------ XTRATABCONTROL -----------------------------------------------------------// 


namespace QL_LICHGIANGDAY
{
    public partial class frmMAINAPPS : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //2. Khai báo đối tượng của XtraTabPage
        private XtraTabPage xtraTab_Cousrses;//khóa học
        private XtraTabPage Xtra_CoursesJournal;//nhật ký giảng dạy
        private XtraTabPage Xtra_Experts;//chuyên gia
        private XtraTabPage Xtra_ExpertsDetailt;//chi tiết chuyên gia
        private XtraTabPage Xtra_Student;//học viên
        private XtraTabPage Xtra_StudentDetailt;//chi tiết học viên
        private XtraTabPage Xtra_ShiftDay;//ca học
        private XtraTabPage Xtra_Weekdays;//thứ trong tuần
        private XtraTabPage Xtra_Schedulers;//lịch giảng dạy
        private XtraTabPage Xtra_Permisstion;//phân quyền
        private XtraTabPage Xtra_Account;// User
        private XtraTabPage Xtra_SchedStudentDetailt;//chi tiết lịch
        private AccountObject m_objAccountObject;// Cac Account
        private List<PermisstionObject> m_lisPer;// PermisstionObject
        public frmMAINAPPS()
        {
            InitializeComponent();
            //3. Khởi tạo đối tượng XTRATAB
            xtraTab_Cousrses = new XtraTabPage();//ExtraTab Khóa học
            Xtra_CoursesJournal = new XtraTabPage();//Nhật ký giảng dạy
            Xtra_Experts = new XtraTabPage();//chuyên gia
            Xtra_ExpertsDetailt = new XtraTabPage();//chi tiết chuyên gia
            Xtra_Student = new XtraTabPage();//học viên
            Xtra_StudentDetailt = new XtraTabPage();//chi tiết học viên
            Xtra_ShiftDay = new XtraTabPage();//ca học
            Xtra_Weekdays = new XtraTabPage();//thứ trong tuần
            Xtra_Schedulers = new XtraTabPage();//lịch giảng dạy
            Xtra_SchedStudentDetailt = new XtraTabPage();//chi tiết lịch
            Xtra_Permisstion = new XtraTabPage();//phân quyền.
            Xtra_Account = new XtraTabPage();// User
            m_objAccountObject = new AccountObject();
            m_lisPer = new List<PermisstionObject>();
        }

        //RoleId
        //+ SuperAdmin: c842ca2f-f6bd-4b83-a3c0-594be24e0117
        //+ User: c6d5b4a2-c958-4828-a587-6c052ea5f4c9
        //+ Guest: adae8847-5b4d-43fc-a761-038b315d7651
        //+SupperSuperAdmin: 7e86a93e-6070-4487-836d-81b88cf1e669

        //FeatureId
        //+ QLCG : Quản Lý Chuyên Gia
        //+ QLHV : Quản Lý Học Viên
        //+ QLKH: Quản Lý Khóa Học

        // ------ THEME -----------------------------------------------------------// 
        //2. Thiết lập tùy biến giao diện Theme
        public class MyBarLocalizer : BarLocalizer //Theme
        {
            public override string GetLocalizedString(BarString id)
            {
                if (id == BarString.SkinCaptions)
                {
                    //Default value for BarString.SkinCaptions:                    
                    //"|DevExpress Style|Caramel|Money Twins|DevExpress Dark Style|iMaginary|Lilian|Black|Blue|Office 2010 Blue|Office 2010 Black|Office 2010 Silver|Office 2007 Blue|Office 2007 Black|Office 2007 Silver|Office 2007 Green|Office 2007 Pink|Seven|Seven Classic|Darkroom|McSkin|Sharp|Sharp Plus|Foggy|Dark Side|Xmas (Blue)|Springtime|Summer|Pumpkin|Valentine|Stardust|Coffee|Glass Oceans|High Contrast|Liquid Sky|London Liquid Sky|The Asphalt World|Blueprint|"
                    string defaultSkinCaptions = base.GetLocalizedString(id);
                    string newSkinCaptions = defaultSkinCaptions.
                        Replace("|DevExpress Style|", "|My Favorite Skin|");
                    return newSkinCaptions;
                }
                return base.GetLocalizedString(id);
            }
        }

        // ------ THEME -----------------------------------------------------------// 

        private void frmMAINAPPS_Load(object sender, EventArgs e)
        {
            // ------ THEME -----------------------------------------------------------// 
            //3. Ra ngoài giao diện add vào 1 control có tên: RibbonGalleryBarItem
            //4. Thêm vào Main Form 1 control có tên: PopupMenu
            //5. Thiết lập tùy biến giao diện
            BarLocalizer.Active = new MyBarLocalizer();
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
            SkinHelper.InitSkinPopupMenu(popupMenu1);
            Login();
            // ------ THEME -----------------------------------------------------------// 
        }

        // xtraTab_Cousrses //
        public void LoadXtra_Courses(PermisstionObject objP)  //Tạo tab khóa học
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(xtraTab_Cousrses))
                {
                    xTCMainTabControl.TabPages.Remove(xtraTab_Cousrses);
                }
                xtraTab_Cousrses = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(xtraTab_Cousrses);
                xtraTab_Cousrses.Text = "Quản lý Khóa Học";
                xTCMainTabControl.Images = imageList1;
                xtraTab_Cousrses.ImageIndex = 8;
                xTCMainTabControl.SelectedTabPage = xtraTab_Cousrses;
                UserControll.UcCourses objUcCourses = new UserControll.UcCourses(objP);
                xtraTab_Cousrses.Controls.Add(objUcCourses);
                objUcCourses.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_CoursesJournal()  //Tạo tab nhật ký giảng dạy
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_CoursesJournal))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_CoursesJournal);
                }
                Xtra_CoursesJournal = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_CoursesJournal);
                Xtra_CoursesJournal.Text = "Quản Lý nhật Ký Giảng Dạy";
                xTCMainTabControl.Images = imageList1;
                Xtra_CoursesJournal.ImageIndex = 99;
                xTCMainTabControl.SelectedTabPage = Xtra_CoursesJournal;
                UserControll.UcCoursesJourna objUcCoursesJourna = new UserControll.UcCoursesJourna();
                Xtra_CoursesJournal.Controls.Add(objUcCoursesJourna);
                objUcCoursesJourna.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_Experts(PermisstionObject objP)  //Các giảng viên
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_Experts))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_Experts);
                }
                Xtra_Experts = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_Experts);
                Xtra_Experts.Text = "Quản Lý giảng viên";
                xTCMainTabControl.Images = imageList1;
                Xtra_Experts.ImageIndex = 4;
                xTCMainTabControl.SelectedTabPage = Xtra_Experts;
                UserControll.UcExperts objUcUcExperts = new UserControll.UcExperts(objP);
                Xtra_Experts.Controls.Add(objUcUcExperts);
                objUcUcExperts.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_Student(PermisstionObject objP)  //Tạo học viên
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_Student))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_Student);
                }
                Xtra_Student = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_Student);
                Xtra_Student.Text = "Quản Lý học viên";
                xTCMainTabControl.Images = imageList1;
                Xtra_Student.ImageIndex = 4;
                xTCMainTabControl.SelectedTabPage = Xtra_Student;
                UserControll.UcStudent objUcUcStudent = new UserControll.UcStudent(objP);
                Xtra_Student.Controls.Add(objUcUcStudent);
                objUcUcStudent.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_ShiftDay(PermisstionObject objP)  //Tạo ca học
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_ShiftDay))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_ShiftDay);
                }
                Xtra_ShiftDay = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_ShiftDay);
                Xtra_ShiftDay.Text = "Quản Lý ca học";
                xTCMainTabControl.Images = imageList1;
                Xtra_ShiftDay.ImageIndex = 4;
                xTCMainTabControl.SelectedTabPage = Xtra_ShiftDay;
                UserControll.UcShiftDay objUcShiftDay = new UserControll.UcShiftDay(objP);
                Xtra_ShiftDay.Controls.Add(objUcShiftDay);
                objUcShiftDay.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_WeekDay(PermisstionObject objP)  //Tạo thứ trong tuần
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_Weekdays))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_Weekdays);
                }
                Xtra_Weekdays = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_Weekdays);
                Xtra_Weekdays.Text = "Quản Lý thứ trong tuần";
                xTCMainTabControl.Images = imageList1;
                Xtra_Weekdays.ImageIndex = 2;
                xTCMainTabControl.SelectedTabPage = Xtra_Weekdays;
                UserControll.UcWeekdaysDao objUcWeekdays = new UserControll.UcWeekdaysDao(objP);
                Xtra_Weekdays.Controls.Add(objUcWeekdays);
                objUcWeekdays.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_ExpertsDetailt(PermisstionObject objP)  //Tạo chi tiết giảng viên
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_ExpertsDetailt))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_ExpertsDetailt);
                }
                Xtra_ExpertsDetailt = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_ExpertsDetailt);
                Xtra_ExpertsDetailt.Text = "Quản Lý chi tiết giảng viên";
                xTCMainTabControl.Images = imageList1;
                Xtra_ExpertsDetailt.ImageIndex = 8;
                xTCMainTabControl.SelectedTabPage = Xtra_ExpertsDetailt;
                UserControll.UcExpertsDetailt objUcExpertsDetailt = new UserControll.UcExpertsDetailt(objP);
                Xtra_ExpertsDetailt.Controls.Add(objUcExpertsDetailt);
                objUcExpertsDetailt.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_StudentDetailt(PermisstionObject objP)  //Tạo chi tiết học viên
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_StudentDetailt))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_StudentDetailt);
                }
                Xtra_StudentDetailt = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_StudentDetailt);
                Xtra_StudentDetailt.Text = "Quản Lý chi tiết học viên";
                xTCMainTabControl.Images = imageList1;
                Xtra_StudentDetailt.ImageIndex = 8;
                xTCMainTabControl.SelectedTabPage = Xtra_StudentDetailt;
                UserControll.UcStudentDetailt objUcStudentDetailtt = new UserControll.UcStudentDetailt(objP);
                Xtra_StudentDetailt.Controls.Add(objUcStudentDetailtt);
                objUcStudentDetailtt.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_Schedulers(PermisstionObject objP)  //Tạo chi lịch học
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_Schedulers))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_Schedulers);
                }
                Xtra_Schedulers = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_Schedulers);
                Xtra_Schedulers.Text = "Quản Lý lịch học giảng dậy";
                xTCMainTabControl.Images = imageList1;
                Xtra_Schedulers.ImageIndex = 5;
                xTCMainTabControl.SelectedTabPage = Xtra_Schedulers;
                UserControll.UcSchedulers objUcSchedulers = new UserControll.UcSchedulers(objP);
                Xtra_Schedulers.Controls.Add(objUcSchedulers);
                objUcSchedulers.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_SchedStudentDetailt(PermisstionObject objP)  //Tạo chi tiết lịch học
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_SchedStudentDetailt))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_SchedStudentDetailt);
                }
                Xtra_SchedStudentDetailt = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_SchedStudentDetailt);
                Xtra_SchedStudentDetailt.Text = "Quản Lý giang day";
                xTCMainTabControl.Images = imageList1;
                Xtra_SchedStudentDetailt.ImageIndex = 38;
                xTCMainTabControl.SelectedTabPage = Xtra_SchedStudentDetailt;
                UserControll.UcSchedStudentDetailt objUcSchedStudentDetailt = new UserControll.UcSchedStudentDetailt(objP);
                Xtra_SchedStudentDetailt.Controls.Add(objUcSchedStudentDetailt);
                objUcSchedStudentDetailt.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_Permisstion(AccountObject objAcc)  //Tạo chi tiết lịch học
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_Permisstion))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_Permisstion);
                }
                Xtra_Permisstion = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_Permisstion);
                Xtra_Permisstion.Text = "Quản Lý phân quyên";
                xTCMainTabControl.Images = imageList1;
                Xtra_Permisstion.ImageIndex = 196;
                xTCMainTabControl.SelectedTabPage = Xtra_Permisstion;
                UserControll.UcPermisstion objUcPermisstion = new UserControll.UcPermisstion(objAcc);
                Xtra_Permisstion.Controls.Add(objUcPermisstion);
                objUcPermisstion.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        public void LoadXtra_UcAccount()  //Tạo chi tiết lịch học
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (xTCMainTabControl.TabPages.Contains(Xtra_Account))
                {
                    xTCMainTabControl.TabPages.Remove(Xtra_Account);
                }
                Xtra_Account = new XtraTabPage();
                xTCMainTabControl.TabPages.Add(Xtra_Account);
                Xtra_Account.Text = "Quản Lý User";
                xTCMainTabControl.Images = imageList1;
                Xtra_Account.ImageIndex = 394;
                xTCMainTabControl.SelectedTabPage = Xtra_Account;
                UserControll.UcAccount objUcUser = new UserControll.UcAccount(m_objAccountObject);
                Xtra_Account.Controls.Add(objUcUser);
                objUcUser.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        // xtraTab_Cousrses //

        // ĐÓNG TAB
        private void xTCMainTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            if (arg != null)
            {
                xTCMainTabControl.TabPages.Remove(arg.Page as XtraTabPage);

            }
        }

        void Login()// Form login//
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                UserForm.Login.frmLogin frm = new UserForm.Login.frmLogin(m_objAccountObject, m_lisPer);
                frm.ShowDialog();
                CheckLoginSystem(m_objAccountObject);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        void CheckLoginSystem(AccountObject objContext)
        {
            //
            if (objContext.LoginSuccess)
            {
                //RoleId
                //+ SuperAdmin: 0ac8394a-ef24-4b89-9b40-da9c2327d229
                //+ User: 4852e943-c7a5-49bf-a94e-a5fe0b20f615
                //+ Guest: abc1ba34-08cf-43b9-be66-7804fa5fbe3a

                //Hiển chức năng

                this.Text = String.Format("Xin chào: {0} đang sử dụng PHẦN MỀM QUẢN LÝ THU-CHI!",
                    objContext.FullName);
                barHeaderItem1.Caption = String.Format("Xin chào: {0}", objContext.FullName);
                btnDangnhap.Caption = "Đăng Xuất";
                EnabledRibbon();
            }
            else
            {
                this.Text = "Xin chào Guest!";
                bhIUserInformation.Caption = String.Format("Xin chào Guest!");
                btnDangnhap.Caption = "Đăng Nhập";
                DisableRibbon();
            }
        }
        public void EnabledRibbon()
        {
            foreach (var item in ribbon.Items)
            {
                var barItem = item as BarItem;
                if (barItem != null && item != btnDangnhap)
                {
                    barItem.Enabled = true;
                }
            }
            foreach (var item in navBarControl1.Items)
            {
                var nBarItem = item as NavBarItem;
                if (nBarItem != null)
                {
                    nBarItem.Enabled = true;
                }
            }
        }
        public void DisableRibbon()
        {
            foreach (var item in ribbon.Items)
            {
                var barItem = item as BarItem;
                if (barItem != null && item != btnDangnhap)
                {
                    barItem.Enabled = false;
                }
            }
            foreach (var item in navBarControl1.Items)
            {
                var nBarItem = item as NavBarItem;
                if (nBarItem != null)
                {
                    nBarItem.Enabled = false;
                }
            }
        }
        private void nBIKhoaHoc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int count = 0;
            PermisstionObject objP = null;
            foreach (PermisstionObject item in m_lisPer)
            {
                if (item.FeaId.Trim().Equals("QLKH"))
                {
                    objP = item;
                    count += 1;
                    break;
                }
            }
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && count == 0)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_Courses(objP);
            }
        }//Phân quyền khóa học

        private void bBINKgiangday_ItemClick(object sender, ItemClickEventArgs e)//Phân quyền nhật ký giảng dạy
        {
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin"))
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_CoursesJournal();
            }
        }

        private void nBIExperts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int count = 0;
            PermisstionObject objP = null;
            foreach (PermisstionObject item in m_lisPer)
            {
                if (item.FeaId.Trim().Equals("QLCG"))
                {
                    objP = item;
                    count += 1;
                    break;
                }
            }
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && count == 0)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_Experts(objP);
            }
        }//Phân quyền  giảng viên

        private void nBIStudent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int count = 0;
            PermisstionObject objP = null;
            foreach (PermisstionObject item in m_lisPer)
            {
                if (item.FeaId.Trim().Equals("QLHV"))
                {
                    objP = item;
                    count += 1;
                    break;
                }
            }
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && count == 0)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_Student(objP);
            }
        }//Phân quyền học viên

        private void nBIShiftDay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)//Phân quyền ca học
        {
            int count = 0;
            PermisstionObject objP = null;
            foreach (PermisstionObject item in m_lisPer)
            {
                if (item.FeaId.Trim().Equals("QLCH"))
                {
                    objP = item;
                    count += 1;
                    break;
                }
            }
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && count == 0)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_ShiftDay(objP);

            }

        }

        private void nBIWeekDay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)// Phân quyền Thứ trong tuần
        {
            int count = 0;
            PermisstionObject objP = null;
            foreach (PermisstionObject item in m_lisPer)
            {
                if (item.FeaId.Trim().Equals("QLTTT"))
                {
                    objP = item;
                    count += 1;
                    break;
                }
            }
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && count == 0)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_WeekDay(objP);
            }
        }

        private void bBIChiTietGV_ItemClick(object sender, ItemClickEventArgs e)// Phân quyền chi tiết giảng viên
        {
            int count = 0;
            PermisstionObject objP = null;
            foreach (PermisstionObject item in m_lisPer)
            {
                if (item.FeaId.Trim().Equals("QLCTGV"))
                {
                    objP = item;
                    count += 1;
                    break;
                }
            }
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && count == 0)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_ExpertsDetailt(objP);
            }
        }

        private void bBIChitietHV_ItemClick(object sender, ItemClickEventArgs e)//Phân quyền chi tiết học viên
        {
            int count = 0;
            PermisstionObject objP = null;
            foreach (PermisstionObject item in m_lisPer)
            {
                if (item.FeaId.Trim().Equals("QLCTHV"))
                {
                    objP = item;
                    count += 1;
                    break;
                }
            }
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && count == 0)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_StudentDetailt(objP);
            }
        }

        private void bBILichgiangday_ItemClick(object sender, ItemClickEventArgs e)// Phân quyền lịch giảng dạy
        {
            int count = 0;
            PermisstionObject objP = null;
            foreach (PermisstionObject item in m_lisPer)
            {
                if (item.FeaId.Trim().Equals("QLLGD"))
                {
                    objP = item;
                    count += 1;
                    break;
                }
            }
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && count == 0)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_Schedulers(objP);
            }

        }
        private void bBIChitietgiangday_ItemClick(object sender, ItemClickEventArgs e)//Phân quyền Chi tiết giảng dạy
        {
            int count = 0;
            PermisstionObject objP = null;
            foreach (PermisstionObject item in m_lisPer)
            {
                if (item.FeaId.Trim().Equals("QLCTLGD"))
                {
                    objP = item;
                    count += 1;
                    break;
                }
            }
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && count == 0)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_SchedStudentDetailt(objP);
            }
        }
        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)// Phân quyền Permisstion
        {
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && !m_objAccountObject.Roldeobj.RName.Equals("Admin"))
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_Permisstion(m_objAccountObject);
            }
        }
        private void btnUser_ItemClick(object sender, ItemClickEventArgs e)// Phân quyền Username
        {
            if (!m_objAccountObject.Roldeobj.RName.Equals("SuperAdmin") && !m_objAccountObject.Roldeobj.RName.Equals("Admin"))
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này. Vui lòng liên hệ với SuperAdmin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                LoadXtra_UcAccount();
            }
        }
        private void btnDangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult opt = MessageBox.Show("Bạn có chắn chắn muốn Đăng Xuất chương trình?", "Thông báo",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opt == System.Windows.Forms.DialogResult.Yes)
            {
                xTCMainTabControl.TabPages.Remove(Xtra_CoursesJournal);
                xTCMainTabControl.TabPages.Remove(xtraTab_Cousrses);
                xTCMainTabControl.TabPages.Remove(Xtra_Experts);
                xTCMainTabControl.TabPages.Remove(Xtra_ExpertsDetailt);
                xTCMainTabControl.TabPages.Remove(Xtra_StudentDetailt);
                xTCMainTabControl.TabPages.Remove(Xtra_Student);
                xTCMainTabControl.TabPages.Remove(Xtra_ShiftDay);
                xTCMainTabControl.TabPages.Remove(Xtra_Weekdays);
                xTCMainTabControl.TabPages.Remove(Xtra_Schedulers);
                xTCMainTabControl.TabPages.Remove(Xtra_SchedStudentDetailt);
                xTCMainTabControl.TabPages.Remove(Xtra_Permisstion);
                xTCMainTabControl.TabPages.Remove(Xtra_Account);
                m_objAccountObject = new AccountObject();
                m_lisPer = new List<PermisstionObject>();
                Login();
            };
        }

        private void btnthoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult opt = MessageBox.Show("Bạn có chắn chắn muốn thoát chương trình?", "Thông báo",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opt == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ĐÓNG TAB

    }
}