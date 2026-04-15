using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_RJ
{
    public partial class frm_editarCadastro : Form
    {
        // Variáveis globais da tela
        private int? idUsuarioEdicao = null;
        public string fotoBase64 = "";

        // String de conexão (Centralizada para não errar)
        string stringConexao = @"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";

        // CONSTRUTOR: Arrumei a ordem dos parâmetros para bater com a tela anterior
        public frm_editarCadastro(int idSelecionado, string nomeSelecionado, 
            string emailSelecionado, string usuarioSelecionado,
            string siglaSelecionado, string senhaSelecionada, 
            string acessoSelecionado, string servico,
            string tipoAtendimento, string fotoSelecionada)
        {
            InitializeComponent();

            // puxa as informações para os campos da tela de edição (a ordem dos parâmetros deve ser a mesma da chamada na tela anterior)
            this.idUsuarioEdicao = idSelecionado;
            this.fotoBase64 = fotoSelecionada;
            cmb_Grupo_usuario.Text = acessoSelecionado;
            txtNome_editar.Text = nomeSelecionado;
            txtEmail_editar.Text = emailSelecionado;
            txtLogin_editar.Text = usuarioSelecionado;
            txtSigla_editar.Text = siglaSelecionado;
            txtSenha_editar.Text = senhaSelecionada;
            comboBox1.Text = tipoAtendimento;
            cmb_servico.Text = servico;





            CarregarFotoNaTela(fotoSelecionada);
        }

        // Método separado para carregar a foto (fica mais organizado)
        private void CarregarFotoNaTela(string base64String)
        {
            if (!string.IsNullOrEmpty(base64String))
            {
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(base64String);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        foto_usuario_edicao.Image = Image.FromStream(ms);
                        foto_usuario_edicao.SizeMode = PictureBoxSizeMode.StretchImage; // Mudei para Stretch ou Zoom para caber melhor
                        btn_excluir_foto.Enabled = true;
                    }
                }
                catch
                {
                    foto_usuario_edicao.Image = null;
                    btn_excluir_foto.Enabled = false;
                }
            }
            else
            {
                btn_excluir_foto.Enabled = false;
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (idUsuarioEdicao == null || idUsuarioEdicao == 0)
            {
                MessageBox.Show("Erro: Usuário não identificado para edição.");
                return;
            }

            // 1. Lógica do Hash: Identifica se o que está no campo é um Hash ou Senha Pura
            string senhaDigitada = txtSenha_editar.Text.Trim();
            string senhaParaSalvar;

            // Se o texto tem 60 caracteres e começa com $, já é o Hash antigo. Não mexemos.
            if (senhaDigitada.Length == 60 && senhaDigitada.StartsWith("$"))
            {
                senhaParaSalvar = senhaDigitada;
            }
            else
            {
                // Se o usuário digitou algo novo (ex: "123"), geramos o Hash agora
                senhaParaSalvar = BCrypt.Net.BCrypt.HashPassword(senhaDigitada);
            }

            // 2. Query SQL (Certifique-se que os nomes das colunas batem com o seu banco)
            string sql = @"UPDATE usuarios 
                   SET nome = @nome, 
                       email = @email, 
                       sigla = @sigla, 
                       usuario = @usuario, 
                       senha = @senha, 
                       acesso = @id_acesso
                       servico = @id_servico,
                       tipoAtendimento = @id_tipoAtendimento
                   WHERE id = @id";

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        // ATENÇÃO: Os nomes abaixo devem ser IGUAIS aos da string 'sql' acima
                        cmd.Parameters.AddWithValue("@nome", txtNome_editar.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail_editar.Text.Trim());
                        cmd.Parameters.AddWithValue("@sigla", txtSigla_editar.Text.Trim());
                        cmd.Parameters.AddWithValue("@usuario", txtLogin_editar.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_acesso", cmb_Grupo_usuario.Text);
                        cmd.Parameters.AddWithValue("@id", idUsuarioEdicao);
                        cmd.Parameters.AddWithValue("@id_servico", cmb_servico.Text);
                        cmd.Parameters.AddWithValue("@id_tipoAtendimento", comboBox1.Text);

                        // Aqui é onde morava o erro da variável escalar:
                        cmd.Parameters.AddWithValue("@senha", senhaParaSalvar);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Isso vai te mostrar no MessageBox se o erro é no SQL ou no C#
                    MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // BOTÃO UPLOAD DE FOTO
        private void btn_upload_picture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Image imgOriginal = Image.FromFile(openFileDialog1.FileName))
                    {
                        // Redimensiona para não pesar no banco
                        Image imgRedimensionada = EnquadrarPerfil(imgOriginal, 200, 200);
                        foto_usuario_edicao.Image = imgRedimensionada;
                        btn_excluir_foto.Enabled = true;

                        // Converte para Base64
                        using (MemoryStream ms = new MemoryStream())
                        {
                            imgRedimensionada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            fotoBase64 = Convert.ToBase64String(ms.ToArray());
                        }
                    }

                    // Salva a foto IMEDIATAMENTE no banco
                    SalvarApenasFoto(fotoBase64);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
                }
            }
        }

        // Método auxiliar para salvar só a foto
        private void SalvarApenasFoto(string novaBase64)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                try
                {
                    string sql = "UPDATE usuarios SET imgbase64 = @img WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@img", novaBase64);
                    cmd.Parameters.AddWithValue("@id", idUsuarioEdicao);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Foto atualizada!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar foto no banco: " + ex.Message);
                }
            }
        }

        // BOTÃO EXCLUIR FOTO
        private void btn_excluir_foto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Excluir foto?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SalvarApenasFoto(""); // Salva vazio no banco
                foto_usuario_edicao.Image = null;
                fotoBase64 = "";
                btn_excluir_foto.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        // Função de Redimensionar (Mantive a sua que estava ótima)
        public Image EnquadrarPerfil(Image img, int larguraAlvo, int alturaAlvo)
        {
            var canvas = new Bitmap(larguraAlvo, alturaAlvo);
            using (var g = Graphics.FromImage(canvas))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                double ratio = Math.Max((double)larguraAlvo / img.Width, (double)alturaAlvo / img.Height);
                int newWidth = (int)(img.Width * ratio);
                int newHeight = (int)(img.Height * ratio);

                int x = (larguraAlvo - newWidth) / 2;
                int y = (alturaAlvo - newHeight) / 3;

                g.DrawImage(img, x, y, newWidth, newHeight);
            }
            return canvas;
        }


        private void txtNome_editar_TextChanged(object sender, EventArgs e) { }

        private void txtSenha_editar_TextChanged(object sender, EventArgs e) { 
        

        }

        private void txtEmail_editar_TextChanged(object sender, EventArgs e) { }

        private void txtSigla_editar_TextChanged(object sender, EventArgs e) { }

        private void txtLogin_editar_TextChanged(object sender, EventArgs e) { }

        private void foto_usuario_edicao_Click(object sender, EventArgs e) { }

        private void cmb_Grupo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_servico_Click(object sender, EventArgs e)
        {

        }

        private void cmb_servico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    }
}