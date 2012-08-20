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

    public partial class Frm_PesquisaFilme : Form
    {
        private Frm_Locacao frmlocacao;

        public Frm_PesquisaFilme(Frm_Locacao frm)
        {
            frmlocacao = frm;
            InitializeComponent();
        }

        public Frm_PesquisaFilme()
        {
            InitializeComponent();
        }

        private void fILMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fILMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);

        }

        private void Frm_PesquisaFilme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.GENERO' table. You can move, or remove it, as needed.
            this.gENEROTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.GENERO);
           
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME' table. You can move, or remove it, as needed.
            this.fILMETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);
            iDGENEROComboBox.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.fILMETableAdapter.FillByFILTRAFILME(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME, textBox1.Text);
        }

        private void fILMEDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_Locacao)
                {
                    frmlocacao.retornacodigofilme(Convert.ToInt32(fILMEDataGridView.CurrentRow.Cells[0].Value.ToString()));
                }
                
            }
            
            this.Dispose();
            
        }

                
        private void iDGENEROComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.fILMETableAdapter.FillByGEN(bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME, Convert.ToInt32(iDGENEROComboBox.SelectedValue.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iDGENEROComboBox.Text = "";
            this.fILMETableAdapter.Fill(bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);
        }

        
    }
}
