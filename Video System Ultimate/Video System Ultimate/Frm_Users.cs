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
    public partial class Frm_Users : Form
    {
        public Frm_Users()
        {
            InitializeComponent();
        }

        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.uSERSBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                MessageBox.Show("Registro Salvo com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Salvar arquivo!\nVerifique se todos os campos obrigatórios estão preenchidos", "Erro Fatal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter1.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USERS);
            // TODO: esta linha de código carrega dados na tabela 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.USERS'. Você pode movê-la ou removê-la conforme necessário.
            this.uSERSTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USERS);

        }

        private void uSERSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);

        }
    }
}
