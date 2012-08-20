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
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();
        }

        // Evento timer para controle do form. Splash
        private void S_Timer_Tick(object sender, EventArgs e)
        {
            // Verificação para execução da barra de progresso
            if (FS_Progress1.Value < 100)
            {
                // Incremento da barra de progresso
                FS_Progress1.Value += 5;
            }
            else
            {
                // Encerramento do timer
                FS_Timer.Stop();
                
                // Encerramento do Form. Splash
                this.Close();               
            }
        }
    }
}
