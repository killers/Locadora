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
    public partial class Frm_CadEstado : Form
    {
        public Frm_CadEstado()
        {
            InitializeComponent();
        }

        private void eSTADOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eSTADOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);

        }

        private void Frm_CadEstado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.ESTADO' table. You can move, or remove it, as needed.
            this.eSTADOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ESTADO);

        }
    }
}
