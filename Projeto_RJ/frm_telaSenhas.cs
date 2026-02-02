using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_telaSenhas : Form
    {
        string strCon = @"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";
        private int ultimaSenhaId = 0;

        public frm_telaSenhas()
        {
            InitializeComponent();
            AtualizarPainel();
        }

        private void frm_telaSenhas_Load(object sender, EventArgs e)
        {
            // Configura o timer para 3 segundos
            timer1.Interval = 3000;
            timer1.Start();

            // Chamada inicial
            AtualizarPainel();
        }

        // --- MOTOR: Vincule este evento ao Timer1 no Designer ---
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Configura o seu timer de atualização de dados para 3 segundos
            timer1.Interval = 3000;
            timer1.Start();
            // Busca as senhas
            AtualizarPainel();
        }

        private void AtualizarPainel()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    con.Open();

                    // 1. BUSCA A SENHA ATUAL (DESTAQUE)
                    string sqlAtual = "SELECT TOP 1 id, senha, tipo_atendimento FROM Senhas WHERE CAST(data_criacao AS DATE) = CAST(GETDATE() AS DATE) ORDER BY id DESC";
                    SqlCommand cmdAtual = new SqlCommand(sqlAtual, con);

                    using (SqlDataReader reader = cmdAtual.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idNoBanco = Convert.ToInt32(reader["id"]);

                            if (idNoBanco != ultimaSenhaId)
                            {
                                ultimaSenhaId = idNoBanco;
                                lbl_senhaDB.Text = reader["senha"].ToString();
                                lbl_guicheDB.Text =  reader["tipo_atendimento"].ToString();
                            }
                        }
                    }

                    // 2. BUSCA O HISTÓRICO (ÁREA LARANJA)
                    // Ajustado para bater com seu novo SQL (senha e servico)
                    string sqlHist = @"SELECT senha, tipo_atendimento FROM Senhas 
                                      WHERE CAST(data_criacao AS DATE) = CAST(GETDATE() AS DATE) 
                                      ORDER BY id DESC OFFSET 1 ROWS FETCH NEXT 5 ROWS ONLY";

                    SqlCommand cmdHist = new SqlCommand(sqlHist, con);
                    flow_historico.Controls.Clear();

                    using (SqlDataReader readerHist = cmdHist.ExecuteReader())
                    {
                        while (readerHist.Read())
                        {
                            controle_historico card = new controle_historico();

                            // Corrigido para os nomes de colunas que você definiu no SQL acima
                            string senhaVal = readerHist["senha"].ToString();
                            string localVal = readerHist["tipo_atendimento"].ToString();

                            card.Configurar(senhaVal, localVal);
                            flow_historico.Controls.Add(card);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro de rede: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {

            
        }
        private void lbl_senhaDB_Click(object sender, EventArgs e) { }
        private void lbl_senha_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lbl_mesaDB_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void lbl_guicheDB_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void flow_historico_Paint(object sender, PaintEventArgs e) { }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void frm_telaSenhas_Load_1(object sender, EventArgs e)
        {

        }
    }
}