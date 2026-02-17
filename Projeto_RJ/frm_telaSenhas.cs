using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_telaSenhas : Form
    {
        string strCon = @"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";
        //private int ultimaSenhaId = 0;

        public static frm_telaSenhas Instancia;

        public frm_telaSenhas()
        {
            InitializeComponent();
            Instancia = this; // Define a instância atual para acesso global
            painelUltimasSenhas(); // Carrega o histórico de senhas ao abrir o telão

        }

       

        public void ReceberNovaSenha(string senhaTelao, string guicheTelao)
        {
            // Atualiza as labels na TV instantaneamente
            lbl_senhaDB.Text = senhaTelao;
            lbl_guicheDB.Text = guicheTelao;

            // Dica de ADS: Como não tem mais Timer, você pode adicionar um efeito visual aqui
            // para mostrar que a senha acabou de mudar.
        }

        private void frm_telaSenhas_Load(object sender, EventArgs e)
        {
            
        }


        public void painelUltimasSenhas() // histórico das senhas
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    // IMPORTANTE: Abrir a conexão!
                    con.Open();

                    string sqlHist = @"SELECT senha, tipo_atendimento, id , status_atendimento
                                       FROM Senhas 
                                       WHERE data_geracao = CAST(GETDATE() AS DATE)
                                       AND status_atendimento = 'Chamado'
                                       ORDER BY id DESC;";

                    SqlCommand cmdHist = new SqlCommand(sqlHist, con);

                    // Limpa o container da tela de controle
                    flow_historico.Controls.Clear();

                    using (SqlDataReader readerHist = cmdHist.ExecuteReader())
                    {
                        while (readerHist.Read())
                        {
                            //cria o card com os valores do banco
                            controle_historico card = new controle_historico();

                            // insere os valores do banco no card
                            string senhaVal = readerHist["senha"].ToString();
                            string localVal = readerHist["tipo_atendimento"].ToString();

                            // Configura o card com os valores do banco
                            card.configurarSenhas(senhaVal, localVal);

                            // define a visibilidade do status "No Card" como falsa, já que temos dados para exibir
                            card.StatusNoCard.Visible = false;

                            // Adiciona o card ao container do controle
                            flow_historico.Controls.Add(card);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao carregar histórico no controle: " + ex.Message);
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {

            
        }
        private void lbl_senhaDB_Click(object sender, EventArgs e) {
        
            //atualizarCampos(new frm_controleSenhas());
        }
              
        private void lbl_senha_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lbl_mesaDB_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void lbl_guicheDB_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void flow_historico_Paint(object sender, PaintEventArgs e) { // painel de senhas
        
            
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void frm_telaSenhas_Load_1(object sender, EventArgs e)
        {

        }
    }
}