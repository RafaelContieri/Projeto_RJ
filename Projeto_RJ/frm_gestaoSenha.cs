using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_RJ
{
    public partial class frm_gestaoSenha : Form
    {
        public frm_gestaoSenha()
        {
            InitializeComponent();
            CarregarDadosDoBanco();
        }

        private void frm_gestaoSenha_Load(object sender, EventArgs e)
        {
            this.MouseLeave += new EventHandler(sideBar1.container_pai_Leave);
        }

        //---------------------------------------------------------------------ATENDIMENTO TOTAL --------------------------------------------------------------------//

        private void lbl_atTotal_Click(object sender, EventArgs e)
        {
            // NOME DA LABEL DA SENHA
        }

        private void lbl_quantidade_Click(object sender, EventArgs e)
        {
            // QUANTIDADE DE ATENDIMENTOS PUXADA VIA BANCO EX: lbl_quantidade.Text = "quantidade puxada via banco(25)";
            


        }

        private void lbl_qtdPessoas_Click(object sender, EventArgs e)
        {
            // IF ELSE PARA SABER SE É PESSOA OU PESSOAS EX: NUMERO = 1 ? lbl_qtdPessoas.Text = "pessoa" : lbl_qtdPessoas.Text = "pessoas";
        }


        //--------------------------------------------------------------------- RECEPÇÃO --------------------------------------------------------------------//



        private void label3_Click(object sender, EventArgs e)
        {
            // NOME DA LABEL DA SENHA
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // QUANTIDADE DE ATENDIMENTOS PUXADA VIA BANCO EX: lbl_quantidade.Text = "quantidade puxada via banco(25)";

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // IF ELSE PARA SABER SE É PESSOA OU PESSOAS EX: NUMERO = 1 ? lbl_qtdPessoas.Text = "pessoa" : lbl_qtdPessoas.Text = "pessoas";

        }

        //--------------------------------------------------------------------- RETIRADA DE EXAMES --------------------------------------------------------------------//


        private void label6_Click(object sender, EventArgs e)
        {
            // NOME DA LABEL DA SENHA

        }

        private void label4_Click(object sender, EventArgs e)
        {
            // QUANTIDADE DE ATENDIMENTOS PUXADA VIA BANCO EX: lbl_quantidade.Text = "quantidade puxada via banco(25)";

        }


        private void label5_Click(object sender, EventArgs e)
        {
            // IF ELSE PARA SABER SE É PESSOA OU PESSOAS EX: NUMERO = 1 ? lbl_qtdPessoas.Text = "pessoa" : lbl_qtdPessoas.Text = "pessoas";

        }

        //--------------------------------------------------------------------- PREFERÊNCIAL --------------------------------------------------------------------//


        private void label9_Click(object sender, EventArgs e)
        {
            // NOME DA LABEL DA SENHA

        }

        private void label7_Click(object sender, EventArgs e)
        {
            // QUANTIDADE DE ATENDIMENTOS PUXADA VIA BANCO EX: lbl_quantidade.Text = "quantidade puxada via banco(25)";

        }

        private void label8_Click(object sender, EventArgs e)
        {
            // IF ELSE PARA SABER SE É PESSOA OU PESSOAS EX: NUMERO = 1 ? lbl_qtdPessoas.Text = "pessoa" : lbl_qtdPessoas.Text = "pessoas";

        }

        //--------------------------------------------------------------------- BOTÃO DE ATUALIZAR --------------------------------------------------------------------//


        private void button1_Click(object sender, EventArgs e)
        {
            //BOTAO PARA ATUALIZAR AS INFORMAÇÕES DA TELA OU FAZER ESQUEMA AUTOMATICO DE PUSHAR AS INFORMAÇÕES
            CarregarDadosDoBanco();

        }

        private void CarregarDadosDoBanco()
        {
            string stringConexao = @"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$)";

            try
            {
                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();

                    
                    string sqlTotal = "SELECT COUNT(*) FROM Senhas WHERE CAST(data_geracao AS DATE) = CAST(GETDATE() AS DATE);";
                    int total = (int)new SqlCommand(sqlTotal, conexao).ExecuteScalar();

                    
                    string sqlRecepcao = "SELECT COUNT(*) FROM Senhas WHERE servico = 'Recepção' AND CAST(data_geracao AS DATE) = CAST(GETDATE() AS DATE);";
                    int recepcao = (int)new SqlCommand(sqlRecepcao, conexao).ExecuteScalar();

                    
                    string sqlRetirada = "SELECT COUNT(*) FROM Senhas WHERE servico = 'Exames' AND CAST(data_geracao AS DATE) = CAST(GETDATE() AS DATE);";
                    int retirada = (int)new SqlCommand(sqlRetirada, conexao).ExecuteScalar();

                    
                    string sqlPref = "SELECT COUNT(*) FROM Senhas WHERE tipo_atendimento = 'Preferencial' AND CAST(data_geracao AS DATE) = CAST(GETDATE() AS DATE);";
                    int preferencial = (int)new SqlCommand(sqlPref, conexao).ExecuteScalar();

                    // Atualização das Labels
                    lblTotal.Text = total.ToString();
                    lblRecepcao.Text = recepcao.ToString();
                    lblRetiradaExames.Text = retirada.ToString();
                    lblPreferencial.Text = preferencial.ToString();

                    // Lógica de Plural/Singular simplificada (Operador Ternário)
                    lbl_qtdPessoas.Text = (total == 1) ? "PESSOA" : "PESSOAS";
                    lbl_pessoas.Text = (recepcao == 1) ? "PESSOA" : "PESSOAS";
                    label5.Text = (retirada == 1) ? "PESSOA" : "PESSOAS";
                    label8.Text = (preferencial == 1) ? "PESSOA" : "PESSOAS";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar indicadores: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel_atendimentoTotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            sideBar1.Visible = true;
        }
        

        private void sideBar1_Load(object sender, EventArgs e)
        {

        }
    }
}
