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
    public partial class frm_modalCadastro : Form
    {
        public frm_modalCadastro()
        {
            InitializeComponent();
        }

        public class Usuario
        {
            public string Nome { get; set; }
            public string Login { get; set; }
            public string Senha { get; set; }
            public string Email { get; set; }
            public string Sigla { get; set; } 
            public string Grupo { get; set; } 
            // public string CaminhoFoto (Opcional por enquanto)
        }

        // AQUI FICA O BANCO DE DADOS
        public static class BancoDados
        {
            public static List<Usuario> ListaUsuarios = new List<Usuario>();
        }
    


    private void lbl_nome_usuario_Click(object sender, EventArgs e)
        {

        }

        private void frm_modalCadastro_Load(object sender, EventArgs e)
        {
            btn_excluir_foto.Enabled = false;
            btnRefresh.Enabled = false;
            btn_upload_picture.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Para o código aqui e não salva
            }

            // CRIAÇÃO: Monta o boneco do usuário com os dados da tela
            Usuario novoUser = new Usuario();
            novoUser.Nome = txtNome.Text;
            novoUser.Email = txtEmail.Text;
            novoUser.Login = txtLogin.Text;
            novoUser.Senha = txtSenha.Text;
            novoUser.Sigla = txtSigla.Text;
            novoUser.Grupo = txtGrupoUsuario.Text;


            // GRAVAÇÃO: Joga o usuário dentro da nossa lista estática
            BancoDados.ListaUsuarios.Add(novoUser);

            // SUCESSO: Avisa e limpa a tela
            MessageBox.Show($"Usuário {novoUser.Nome} cadastrado com sucesso!", "Sucesso");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtSigla.Text = "";
            txtGrupoUsuario.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_upload_picture_Click(object sender, EventArgs e)
        {
            btn_excluir_foto.Enabled = true;
            btnRefresh.Enabled = true;
            btn_upload_picture.Enabled = false;
        }
    }
}
