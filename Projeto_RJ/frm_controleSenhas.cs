using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_controleSenhas : Form
    {
        string strCon = @"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";
        public frm_controleSenhas()
        {
            InitializeComponent();
        }

        string senhaId = "";

        public string senhaTelao { get; private set; }
        public string guicheTelao { get; private set; }

        public string statusSENHA { get; private set; }



        


        // Variável global para manter o link com o telão aberto
        public frm_telaSenhas telaoAberto;


        private void frm_controleSenhas_Load(object sender, EventArgs e)
        {
            
            ultimasSenhas();      
            carregarDADOSGRID();  
            
        }

        private void ultimasSenhas() // Método para carregar o histórico de senhas do dia no controle de histórico
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    
                    con.Open();

                    string sqlHist = @"SELECT senha, tipo_atendimento, id , status_atendimento
                                       FROM Senhas 
                                       WHERE data_geracao = CAST(GETDATE() AS DATE)
                                       AND status_atendimento = 'Chamado'
                                       ORDER BY id DESC;";

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
                            string statusSENHA = readerHist["status_atendimento"].ToString();

                            // LOG ===> MessageBox.Show($"Senha: {senhaVal}, Local: {localVal}, Status: {statusSENHA}"); // Debug para verificar os valores

                            card.Configurar(senhaVal, localVal, statusSENHA);
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
            
            lastSenha();
            
            
        }


     
        public void lastSenha() // Método para buscar a última senha gerada do tipo e serviço especificados, e chamar a mesma
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    con.Open();

                    string servico = ""; //Passar o tipo de serviço que deseja buscar a última senha. Exemplo: "Recepção", "Protocolo", etc.
                    string tipo = ""; //Passar o tipo de atendimento que deseja buscar a última senha. Exemplo: "Normal", "Prioritário", etc.
                    


                    string sqlSelect = @"SELECT TOP 1 id, senha, tipo_atendimento, servico
                                 FROM Senhas 
                                WHERE CAST(data_geracao AS DATE) = CAST(GETDATE() AS DATE) 
                                AND tipo_atendimento = @tipo 
                                AND servico = @servico
                                AND status_atendimento = 'Aguardando'
                                ORDER BY id DESC"; //select para pegar a senha e chamar a mesma

                                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                                        cmd.Parameters.AddWithValue("@tipo", tipo);
                                            cmd.Parameters.AddWithValue("@servico", servico);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            senhaChamada.Text = reader["senha"].ToString();
                            senhaId = reader["id"].ToString();
                            senhaTelao = reader["senha"].ToString();
                            guicheTelao = reader["tipo_atendimento"].ToString();
                            MessageBox.Show("ID SELECIONADO: " + senhaId);

                            if (frm_telaSenhas.Instancia != null && !frm_telaSenhas.Instancia.IsDisposed)
                            {
                                frm_telaSenhas.Instancia.ReceberNovaSenha(senhaTelao, guicheTelao);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Nenhuma senha encontrada para o tipo e serviço especificados." + tipo + servico);
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Erro ao buscar última senha: " + ex.Message);
                }

                
            }
            
        }

        private void alterarStatusSenha() // Método para alterar o status da senha para "Chamado" no banco de dados
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string statusAtendimento = "Chamado";

                try
                {
                    con.Open();
                    string sqlUpdate = @"UPDATE Senhas 
                                 SET status_atendimento = @status_atendimento 
                                 WHERE id = @id";

                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con);

                    
                    cmdUpdate.Parameters.AddWithValue("@status_atendimento", statusAtendimento);
                    cmdUpdate.Parameters.AddWithValue("@id", senhaId);

                    
                    int linhasAfetadas = cmdUpdate.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Senha chamada com sucesso! ");
                        senhaChamada.Text = null; // Limpa o label após chamar a senha
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma senha encontrada com o ID: " + senhaId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar status da senha: " + ex.Message);
                }
            }
        }

        private void btn_refreshSenha_Click(object sender, EventArgs e)
        {
            if(lbl_senhaChamada == null)
            {
                btn_refreshSenha.Visible = true;
            }
            else
            {
                alterarStatusSenha();
                //carregarDADOSGRID();

            }
            

        }



        private void lblSenhaAtual_Click(object sender, EventArgs e)
        {
            // Exemplo visual
            
        }

        private void lbl_name_header_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel_senhaChamada_Paint(object sender, PaintEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            
            carregarDADOSGRID();

            
            
        }

       
        private void carregarDADOSGRID()
        {
            try
            {
                this.pR_BuscarSenhasChamadasTableAdapter.Fill(
                    this.projeto_rjDataSet12.PR_BuscarSenhasChamadas,
                    "Normal",
                    "Recepção"
                );
            }
            catch (Exception ex)
            {
                // Debug para saber se houve erro no banco durante a atualização
                MessageBox.Show("Erro na atualização automática: " + ex.Message);
            }
        }


        private void senhaChamada_Click(object sender, EventArgs e)
        {

        }

        private void atualizarListaAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if(atualizarListaAutomatico.Checked)
            {
                
                timerAtualizar.Enabled = true;
                timerAtualizar.Start();
            }
            else
            {
                timerAtualizar.Enabled = false;
                timerAtualizar.Stop();
            }
        }

        private void timerAtualizar_Tick(object sender, EventArgs e)
        {
            timerAtualizar.Start();
            carregarDADOSGRID();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sideBar1.Visible = true;
            sideBar1.Focus();
        }

        private void sideBar1_Load(object sender, EventArgs e)
        {

        }
    }
}