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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        public void carregaform()
        {
            FP_lblData.Text = DateTime.Now.ToShortDateString();

            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME' table. You can move, or remove it, as needed.
            this.fILMETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO' table. You can move, or remove it, as needed.
            this.iTEMLOCACAOTableAdapter.Fill(bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO);
            this.iTEMLOCACAOTableAdapter.FillByDat(bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO, Convert.ToDateTime(FP_lblData.Text));
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            FP_lblData.Text = DateTime.Now.ToShortDateString();

            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME' table. You can move, or remove it, as needed.
            this.fILMETableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.FILME);
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO' table. You can move, or remove it, as needed.
            this.iTEMLOCACAOTableAdapter.Fill(bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO);
            this.iTEMLOCACAOTableAdapter.FillByDat(bD_VIDEO_SYSTEM_ULTIMATEDataSet.ITEMLOCACAO, Convert.ToDateTime(FP_lblData.Text));

           
        }
        
        //
        // Eventos dos botões principais
        //

        // Evento do botão clientes
        private void FP_btCliente_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_CadCliente)
                {
                    form.Focus();
                    i = -1;
                    
                }
            }

            if (i != -1)
            {
                Frm_CadCliente FrmClientes = new Frm_CadCliente();
                FrmClientes.Show(); 
            }
            
                     
        }

        // Evento do botão Filmes
        private void FP_btFilme_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_CadFilme)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_CadFilme FrmFilme = new Frm_CadFilme();
                FrmFilme.Show();
            }
            
            
        }

        // Evento do botão Locação
        private void FP_btLocar_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_Locacao)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_Locacao FrmLocacao = new Frm_Locacao();
                FrmLocacao.Show();
                
            }
            
        }

        // Evento do botão Devolução
        private void FP_btDevolver_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_Devolucao)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_Devolucao FrmDevolucao = new Frm_Devolucao();
                FrmDevolucao.Show();
            }
            
        }

        // Evento do botão Pesquisa
        private void FP_btPesquisar_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_PesquisaUsuario)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_PesquisaUsuario FrmPesquisa = new Frm_PesquisaUsuario();
                FrmPesquisa.Show();
            }
            
        }

        //
        //  Eventos dos Botões do menu da barra de ferramentas
        //

        // Evento do botão Arquivo\Fechar
        private void FPMA_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento do botão Cadastro\Cliente
        private void FPMC_Cliente_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_CadCliente)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_CadCliente FrmClientes = new Frm_CadCliente();
                FrmClientes.Show();
            }
        }

        // Evento do botão Cadastro\Filme
        private void FPMC_Filme_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_CadFilme)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_CadFilme FrmFilme = new Frm_CadFilme();
                FrmFilme.Show();
            }
        }

        // Evento do botão Cadastro\Usuário
        private void FPMC_Usuario_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_Users)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_Users FrmFilme = new Frm_Users();
                FrmFilme.Show();
            }
            
        }

        // Evento do botão Cadastro\Gênero
        private void FPMC_Genero_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_CadGenero)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_CadGenero FrmGenero = new Frm_CadGenero();
                FrmGenero.Show();
            }
            
        }

        // Evento do botão Pesquisa\Clientes
        private void FPMP_Clientes_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_PesquisaUsuario)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_PesquisaUsuario FrmPesquisa = new Frm_PesquisaUsuario();
                FrmPesquisa.Show();
            }
            
        }

        // Evento do botão Pesquisa\Filmes
        private void FPMP_Filmes_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_PesquisaFilme)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_PesquisaFilme FrmPesquisa = new Frm_PesquisaFilme();
                FrmPesquisa.Show();
            }
            
        }

        // Evento do botão Loc/Dev\Locação
        private void FPMLD_Loc_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_Locacao)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_Locacao FrmLocacao = new Frm_Locacao();
                FrmLocacao.Show();
            }
            
        }

        // Evento do botão Loc/Dev\Devolução
        private void FPMLD_Dev_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_Devolucao)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_Devolucao FrmDevolucao = new Frm_Devolucao();
                FrmDevolucao.Show();
            }
          
        }

        private void preçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Preco FrmPreco = new Frm_Preco();
            FrmPreco.ShowDialog();
        }

        private void iTEMLOCACAOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTEMLOCACAOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);

        }

        private void FP_Timer2_Tick(object sender, EventArgs e)
        {
            // Exibição da Data/Hora no sistema
            FPS_D.Text = DateTime.Now.ToLongDateString();
            FPS_H.Text = DateTime.Now.ToLongTimeString();
        }

        private void FPMC_Cidade_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_CadCidade)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_CadCidade FrmCidade = new Frm_CadCidade();
                FrmCidade.Show();
            }
        }

        private void FPMC_Estado_Click(object sender, EventArgs e)
        {
            //código que permite o formulário abrir apenas uma vez
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_CadEstado)
                {
                    form.Focus();
                    i = -1;

                }
            }

            if (i != -1)
            {
                Frm_CadEstado FrmEstado = new Frm_CadEstado();
                FrmEstado.Show();
            }
        }

        private void relatórioDeHistóricoDeFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelHistFilme fr = new RelHistFilme();
            fr.Show();
        }

        private void relatórioDeHistóricoPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RelData frm = new Frm_RelData();
            frm.Show();
            
        }

        private void relatórioDeHistóricoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RelHistUsuario frm = new Frm_RelHistUsuario();
            frm.Show();
        }
    }
}
