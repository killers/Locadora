using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Video_System_Ultimate
{
    static class ClassPrincipal
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Splash());
            Frm_Login FrmLogin = new Frm_Login();
            if (FrmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Frm_Principal());
            }
        }
    }
}
