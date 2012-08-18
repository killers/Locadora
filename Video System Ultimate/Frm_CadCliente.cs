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
    public partial class Frm_CadCliente : Form
    {
        public Frm_CadCliente()
        {
            InitializeComponent();
        }

        private void uSUARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.uSUARIOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                MessageBox.Show("Registro Salvo com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.uSUARIOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO);
                this.uSUARIOBindingSource.MoveLast();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Salvar arquivo!\nVerifique se todos os campos obrigatórios estão preenchidos", "Erro Fatal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void Frm_CadCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.CIDADE' table. You can move, or remove it, as needed.
            this.cIDADETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.CIDADE);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.ESTADO' table. You can move, or remove it, as needed.
            this.eSTADOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ESTADO);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO);
            this.uSUARIOBindingSource.MoveLast();
            cPFUSUARIOMaskedTextBox.Focus();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cIDADETableAdapter.FillByFILTRACIDADE(bD_VIDEO_SYSTEM_ULTIMATEDataSet.CIDADE, Convert.ToInt32(comboBox1.SelectedValue));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.uSUARIOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                MessageBox.Show("Registro Salvo com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.uSUARIOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO);
                this.uSUARIOBindingSource.MoveLast();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Salvar arquivo!\nVerifique se todos os campos obrigatórios estão preenchidos", "Erro Fatal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FCC_btLimpar_Click(object sender, EventArgs e)
        {
            cPFUSUARIOMaskedTextBox.Clear();
            nOMETextBox.Clear();
            lAGRADOUROTextBox.Clear();
            nUMEROTextBox.Clear();
            bAIRROTextBox.Clear();
            comboBox1.SelectedText = "";
            comboBox2.SelectedText = "";
        }

        private void FCC_btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            cPFUSUARIOMaskedTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Excluido com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
