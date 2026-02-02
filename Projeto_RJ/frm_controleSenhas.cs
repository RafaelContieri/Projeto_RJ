using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_controleSenhas : Form
    {
        string strCon = @"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";

        public frm_controleSenhas()
        {
            InitializeComponent();
            CarregarSenhasPendentes();
        }

        private void frm_controleSenhas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_rjDataSet8.senhas'. Você pode movê-la ou removê-la conforme necessário.
            this.senhasTableAdapter.Fill(this.projeto_rjDataSet8.senhas);
            // Busca o histórico assim que abrir a tela de controle
            ultimasSenhas();
        }

        private void ultimasSenhas()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    // IMPORTANTE: Abrir a conexão!
                    con.Open();

                    string sqlHist = @"SELECT senha, tipo_atendimento FROM Senhas 
                                      WHERE CAST(data_criacao AS DATE) = CAST(GETDATE() AS DATE) 
                                      ORDER BY id DESC OFFSET 1 ROWS FETCH NEXT 5 ROWS ONLY";

                    SqlCommand cmdHist = new SqlCommand(sqlHist, con);

                    // Limpa o container da tela de controle
                    container_Senhas.Controls.Clear();

                    using (SqlDataReader readerHist = cmdHist.ExecuteReader())
                    {
                        while (readerHist.Read())
                        {
                            controle_historico card = new controle_historico();

                            string senhaVal = readerHist["senha"].ToString();
                            string localVal = readerHist["tipo_atendimento"].ToString();

                            card.Configurar(senhaVal, localVal);
                            container_Senhas.Controls.Add(card);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao carregar histórico no controle: " + ex.Message);
                }
            }
        }

        // Simulação de chamada de nova senha
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // 1. Aqui você terá seu código de INSERT no banco SQL Server
            // InserirSenhaNoBanco();

            // 2. Após inserir, você atualiza o histórico desta tela na hora
            ultimasSenhas();
        }

        // --- MÉTODOS ORIGINAIS MANTIDOS ---
        private void lblSenhaAtual_Click(object sender, EventArgs e)
        {
            // Exemplo visual
            lblSenhaAtual.Text = "P005";
        }

        private void lbl_name_header_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CarregarSenhasPendentes()
        {
            // Exemplo de variáveis que viriam do seu sistema de login
            string tipoGuicheUsuario = "Preferencial"; // Ou "Normal"
            string servicoUsuario = "Recepção";        // Ou "Entrega de Exames"

            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    con.Open();

                    // SQL que filtra por Status, Tipo de Atendimento e Serviço
                    // De acordo com a sua imagem do banco
                    string sql = @"SELECT id, senha, tipo_atendimento, servico, data_geracao 
                           FROM Senhas 
                           WHERE status_atendimento = 'Pendente' 
                           AND tipo_atendimento = @tipo 
                           AND servico = @servico 
                           ORDER BY id ASC";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@tipo", tipoGuicheUsuario);
                    cmd.Parameters.AddWithValue("@servico", servicoUsuario);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Vincula o resultado ao seu DataGridView
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar lista: " + ex.Message);
                }
            }
        }



        private void panel_senhaChamada_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_refreshSenha_Click(object sender, EventArgs e)
        {

        }

        private void lbl_senhaChamada_Click(object sender, EventArgs e)
        {

        }

        private void lbl_selecionarServico_Click(object sender, EventArgs e)
        {

        }

        private void comb_tipoGuiche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbl_chamarSenha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_senhasChamadas_Click(object sender, EventArgs e)
        {

        }

        private void tbl_historicoSenhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void container_Senhas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}