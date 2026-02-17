using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class controle_historico : UserControl
    {
        public controle_historico()
        {
            InitializeComponent();
        }

        
        public Label StatusNoCard
        {
            get { return lbl_statusSenha; }
        }

        //public string status { get; private set; } // Variável para armazenar o status da senha

        // Dentro do seu controle_historico.cs
        public void Configurar(string numeroSenha, string nomeGuiche, string status)
        {
            // 1. Atribui os valores básicos
            lbl_senhaBanco.Text = numeroSenha;
            lbl_guiche_banco.Text = nomeGuiche;

            // 2. Valida o parâmetro 'status' que chegou, não o texto da label atual
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Atenção: O status da senha veio vazio do banco de dados.");
                label1.Text = "Sem Status";
            }
            else
            {
                label1.Text = status; // Define o status (ex: "Chamado" ou "Aguardando"
            }
        }

        // CARD EXCLUSIVO PARA TELÃO DAS SENHAS ==> SEM STATUS DA SENHA

        public string statuSenhaTelao { get; private set; } // Variável para armazenar o status da senha

        // Dentro do seu controle_historico.cs
        public void configurarSenhas (string numeroSenha1, string nomeGuiche1)
        {
            // 1. Atribui os valores básicos
            lbl_senhaBanco.Text = numeroSenha1;
            lbl_guiche_banco.Text = nomeGuiche1;
            
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

        public void lbl_statusSenha_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label1_Click(object sender, EventArgs e) //label recebe status da senha
        {

        }
    }
}
