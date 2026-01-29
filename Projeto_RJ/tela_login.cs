using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
        }

        private void containerImagem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_header_login_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e) //lbl_usuariio
        {

        }

        private void txt_usuario_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_senha_login_Click(object sender, EventArgs e)
        {

        }

        private void txt_senha_login_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void GravarLogInterno(string mensagem)
        {
            try
            {
                string caminhoLog = AppDomain.CurrentDomain.BaseDirectory + "log_acessos.txt";
                string linhaLog = $"[{DateTime.Now:dd/MM/yyyy HH:mm:ss}] - {mensagem}{Environment.NewLine}";

                // Adiciona a linha ao arquivo sem apagar o que já existe
                System.IO.File.AppendAllText(caminhoLog, linhaLog);
            }
            catch { /* Falha silenciosa para não travar o login */ }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // 1. SQL busca pelo usuário
            string sql = "SELECT id, nome, usuario, senha, email, acesso, imgbase64 FROM usuarios WHERE usuario = @user";

            using (SqlConnection con = new SqlConnection(@"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@user", txt_usuario_login.Text.Trim());

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // O usuário EXISTE no banco
                    {
                        // Pegamos a senha do banco e o que foi digitado, removendo espaços extras
                        string senhaBanco = reader["senha"].ToString().Trim();

                        // IMPORTANTE: Mudei de lbl_senha_login para txt_senha_login (ajuste o nome se necessário)
                        string senhaDigitada = txt_senha_login.Text.Trim();

                        // 2. Verificação Exata da Senha
                        if (senhaBanco.Equals(senhaDigitada))
                        {
                            // SUCESSO: Alimenta a sessão global
                            SessaoUsuario.Id = Convert.ToInt32(reader["id"]);
                            SessaoUsuario.Nome = reader["nome"].ToString();
                            SessaoUsuario.Login = reader["usuario"].ToString();
                            SessaoUsuario.Email = reader["email"].ToString();
                            SessaoUsuario.NivelAcesso = reader["acesso"].ToString();
                            SessaoUsuario.FotoBase64 = reader["imgbase64"].ToString();

                            this.Hide();
                            using (frm_ADM principal = new frm_ADM())
                            {
                                principal.ShowDialog();
                            }
                            this.Close();
                        }
                        else
                        {
                            // LOG: Senha errada
                            GravarLogInterno($"Falha: Senha incorreta para o usuário '{txt_usuario_login.Text}'.");
                            MessageBox.Show("Senha incorreta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_senha_login.Clear();
                            txt_senha_login.Focus();
                        }
                    }
                    else
                    {
                        // LOG: Usuário não existe
                        GravarLogInterno($"Falha: Usuário '{txt_usuario_login.Text}' não encontrado.");
                        MessageBox.Show("Usuário não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_usuario_login.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro técnico de conexão: " + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caminhoLog = AppDomain.CurrentDomain.BaseDirectory + "log_acessos.txt";

            if (System.IO.File.Exists(caminhoLog))
            {
                System.Diagnostics.Process.Start("notepad.exe", caminhoLog);
            }
            else
            {
                MessageBox.Show("Ainda não existem registros de log.");
            }
        }
    }
}
