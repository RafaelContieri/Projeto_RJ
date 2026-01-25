using System;
using System.Collections.Generic;
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

        public void frm_modalCadastro_Load(object sender, EventArgs e) //aplicar lógica para que, quando a imagem nao estiver carregada, os botões de excluir e refresh fiquem desabilitados
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_rjDataSet7.acessos'. Você pode movê-la ou removê-la conforme necessário.
            this.acessosTableAdapter.Fill(this.projeto_rjDataSet7.acessos);

            if (picture_imagemUsuario == null) //se a imagem estiver vazia
            {
                btn_excluir_foto.Enabled = false;
                btn_upload_picture.Enabled = true;
            }
            else //se a imagem estiver carregada
            {
                btn_excluir_foto.Enabled = true;
                btn_upload_picture.Enabled = false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e) // BOTÃO SALVAR USUÁRIO
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
            novoUser.Grupo = cmb_Grupo_usuario.Text;


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
            cmb_Grupo_usuario.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_upload_picture_Click(object sender, EventArgs e)
        {
            
        }

        private void picture_imagemUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_upload_picture_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_excluir_foto_Click(object sender, EventArgs e)
        {

        }


    }
}
