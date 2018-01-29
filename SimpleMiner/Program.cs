using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMiner
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
            Application.ThreadException += Application_ThreadException;

            // Language of interface
            try
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
               new System.Globalization.CultureInfo(SettingsManager.instance.currentSettings.Language);
            }
            catch (Exception ex)
            {
            }


            Application.Run(new SimpleMinerForm());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            UIHelper.ShowError(e.Exception);
        }
    }
}
