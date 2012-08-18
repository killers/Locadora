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
    public partial class Frm_Preco : Form
    {
        public Frm_Preco()
        {
            InitializeComponent();
        }

        private void pRECOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pRECOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                MessageBox.Show("Registro Salvo com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu algum erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Frm_Preco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.PRECO' table. You can move, or remove it, as needed.
            this.pRECOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.PRECO);

        }
    }
}
