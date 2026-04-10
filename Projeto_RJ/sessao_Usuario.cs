using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public static class SessaoUsuario
    {
        public static int Id { get; set; }
        public static string Nome { get; set; }
        public static string Login { get; set; }
        public static string Email { get; set; }
        public static string NivelAcesso { get; set; }
        public static string FotoBase64 { get; set; }
        public static char logado { get; set; }
        public static string tipoAtendimento { get; set; } // define qual o tipo de atendimento do usuário, se é normal ou prioritário {exporta para o "funcaoMesa" utilizar}
        public static string servico { get; set; } // define qual o serviço do usuário, se é recepção, atendimento ou administrativo {exporta para o "funcaoMesa" utilizar}

        public static void LimparSessao()
        {

            DeslogarUsuario();


            Id = 0;
            Nome = null;
            Login = null;
            Email = null;
            NivelAcesso = null;
            FotoBase64 = null;
            logado = 'N';
        }

        public static void fecharSistema()
        {

            LimparSessao();


            Application.Exit();
        }

        public static void DeslogarUsuario()
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);"))
            {
                string sql = "UPDATE usuarios SET usuarioLogado = 'N' WHERE id = @id";
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao encerrar sessão no banco: " + ex.Message);
                }
            }
        }

        public static void deslogarEFecharSistema()
        {
            DeslogarUsuario();
            fecharSistema();
        }

    }
}