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
    public partial class Frm_Locacao : Form
    {
        public Frm_Locacao()
        {
            InitializeComponent();
        }
        decimal total = 0;
        decimal valor = 0;
        decimal vlr = 0;

        private void Alteradata()
        {
            /*Comando que permitem inserir a data e hora automáticamento nos text box dATARETIRADADateTimePicker.Text, 
             * hORARETIRADADateTimePicker.Text, dATAENTREGADateTimePicker.Text */ 
            this.lOCACAOTableAdapter.Update(bD_VIDEO_SYSTEM_ULTIMATEDataSet);
            dATARETIRADADateTimePicker.Text = DateTime.Now.ToShortDateString();
            hORARETIRADADateTimePicker.Text = DateTime.Now.ToShortTimeString();
            dATAENTREGADateTimePicker.Text = DateTime.Now.AddDays(1).ToShortDateString();
            
        }
            
        

        private void lOCACAOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //comandos do botão salvar
            this.Validate();
            this.lOCACAOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);
            
        }

        private void Frm_Locacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas' table. You can move, or remove it, as needed.
            this.contasTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.PRECO' table. You can move, or remove it, as needed.
           // this.pRECOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.PRECO);
            /* Comandos executados assim que o form é chamado, carrega a tabela filme, simula o precionamento do botão novo, chama o 
             * método AlteraData, e Salva, depois carrega as tabelas Usuario e ItemLocação, e ainda carrega a tabela locação novamnte e move 
             para o último registro da tabela*/

            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME' table. You can move, or remove it, as needed.
            this.fILMETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);
            this.lOCACAOBindingSource.AddNew();
            Alteradata();
            this.lOCACAOBindingNavigatorSaveItem_Click(sender, e);
            
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO);                                  
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO' table. You can move, or remove it, as needed.
            this.iTEMLOCACAOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO);
            
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.LOCACAO' table. You can move, or remove it, as needed.
            this.lOCACAOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.LOCACAO);
            this.lOCACAOBindingSource.MoveLast();
            this.textBox1.Focus();           

        }

        private void cPFUSUARIOTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           //Comando para pesquisar cliente com o precionamento da tecla enter
            if (e.KeyChar == 13)
            {
                comboBox1.SelectedValue = textBox1.Text;
                label3.Text = comboBox1.Text;
                textBox2.Focus();
                if (comboBox1.SelectedValue == "")
                {
                    MessageBox.Show("Cliente não cadastrado");
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedValue.ToString();
        }

        private void iTEMLOCACAODataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
                       
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.lOCACAOBindingSource.AddNew();
            Alteradata();
            this.lOCACAOBindingNavigatorSaveItem_Click(sender, e);

            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USUARIO);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO' table. You can move, or remove it, as needed.
            this.iTEMLOCACAOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO);

            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.LOCACAO' table. You can move, or remove it, as needed.
            this.lOCACAOTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.LOCACAO);
            this.lOCACAOBindingSource.MoveLast();
            textBox1.Clear();
            label3.Text = "-";
            textBox1.Focus();
            label4.Text = "0";
            
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
            
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            //código if inserido para corrigir um bug, pois o sistema estava locando mesmo sem ter um usuário selecionado
            if ((textBox1.Text != "") && (comboBox1.Text != ""))
            {
                
                this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.Contas.Rows.Add(null,null,total,Convert.ToInt32(iDLOCACAOTextBox.Text));
                this.contasTableAdapter.Update(bD_VIDEO_SYSTEM_ULTIMATEDataSet);


                if ((iTEMLOCACAODataGridView.RowCount > 1))
                {
                    /* Os comando abaixo fazem a atualização da tabela ITEMLOCACAO, chamam o método salvar do botão do componente BindinNavigator
                     * e zeram os text box dATAENTREGADateTimePicker.Text,dATARETIRADADateTimePicker.Text, hORARETIRADADateTimePicker.Text, esses
                     * componentes são zerados para que não seja preciso toda vez que for fazer uma locação ter que alterar a data no calendário,
                     * ja que a data é inserida automáticamente através dos comandos do método AlteraData();*/
                    this.iTEMLOCACAOTableAdapter.Update(bD_VIDEO_SYSTEM_ULTIMATEDataSet);
                    
                    lOCACAOBindingNavigatorSaveItem_Click(sender, e);
                    dATAENTREGADateTimePicker.Text = "";
                    dATARETIRADADateTimePicker.Text = "";
                    hORARETIRADADateTimePicker.Text = "";
                    MessageBox.Show("Locação Salva com sucesso", "Locado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_Conta fr = new Frm_Conta();
                    fr.ShowDialog();
                                                            
                }
                else
                {
                    MessageBox.Show("Informe o Filme que Deseja Locar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }
            else
            {
                MessageBox.Show("Informe o Locatário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int verifica;
            
            bool achou = false; //variavel que vai verificar se existe filmes iguais locados para a mesma pessoa
            try
            {
                if (e.KeyChar == 13)
                {
                    /*a variavel VERIFICA foi criada para armazenar o valor do método (FILLBYIDLIVRO) de filtragem que é passado através
                     * do objeto textBox2.text*/
                    verifica = this.fILMETableAdapter.FillByIDFilme(bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME, Convert.ToInt32(textBox2.Text));
                    /*quando é efetuado este comando de filtragem o sistema automáticamente estava escondendo o restante dos filmes 
                     * que estão armazenados na tabela filmes, então foi feito este procedimento para carregar novamente*/
                    this.fILMETableAdapter.Fill(bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);

                    if (verifica == 1)
                    {
                        string filme = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME.FindByIDFILME(Convert.ToInt32(textBox2.Text)).TITULO;
                        int idp = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME.FindByIDFILME(Convert.ToInt32(textBox2.Text)).IdPreco;
                        this.pRECOTableAdapter.FillBypreco(bD_VIDEO_SYSTEM_ULTIMATEDataSet.PRECO, idp);
                        valor = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.PRECO.FindByIdpreco(idp).Valor; 

                        /*laço que ira percorrer toda a coluna 2 e ver se exite um filme com o mesmo título locado para a mesma pesssoa*/
                        for (int i = 0; i < iTEMLOCACAODataGridView.RowCount; i++)
                        {
                            if (iTEMLOCACAODataGridView[2, i].EditedFormattedValue.ToString() == filme)
                            {
                                achou = true;
                                break;
                            }
                        }
                        if (achou)
                        {
                            MessageBox.Show("O Filme ja esta na lista de locação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            /*se foi encontrado alguma coisa a variavel verifica retorna o valor 1, então, é adicionada uma linha na tabela ITEMLOCACAO, sendo a 
                             * primeira coluna null(valo automático), segunda coluna recebe o valor de IDLOCACAOtextBox.text (valor que faz a relação entre
                             * as tabelas, terceira coluna recebe o valor de textBox2.text, que foi o código que o usuario entrou para o filme, e a 
                             * terceira coluna por enquanto esta vazia que é a data de devolução, e a quinta coluna é o preço do filme*/
                            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO.Rows.Add(null, Convert.ToInt32(iDLOCACAOTextBox.Text), 
                                Convert.ToInt32(textBox2.Text), null,valor.ToString());
                            

                            total = valor + total;
                            label4.Text = total.ToString() + ",00";
                            
                         }

                    }
                    else
                    {
                        MessageBox.Show("O Filme não foi cadastrado ou o código esta errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBox2.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu algum erro" + erro.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                vlr = decimal.Parse(iTEMLOCACAODataGridView.CurrentRow.Cells[4].Value.ToString());
                total = total - vlr;
                label4.Text = total.ToString() + ",00";
                this.iTEMLOCACAOBindingSource.RemoveCurrent();
            }
            catch (Exception ERRO)
            {
                MessageBox.Show("Não Existem Filmes para excluir","Erro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void hORARETIRADADateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iTEMLOCACAODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Frm_PesquisaUsuario(this).ShowDialog();
            
        }

        private void verificafilmes()
        {
            int contlocacoes = this.iTEMLOCACAOTableAdapter.FillByfiltradevolver(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO, Convert.ToInt64(textBox1.Text));

            if (contlocacoes != 0)
            {
                DialogResult dialogo;

                dialogo = MessageBox.Show("Usuário ja possui locações, continuar locando ?","Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogo == System.Windows.Forms.DialogResult.No)
                {
                    this.Dispose();
                }
            }
        }
         
        public void retornacodigoenome(Int64 codigo)
        {
            try
            {
                textBox1.Text = codigo.ToString();
                verificafilmes();
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Operação abortada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        public void retornacodigofilme(Int32 codigo)
        {
            try
            {
                textBox2.Text = codigo.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Operação abortada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //try
            //{
                new Frm_PesquisaFilme(this).ShowDialog();
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("Clique na linha do filem que deseja", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void Frm_Locacao_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }


    }
}
