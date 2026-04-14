using Mysqlx.Crud;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
            this.AcceptButton = btn_login; // Define o botão Entrar como o botão padrão ao pressionar Enter
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


        public void btn_login_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id, nome, usuario, senha, email, id_acesso, id_servico, id_tipoAtendimento, imgbase64, usuarioLogado FROM usuarios WHERE usuario = @user";
            string sqlUpdate = "UPDATE usuarios SET usuarioLogado = 'S' WHERE id = @id";

            using (SqlConnection con = new SqlConnection(@"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@user", txt_usuario_login.Text.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashBanco = reader["senha"].ToString().Trim();
                            string senhaDigitada = txt_senha_login.Text.Trim();

                            if (BCrypt.Net.BCrypt.Verify(senhaDigitada, hashBanco))
                            {
                                // Alimentação da sessão com tratamento de nulos
                                SessaoUsuario.Id = Convert.ToInt32(reader["id"]);
                                SessaoUsuario.Nome = reader["nome"]?.ToString() ?? "";
                                SessaoUsuario.Login = reader["usuario"]?.ToString() ?? "";
                                SessaoUsuario.Email = reader["email"]?.ToString() ?? "";
                                SessaoUsuario.NivelAcesso = reader["id_acesso"] == DBNull.Value ? "0" : reader["id_acesso"].ToString();
                                SessaoUsuario.servico = reader["id_servico"] == DBNull.Value ? "0" : reader["id_servico"].ToString();
                                SessaoUsuario.tipoAtendimento = reader["id_tipoAtendimento"] == DBNull.Value ? "0" : reader["id_tipoAtendimento"].ToString();
                                SessaoUsuario.FotoBase64 = reader["imgbase64"]?.ToString() ?? "";

                                reader.Close();

                                // Atualiza status para 'S' (Logado)
                                using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@id", SessaoUsuario.Id);
                                    cmdUpdate.ExecuteNonQuery();
                                }

                                this.Hide();
                                using (frm_ADM principal = new frm_ADM())
                                {
                                    principal.ShowDialog();
                                    
                                }
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha inválidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // --- LOG DETALHADO NO CONSOLE ---
                    Console.WriteLine("\n[LOG DE ERRO CRÍTICO - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "]");
                    Console.WriteLine("Local: btn_login_Click");
                    Console.WriteLine("Mensagem: " + ex.Message);
                    Console.WriteLine("Rastro do Erro: " + ex.StackTrace);
                    Console.WriteLine("--------------------------------------------------\n");

                    // --- AVISO AO USUÁRIO ---
                    MessageBox.Show(
                        "Erro técnico: " + ex.Message + Environment.NewLine + Environment.NewLine +
                        "ID ACESSO: " + SessaoUsuario.NivelAcesso,
                        "Erro Crítico",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                    );
                }
            }
        }

        public void DeslogarUsuario()

        {
            // Usamos o ID que está salvo na memória desde o Login
            int idUsuario = SessaoUsuario.Id;


            using (SqlConnection con = new SqlConnection(@"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);"))
            {
                string sql = "UPDATE usuarios SET usuarioLogado = 'N' WHERE id = @id";
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao encerrar sessão no banco: " + ex.Message);
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

        private void tela_login_Load(object sender, EventArgs e)
        {

        }

        private void panel_container_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //pictureBox3.BackColor = Color.Transparent;
        }

        private void txt_usuario_login_TextChanged_1(object sender, EventArgs e)
        {

        }

        

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_header_login_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_senha_login_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public void btn_login_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
