using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_RJ.frm_modalCadastro;

namespace Projeto_RJ
{
    public partial class frm_telaLogin : Form
    {
        public frm_telaLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string loginDigitado = txt_usuario.Text; 
            string senhaDigitada = txt_senha.Text;

            var usuarioEncontrado = BancoDados.ListaUsuarios.FirstOrDefault(u => u.Login == loginDigitado && u.Senha == senhaDigitada);

            if (usuarioEncontrado != null) 
            {
                MessageBox.Show($"Bem-vindo, {usuarioEncontrado.Nome}!", "Login Realizado");

                // AQUI VOCÊ ABRE A TELA PRINCIPAL
                // Exemplo:
                // frm_painelInicial principal = new frm_painelInicial();
                // principal.Show();

                // Esconde a tela de login
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario ou Senha incorretos", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_telaLogin_Load(object sender, EventArgs e)
        {
            
            // Teste de Login
            Usuario adminTeste = new Usuario();
            adminTeste.Nome = "Administrador";
            adminTeste.Login = "admin";
            adminTeste.Senha = "123";
            adminTeste.Sigla = "ADM";
            adminTeste.Grupo = "Administradores";

            BancoDados.ListaUsuarios.Add(adminTeste);
        }
    }
}
