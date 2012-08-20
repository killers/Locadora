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
    public partial class Frm_CadCidade : Form
    {
        public Frm_CadCidade()
        {
            InitializeComponent();
        }

        private void cIDADEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
         }

        private void Frm_CadCidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.ESTADO' table. You can move, or remove it, as needed.
            this.eSTADOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ESTADO);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.CIDADE' table. You can move, or remove it, as needed.
            this.cIDADETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.CIDADE);
            nOMECIDADETextBox.Focus();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cIDADEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cIDADEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                MessageBox.Show("Registro Salvo com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar arquivos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Excluido com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
