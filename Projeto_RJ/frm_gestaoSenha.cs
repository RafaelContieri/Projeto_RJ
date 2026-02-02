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
            // LÓGICA PARA CARREGAR OS DADOS DO BANCO DE DADOS E ATUALIZAR AS LABELS NA TELA
            
            string stringConexao = @"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$)";

            try
            {
                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();

                    // 1. Total Geral (Hoje)
                    string sqlTotal = "SELECT COUNT(*) FROM Senhas WHERE CAST(data_criacao AS DATE) = CAST(GETDATE() AS DATE);";
                    int total = (int)new SqlCommand(sqlTotal, conexao).ExecuteScalar();

                    // 2. Total Recepção (Hoje)
                    string sqlRecepcao = "SELECT COUNT(*) FROM Senhas WHERE Servico = 'Recepção' AND CAST(data_criacao AS DATE) = CAST(GETDATE() AS DATE);";
                    int recepcao = (int)new SqlCommand(sqlRecepcao, conexao).ExecuteScalar();

                    // 3. Total Retirada de Exames (Hoje) - Ajustado para filtrar data
                    string sqlRetirada = "SELECT COUNT(*) FROM Senhas WHERE Servico = 'Exames' AND CAST(data_criacao AS DATE) = CAST(GETDATE() AS DATE);";
                    int retirada = (int)new SqlCommand(sqlRetirada, conexao).ExecuteScalar();

                    // 4. Total Preferencial (Hoje) - Ajustado para data e otimização de busca
                    // Dica: Se o serviço sempre termina com 'Preferencial', use o LIKE de forma segura
                    string sqlPref = "SELECT COUNT(*) FROM Senhas WHERE Servico LIKE '%Preferencial%' AND CAST(data_criacao AS DATE) = CAST(GETDATE() AS DATE);";
                    int preferencial = (int)new SqlCommand(sqlPref, conexao).ExecuteScalar();



                    lblTotal.Text = total.ToString();
                    lblRecepcao.Text = recepcao.ToString();
                    lblRetiradaExames.Text = retirada.ToString();
                    lblPreferencial.Text = preferencial.ToString();

                    // Lógica do Plural/Singular 
                    if (total == 1)
                    {
                        lbl_qtdPessoas.Text = "PESSOA";
                    }
                    else
                    {
                        lbl_qtdPessoas.Text = "PESSOAS";
                    }
                    if (recepcao == 1)
                    {
                        lbl_pessoas.Text = "PESSOA";
                    }
                    else
                    {
                        lbl_pessoas.Text = "PESSOAS";
                    }
                    if (retirada == 1)
                    {
                        label5.Text = "PESSOA";
                    }
                    else
                    {
                        label5.Text = "PESSOAS";
                    }
                    if (preferencial == 1)
                    {
                        label8.Text = "PESSOA";
                    }
                    else
                    {
                        label8.Text = "PESSOAS";
                    }

                    // Centraliza o texto 
                    lbl_qtdPessoas.TextAlign = ContentAlignment.MiddleCenter;
                    lbl_pessoas.TextAlign = ContentAlignment.MiddleCenter;
                    label5.TextAlign = ContentAlignment.MiddleCenter;
                    label8.TextAlign = ContentAlignment.MiddleCenter;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar no banco: " + ex.Message);
            }

            

           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel_atendimentoTotal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
