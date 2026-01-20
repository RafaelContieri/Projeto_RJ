using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class telaInicial : Form
    {
     

public string CriarSenha(string tipo, string servico)
    {
        // Conexão SQL Server (Data Source utiliza vírgula para porta no SQL Server)
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


    public object frmInicial_Load { get; private set; }

        public telaInicial()
        {
            InitializeComponent();
        }

        private void lbl_name_header_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_header_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e) //botao de recepção normal

        
        {
            // 1. Chama o método e guarda o texto da senha recepção
            string senhaGerada = CriarSenha("Normal", "Recepção");

            if (!string.IsNullOrEmpty(senhaGerada))
            {
                // Passamos a senha para dentro dos parênteses do modalSucess E AO CARREGAR O MODAL, ELE JÁ EXIBE A SENHA DEFINIDA COMO UM PARÂMETRO
                modalSucess telaSucesso = new modalSucess(senhaGerada);
                telaSucesso.ShowDialog();
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 tela = new Form1();

            tela.ShowDialog();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e) //btn entrega de exames normal
        {
            string senhaGerada = CriarSenha("Normal", "Exames");

            if (!string.IsNullOrEmpty(senhaGerada))
            {
                // Passamos a senha para dentro dos parênteses do modalSucess E AO CARREGAR O MODAL, ELE JÁ EXIBE A SENHA DEFINIDA COMO UM PARÂMETRO
                modalSucess telaSucesso = new modalSucess(senhaGerada);
                telaSucesso.ShowDialog();
            }

            //GerarSenhaNoBanco("Normal", "Recepção"); // ==> definimos que o tipo de senha é Normal e o setor é Entrega de exames
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {

        }
    }

}
