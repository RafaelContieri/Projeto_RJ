using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public string CriarSenha(string tipo, string servico)
        {
            // String de conexão (sem senha conforme seu ambiente)
            string strCon = "Server=127.0.0.1;Database=projeto_rj;Uid=root;Pwd=;";
            string senhaFinal = "";

            using (MySqlConnection con = new MySqlConnection(strCon))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("sp_GerarSenhaTotem", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_tipo", tipo);
                    cmd.Parameters.AddWithValue("@p_servico", servico);

                    con.Open();

                    // Log de Conexão no Console
                    Console.WriteLine($"[LOG {DateTime.Now}]: Tentando gerar senha para {tipo} - {servico}...");

                    var resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        senhaFinal = resultado.ToString();

                        // 1. LOG NO CONSOLE (Aparece na aba 'Output' do Visual Studio)
                        Console.WriteLine($"[LOG SUCCESS]: Banco retornou a senha: {senhaFinal}");


                    }

                }
                catch (MySqlException myEx)
                {
                    // Log específico para erros de banco de dados
                    Console.WriteLine($"[LOG MYSQL ERROR]: {myEx.Number} - {myEx.Message}");
                    MessageBox.Show("Erro no MySQL: " + myEx.Message);
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
            string senhaGerada = CriarSenha("Preferêncial", "Recepção");

            if (!string.IsNullOrEmpty(senhaGerada))
            {
                // Passamos a senha para dentro dos parênteses do modalSucess E AO CARREGAR O MODAL, ELE JÁ EXIBE A SENHA DEFINIDA COMO UM PARÂMETRO
                modalSucess telaSucesso = new modalSucess(senhaGerada);
                telaSucesso.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string senhaGerada = CriarSenha("Preferêncial", "Exames");

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
