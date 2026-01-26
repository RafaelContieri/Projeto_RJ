using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_modalCadastro : Form
    {
        // Variável global para armazenar a string da imagem
        private string fotoBase64 = "";

        // String de conexão centralizada
        string stringConexao = @"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";

        public frm_modalCadastro()
        {
            InitializeComponent();
        }

        private void frm_modalCadastro_Load(object sender, EventArgs e)
        {
            // Carrega os grupos de acesso no ComboBox
            this.acessosTableAdapter.Fill(this.projeto_rjDataSet7.acessos);

            // Inicializa os botões de foto
            AtualizarEstadoBotoesFoto();
        }

        // --- LÓGICA DE FOTO ---

        private void btn_upload_picture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Image imgOriginal = Image.FromFile(open.FileName))
                    {
                        // Redimensiona para 200x200 para manter o banco leve
                        Image imgRedimensionada = EnquadrarPerfil(imgOriginal, 200, 200);
                        picture_imagemUsuario.Image = imgRedimensionada;

                        // Converte para Base64
                        using (MemoryStream ms = new MemoryStream())
                        {
                            imgRedimensionada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            fotoBase64 = Convert.ToBase64String(ms.ToArray());
                        }
                    }
                    AtualizarEstadoBotoesFoto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
                }
            }
        }

        private void btn_excluir_foto_Click(object sender, EventArgs e)
        {
            picture_imagemUsuario.Image = null;
            fotoBase64 = "";
            AtualizarEstadoBotoesFoto();
        }

        private void AtualizarEstadoBotoesFoto()
        {
            bool temFoto = picture_imagemUsuario.Image != null;
            btn_excluir_foto.Enabled = temFoto;
            // Opcional: btn_upload_picture.Enabled = !temFoto; (Se quiser travar após um upload)
        }

        // --- SALVAMENTO NO BANCO ---

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1. Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(cmb_Grupo_usuario.Text))
            {
                MessageBox.Show("Preencha Nome, Login, Senha e Grupo de Usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. SQL de Inserção
            string sql = @"INSERT INTO usuarios (nome, sigla, email, usuario, senha, acesso, imgbase64) 
                           VALUES (@nome, @sigla, @email, @usuario, @senha, @acesso, @img)";

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        cmd.Parameters.AddWithValue("@sigla", txtSigla.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@usuario", txtLogin.Text.Trim());
                        cmd.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());
                        cmd.Parameters.AddWithValue("@acesso", cmb_Grupo_usuario.Text);

                        // Trata a imagem: Se estiver vazio, envia NULL para o SQL
                        if (string.IsNullOrEmpty(fotoBase64))
                            cmd.Parameters.AddWithValue("@img", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@img", fotoBase64);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Define o resultado como OK para a Grid principal atualizar e fecha
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar no banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtSigla.Clear();
            cmb_Grupo_usuario.SelectedIndex = -1;
            picture_imagemUsuario.Image = null;
            fotoBase64 = "";
        }

        // --- FUNÇÃO AUXILIAR DE IMAGEM ---
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
                int y = (alturaAlvo - newHeight) / 3; // Ajuste para focar um pouco acima do centro (rosto)

                g.DrawImage(img, x, y, newWidth, newHeight);
            }
            return canvas;
        }

        

        private void btn_upload_picture_Click(object sender, EventArgs e)
        {

        }

        private void picture_imagemUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label_Click(object sender, EventArgs e)
        {
        }

        private void lbl_nome_usuario_Click(object sender, EventArgs e)
        {
        }




    }
}