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
    public partial class Frm_CadGenero : Form
    {
        public Frm_CadGenero()
        {
            InitializeComponent();
        }

        private void gENEROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.gENEROBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                MessageBox.Show("Registros Salvos com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu algum erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Frm_CadGenero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.GENERO' table. You can move, or remove it, as needed.
            this.gENEROTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.GENERO);

        }
    }
}
