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
    public partial class Frm_PesquisaUsuario : Form
    {
        private Frm_Devolucao frmdevolucao;
        private Frm_Locacao frmlocacao;
        
        public Frm_PesquisaUsuario()
        {
            InitializeComponent();
        }

        public Frm_PesquisaUsuario(Frm_Devolucao frm)
        {
            frmdevolucao = frm;
            InitializeComponent();
        }

        public Frm_PesquisaUsuario(Frm_Locacao fr)
        {
            frmlocacao = fr;
            InitializeComponent();
        }

        private void uSUARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);

        }

        private void Frm_PesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.uSUARIOTableAdapter.FillByFILTRANOME(bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO, textBox1.Text);
        }

        private void uSUARIODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Frm_Devolucao)
                    {
                        frmdevolucao.retornacodigoenome(Convert.ToInt64(uSUARIODataGridView.CurrentRow.Cells[0].Value.ToString()),
                        uSUARIODataGridView.CurrentRow.Cells[1].Value.ToString());
                    }
                }
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Frm_Locacao)
                    {
                        frmlocacao.retornacodigoenome(Convert.ToInt64(uSUARIODataGridView.CurrentRow.Cells[0].Value.ToString()));
                        
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Operação abortada","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
                        
            this.Dispose();
        }

        
    }
}
