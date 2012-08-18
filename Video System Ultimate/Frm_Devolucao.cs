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
    public partial class Frm_Devolucao : Form
    {
        public Frm_Devolucao()
        {
            InitializeComponent();
        }

        private void iTEMLOCACAOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTEMLOCACAOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);

        }

     
        private void Frm_Devolucao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas' table. You can move, or remove it, as needed.
            //this.contasTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME' table. You can move, or remove it, as needed.
            this.fILMETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO' table. You can move, or remove it, as needed.
            //this.iTEMLOCACAOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == 13)
            {
                retornaconsulta();
                
            }
        }

        private void retornaconsulta()
        {
            int contausuario;
            contausuario = uSUARIOTableAdapter.FillByFILTRACPF(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO, Convert.ToInt64(textBox1.Text));
            

            if (contausuario == 1)
            {
                textBox2.Text = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO.FindByCPFUSUARIO(Convert.ToInt64(textBox1.Text)).NOME;
                
                int contlocacoes = this.iTEMLOCACAOTableAdapter.FillByfiltradevolver(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO, Convert.ToInt64(textBox1.Text));
                contasTableAdapter.FillBycon(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas, Convert.ToInt64(textBox1.Text));
                
                //this.contasTableAdapter.FillByCont(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas, Convert.ToInt32(this.iTEMLOCACAODataGridView.Rows[0].Cells[2].Value.ToString()));

                if (contlocacoes == 0)
                {
                    MessageBox.Show("Usuário não possui locações", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                textBox1.Clear();
                this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.Clear();
                MessageBox.Show("Usuario não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                new Frm_PesquisaUsuario(this).ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show("Aconteceu algum erro efetue novamente a operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void retornacodigoenome(Int64 codigo, String nome)
        {
            textBox1.Text = codigo.ToString();
            textBox2.Text = nome;
            retornaconsulta();
            Calcularconta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogo;

            for (int i = 0; i < iTEMLOCACAODataGridView.Rows.Count; i++)
            {
                if (bool.Parse(iTEMLOCACAODataGridView[0, i].EditedFormattedValue.ToString()))
                {
                    iTEMLOCACAODataGridView[4, i].Value = dateTimePicker1.Value.ToShortDateString();
                                        
                }
            }
            int id = int.Parse(iTEMLOCACAODataGridView[2, 0].Value.ToString());
            
            iTEMLOCACAOBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                 
            MessageBox.Show("Devolução Efetuada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dialogo = MessageBox.Show("Deseja fechar o formulário de Devolução?","Deseja sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
            else
            {
                int contlocacoes = this.iTEMLOCACAOTableAdapter.FillByfiltradevolver(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO, Convert.ToInt64(textBox1.Text));
                if (contlocacoes == 0)
                    button1.Enabled = false;
                
            }
                
                       
        }

        
        private void Calcularconta ()
        {
            decimal vl = 0;
            for (int i = 0; i < contasDataGridView.Rows.Count - 1; i++)
            {
                
                    vl = vl + decimal.Parse(contasDataGridView[3,i].Value.ToString());                    

                
            }

            label4.Text = "R$" + vl.ToString() + ",00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contasDataGridView.Rows.Count; i++)
            {
                if (bool.Parse(contasDataGridView[0, i].EditedFormattedValue.ToString()))
                {
                    if (contasDataGridView.CurrentRow.Cells[3].Value.ToString() == "")
                    {
                        MessageBox.Show("Linha em branco, não tem como excluir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.contasTableAdapter.FillBydel(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas, Convert.ToInt32(contasDataGridView[4,i].Value.ToString()));
                        Calcularconta();
                    }
                }
            }
        }

        private void Frm_Devolucao_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
