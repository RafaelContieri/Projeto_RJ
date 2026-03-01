using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class modalFecharSistema : Form
    {
        public modalFecharSistema()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e) //botao de sim DO MENU
        {
            SessaoUsuario.LimparSessao();
            
        }

        private void label1_Click(object sender, EventArgs e) 
        {

        }

        private void modalFecharSistema_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //botao de nao DO MENU
        {

        }

        private void modalFecharSistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            

        }

        private void modalFecharSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }
    }
}
