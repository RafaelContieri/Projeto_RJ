using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
        public frm_editarCadastro(int idSelecionado, string nomeSelecionado, string emailSelecionado, string usuarioSelecionado, string siglaSelecionado, string senhaSelecionada, string acessoSelecionado, string fotoSelecionada)
        {
            InitializeComponent();

            // 1. Guarda o ID e a String da Foto
            this.idUsuarioEdicao = idSelecionado;
            this.fotoBase64 = fotoSelecionada;

            // 2. Preenche os campos de texto (Agora na ordem certa!)
            txtNome_editar.Text = nomeSelecionado;
            txtEmail_editar.Text = emailSelecionado;

            // AQUI ESTAVA A CONFUSÃO: Agora Login vai pro Login e Sigla vai pra Sigla
            txtLogin_editar.Text = usuarioSelecionado;
            txtSigla_editar.Text = siglaSelecionado;

            txtSenha_editar.Text = senhaSelecionada;
            cmb_Grupo_usuario.Text = acessoSelecionado;

            // 3. LOGICA PARA TRAZER A FOTO
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

        // BOTÃO SALVAR (O VERDE) - CORRIGIDO E ROBUSTO
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Segurança: Verifica se temos o ID para editar
            if (idUsuarioEdicao == null || idUsuarioEdicao == 0)
            {
                MessageBox.Show("Erro: Usuário não identificado para edição.");
                return;
            }

            // O comando SQL UPDATE
            string sql = @"UPDATE usuarios 
                           SET nome = @nome, 
                               email = @email, 
                               sigla = @sigla, 
                               usuario = @usuario, 
                               senha = @senha, 
                               acesso = @acesso 
                           WHERE id = @id";

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        // Passando os valores corretos das caixas de texto
                        cmd.Parameters.AddWithValue("@nome", txtNome_editar.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail_editar.Text);
                        cmd.Parameters.AddWithValue("@sigla", txtSigla_editar.Text);
                        cmd.Parameters.AddWithValue("@usuario", txtLogin_editar.Text); // Login
                        cmd.Parameters.AddWithValue("@senha", txtSenha_editar.Text);
                        cmd.Parameters.AddWithValue("@acesso", cmb_Grupo_usuario.Text);
                        cmd.Parameters.AddWithValue("@id", idUsuarioEdicao);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Fecha a tela para atualizar o Grid lá atrás
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
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

        // -------------------------------------------------------------------------
        // COLE ISSO LÁ NO FINAL, ANTES DO ÚLTIMO "}" PARA PARAR O ERRO
        // Esses métodos servem apenas para satisfazer o Designer do Visual Studio
        // -------------------------------------------------------------------------

        private void txtNome_editar_TextChanged(object sender, EventArgs e) { }

        private void txtSenha_editar_TextChanged(object sender, EventArgs e) { }

        private void txtEmail_editar_TextChanged(object sender, EventArgs e) { }

        private void txtSigla_editar_TextChanged(object sender, EventArgs e) { }

        private void txtLogin_editar_TextChanged(object sender, EventArgs e) { }

        private void foto_usuario_edicao_Click(object sender, EventArgs e) { }
    }
}