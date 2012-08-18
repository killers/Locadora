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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        // Evento do botão Entrar
        private void FL_btEntrar_Click(object sender, EventArgs e)
        {
            // Verificação de usuário e senha para acesso
            int Achou = this.uSERSTableAdapter.FillByEntrada(bD_VIDEO_SYSTEM_ULTIMATEDataSet.USERS, FL_txtUsuario.Text, FL_txtSenha.Text);
            if (Achou != 0)
            {
                this.Dispose();
         

                Frm_Principal FrmPrincipal = new Frm_Principal();
                FrmPrincipal.ShowDialog();
                
            }
            else
            {
                // Mensagem de erro de autenticação
                MessageBox.Show("Usuário ou Senha Inválidos",
                                "Erro de Autenticação !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet);

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_VIDEO_SYSTEM_ULTIMATEDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.USERS);

        }

        private void FL_txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FL_btEntrar_Click(sender, e);
            }
        }

        private void Frm_Login_Shown(object sender, EventArgs e)
        {
            FL_txtUsuario.Focus();
        }
    }
}
