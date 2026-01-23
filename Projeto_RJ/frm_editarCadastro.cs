using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_editarCadastro : Form
    {
        private int? idUsuarioEdicao = null;
        public string fotoBase64 = "";

        public frm_editarCadastro(int idSelecionado, string nomeSelecionado, string emailSelecionado, string siglaSelecionado, string usuarioSelecionado, string senhaSelecionada, string acessoSelecionado, string fotoSelecionada)
        {
            InitializeComponent();

            // 1. Guarda o ID e a String da Foto
            this.idUsuarioEdicao = idSelecionado;
            this.fotoBase64 = fotoSelecionada;

            // 2. Preenche os campos de texto
            txtNome_editar.Text = nomeSelecionado;
            txtSigla_editar.Text = usuarioSelecionado;
            txtEmail_editar.Text = emailSelecionado;
            txtLogin_editar.Text = siglaSelecionado;
            txtSenha_editar.Text = senhaSelecionada;
            txtGrupoUsuario_editar.Text = acessoSelecionado;

            // --- LOGICA PARA TRAZER A FOTO ---
            if (!string.IsNullOrEmpty(fotoSelecionada))
            {
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(fotoSelecionada);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        foto_usuario_edicao.Image = Image.FromStream(ms);
                        foto_usuario_edicao.SizeMode = PictureBoxSizeMode.Normal;
                        btn_excluir_foto.Enabled = true; // Ativa se houver foto
                    }
                }
                catch (Exception)
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

        private void btn_upload_picture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Image imgOriginal = Image.FromFile(openFileDialog1.FileName))
                {
                    foto_usuario_edicao.Image = EnquadrarPerfil(imgOriginal, 200, 200);
                    btn_excluir_foto.Enabled = true;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        foto_usuario_edicao.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        fotoBase64 = Convert.ToBase64String(ms.ToArray());
                    }
                }

                // Atualização imediata no banco
                string strCon = "Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";
                string sql = "UPDATE usuarios SET imgbase64 = @img WHERE id = @id";

                using (SqlConnection con = new SqlConnection(strCon))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@img", fotoBase64);
                        cmd.Parameters.AddWithValue("@id", idUsuarioEdicao);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Foto atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar foto: " + ex.Message);
                    }
                }
            }
        }

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

        private void btn_excluir_foto_Click(object sender, EventArgs e) // botao para excluir foto
        {
            // 1. Confirmação (Boa prática para evitar cliques acidentais)
            DialogResult confirmacao = MessageBox.Show("Deseja realmente excluir a foto deste usuário permanentemente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                // 2. String de conexão (a mesma que você usou no upload)
                string strCon = "Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";

                // 3. SQL para limpar a imagem (setando como vazio ou NULL)
                string sql = "UPDATE usuarios SET imgbase64 = '' WHERE id = @id";

                using (SqlConnection con = new SqlConnection(strCon))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", idUsuarioEdicao);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        // 4. Limpeza da Interface Visual
                        foto_usuario_edicao.Image = null;
                        fotoBase64 = ""; // Limpa a variável local
                        btn_excluir_foto.Enabled = false; // Desativa o botão

                        MessageBox.Show("Foto removida com sucesso do servidor!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir foto no banco: " + ex.Message);
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Aqui você faz o UPDATE dos campos de texto (Nome, Email, etc)
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void txtNome_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSigla_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrupoUsuario_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_editar_TextChanged(object sender, EventArgs e)
        {

        }

        private void foto_usuario_edicao_Click(object sender, EventArgs e)
        {

        }

        // Métodos vazios ignorados para brevidade...
    }
}