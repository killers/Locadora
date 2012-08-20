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
    public partial class Frm_RelData : Form
    {
        public Frm_RelData()
        {
            InitializeComponent();
        }

        
        private void Frm_RelData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_VIDEO_SYSTEM_ULTIMATEDataSet.Relatorios' table. You can move, or remove it, as needed.
            this.RelatoriosTableAdapter.Fill(this.BD_VIDEO_SYSTEM_ULTIMATEDataSet.Relatorios);
            // TODO: This line of code loads data into the 'BD_VIDEO_SYSTEM_ULTIMATEDataSet.Relatorios' table. You can move, or remove it, as needed.
            //this.RelatoriosTableAdapter.FillByDATA(this.BD_VIDEO_SYSTEM_ULTIMATEDataSet.Relatorios,Convert.ToDateTime(data),Convert.ToDateTime(data));
            maskedTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RelatoriosTableAdapter.FillByDATA(BD_VIDEO_SYSTEM_ULTIMATEDataSet.Relatorios,Convert.ToDateTime(maskedTextBox1.Text),Convert.ToDateTime(maskedTextBox1.Text));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
