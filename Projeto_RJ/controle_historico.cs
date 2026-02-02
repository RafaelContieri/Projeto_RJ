using System;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class controle_historico : UserControl
    {
        public controle_historico()
        {
            InitializeComponent();
        }

        // Dentro do seu controle_historico.cs
        public void Configurar(string numeroSenha, string nomeGuiche)
        {
            lbl_senhaBanco.Text = numeroSenha;  // Define o texto da label de senha
            lbl_guiche_banco.Text = nomeGuiche; // Define o texto da label de guichê
        }

        private void lbl_senha_hist_Click(object sender, EventArgs e) //hist ==> nome da senha do historico de senhas
        {

        }

        private void lbl_mesa_hist_Click(object sender, EventArgs e)
        {

        }

        private void lbl_guiche_hist_Click(object sender, EventArgs e)
        {

        }

       

        private void lbl_mesa_banco_Click(object sender, EventArgs e)
        {

        }

        private void lbl_guiche_banco_Click(object sender, EventArgs e)
        {

        }

        private void controle_historico_Load(object sender, EventArgs e)
        {

        }

        private void lbl_senhaBanco_Click(object sender, EventArgs e)
        {

        }
    }
}
