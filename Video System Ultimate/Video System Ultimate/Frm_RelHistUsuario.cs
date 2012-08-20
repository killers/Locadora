using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Video_System_Ultimate
{
    public partial class Frm_RelHistUsuario : Form
    {
        public Frm_RelHistUsuario()
        {
            InitializeComponent();
        }

        private void Frm_RelHistUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_VIDEO_SYSTEM_ULTIMATEDataSet.Relatorios' table. You can move, or remove it, as needed.
            this.RelatoriosTableAdapter.Fill(this.BD_VIDEO_SYSTEM_ULTIMATEDataSet.Relatorios);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

 
    }
}
