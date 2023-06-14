using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace PylezZo_GTAV_Extreme_Tool
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

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            if (!File.Exists(Path.GetTempPath() + "PyloL/settings.txt"))
            {
                Application.Run(new DonateL());
            }
            else
            {
                string txt;
                txt = File.ReadAllText(Path.GetTempPath() + "PyloL/settings.txt");
                if (txt.Contains("disabled"))
                {
                    Application.Run(new Main());
                }
            }
        }
    }
}
