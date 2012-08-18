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
    public partial class Frm_Conta : Form
    {
        public Frm_Conta()
        {
            InitializeComponent();
        }

        private void contasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);

        }

        private void Frm_Conta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas' table. You can move, or remove it, as needed.
            this.contasTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas);
            
            //Frm_Locacao fr = new Frm_Locacao();
            //int filtro = int.Parse(fr.iTEMLOCACAODataGridView[1, 0].Value.ToString());
            //idContaTextBox.Text = filtro.ToString();
            //this.contasTableAdapter.FillByCont(bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas, filtro);
            this.contasBindingSource.MoveLast();
            vALORPAGOTextBox.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.contasBindingSource.EndEdit();
                this.contasTableAdapter.Update(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas);
                MessageBox.Show("Registros Salvos com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Falha ao salvar registros", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void vALORPAGOTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void vALORPAGOTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal valordev = decimal.Parse(vALORDEVIDOTextBox.Text);
                decimal valorpg = decimal.Parse(vALORPAGOTextBox.Text);

                valordev = valordev - valorpg;

                vALORDEVIDOTextBox.Text = valordev.ToString();
                button1.Focus();
            }
        }
    }
}
