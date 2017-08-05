using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// ---- THEME --------------------------------------------------------//

//1. Thiết lập tùy biến giao diện Theme
using DevExpress.LookAndFeel;
//2. add references DevExpress.UserSkins.BonusSkins (dùng cho Theme)
//Right click References --> Add references rồi tìm BonusSkins

// ---- THEME ---------------------------------------------------------//



namespace QL_LICHGIANGDAY
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

     // ------ THEME -----------------------------------------------------------//
            //3.  Thiết lập tùy biến giao diện (dùng cho Theme)
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Whiteprint");//DevExpress Style
    // ------ THEME -----------------------------------------------------------//

            Application.Run(new frmMAINAPPS());
        }
    }
}
