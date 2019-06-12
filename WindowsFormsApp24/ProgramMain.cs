using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.ServerOs;
using System.Threading;


namespace main
{
    static class ProgramMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                MyTcpListener.StartListening();
            }).Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new Menu());*/
            Application.Run(new LoginScreen());
            /*Application.Run(new main_manager_wnd()); */
        }
    }
}
