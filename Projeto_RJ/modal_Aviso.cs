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
    public partial class modalError : Form
    {
        public modalError()
        {
            InitializeComponent();
        }

        private void lblNomeMedico_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e) //botao de sim
        {
            SessaoUsuario.LimparSessao();
            this.DialogResult = DialogResult.No; // Define o resultado
            this.Close(); // Fecha apenas esta janela (o modal)
        }

        private void modalError_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //corrigir aqui para o botão de não, para fechar apenas o modal
        {
            
        }
    }
}
