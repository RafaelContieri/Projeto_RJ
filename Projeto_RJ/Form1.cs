using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class Form1 : Form
    {
        public string CriarSenha(string tipo, string servico)
        {
            // String de conexão (sem senha conforme seu ambiente)
            string strCon = "Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";
            string senhaFinal = "";

            // 2. Trocado de MySqlConnection para SqlConnection
            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    // 3. Trocado de MySqlCommand para SqlCommand
                    SqlCommand cmd = new SqlCommand("sp_GerarSenhaTotem", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parâmetros para SQL Server (geralmente usam @ sem o 'p_')
                    cmd.Parameters.AddWithValue("@p_tipo", tipo);
                    cmd.Parameters.AddWithValue("@p_servico", servico);

                    con.Open();

                    Console.WriteLine($"[LOG {DateTime.Now}]: Tentando gerar senha para {tipo} - {servico}...");

                    var resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        senhaFinal = resultado.ToString();
                        Console.WriteLine($"[LOG SUCCESS]: Banco retornou a senha: {senhaFinal}");
                    }
                }
                // 4. Trocado de MySqlException para SqlException
                catch (SqlException sqlEx)
                {
                    Console.WriteLine($"[LOG SQL SERVER ERROR]: {sqlEx.Number} - {sqlEx.Message}");
                    MessageBox.Show("Erro no SQL Server: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[LOG GENERAL ERROR]: {ex.Message}");
                    MessageBox.Show("Erro Geral: " + ex.Message);
                }
            }
            return senhaFinal;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_preferencial_Click(object sender, EventArgs e)
        {
            Width = 19;
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIniciar_Click(object sender, EventArgs e) // btn entrega de exames preferencial
        {
            string senhaGerada = CriarSenha("Preferencial", "Recepção");

            if (!string.IsNullOrEmpty(senhaGerada))
            {
                // Passamos a senha para dentro dos parênteses do modalSucess E AO CARREGAR O MODAL, ELE JÁ EXIBE A SENHA DEFINIDA COMO UM PARÂMETRO
                modalSucess telaSucesso = new modalSucess(senhaGerada);
                telaSucesso.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string senhaGerada = CriarSenha("Preferencial", "Exames");

            if (!string.IsNullOrEmpty(senhaGerada))
            {
                // Passamos a senha para dentro dos parênteses do modalSucess E AO CARREGAR O MODAL, ELE JÁ EXIBE A SENHA DEFINIDA COMO UM PARÂMETRO
                modalSucess telaSucesso = new modalSucess(senhaGerada);
                telaSucesso.Show();
            }

            // GerarSenhaNoBanco("Preferencial", "Entrega de exames"); // Chamar função para gerar senha no banco
        }
    }
}
