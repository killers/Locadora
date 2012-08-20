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
    public partial class Frm_CadFilme : Form
    {
        public Frm_CadFilme()
        {
            InitializeComponent();
        }

        private void fILMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.fILMEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                MessageBox.Show("Registro Salvo com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.fILMETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);
                this.fILMEBindingSource.MoveLast();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Salvar arquivo! \n Verifique se todos os campos obrigatórios estão preenchidos", "Erro Fatal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Frm_CadFilme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.PRECO' table. You can move, or remove it, as needed.
            this.pRECOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.PRECO);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.GENERO' table. You can move, or remove it, as needed.
            this.gENEROTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.GENERO);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME' table. You can move, or remove it, as needed.
            this.fILMETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(bD_VIDEO_SYSTEM_ULTIMATEDataSet);
        }

        private void FCF_btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.fILMEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                MessageBox.Show("Registro Salvo com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.fILMETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);
                this.fILMEBindingSource.MoveLast();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Salvar arquivo!\nVerifique se todos os campos obrigatórios estão preenchidos", "Erro Fatal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FCF_btLimpar_Click(object sender, EventArgs e)
        {
            iDFILMETextBox.Clear();
            tITULOTextBox.Clear();
            sUBTITULOTextBox.Clear();
            pRODUTORATextBox.Clear();
            dURACAOTextBox.Clear();
        }

        private void FCF_btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
