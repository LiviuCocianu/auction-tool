using System;
using System.Windows.Forms;

namespace Auction_Tool {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm main = new MainForm();

            if(main.workpathProvided())
                Application.Run(main);
        }
    }
}
