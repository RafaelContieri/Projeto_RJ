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
            // TODO: esta linha de código carrega dados na tabela 'servico_usuario.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.servico_usuario.servico);
            // TODO: esta linha de código carrega dados na tabela 'projeto_rjDataSet17.tipoAtendimento'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoAtendimentoTableAdapter.Fill(this.projeto_rjDataSet17.tipoAtendimento);
            // TODO: esta linha de código carrega dados na tabela 'projeto_rjDataSet16.acessos'. Você pode movê-la ou removê-la conforme necessário.
            this.acessosTableAdapter1.Fill(this.projeto_rjDataSet16.acessos);
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
                string.IsNullOrWhiteSpace(cmb_Grupo_usuario.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Certifique-se de preencher todos os campos e inserir um e-mail válido!", "Dados Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- NOVIDADE: GERANDO O HASH DA SENHA ---
            // Pegamos o que está no TextBox e transformamos em uma assinatura segura
            string senhaOriginal = txtSenha.Text.Trim();
            string senhaComHash = BCrypt.Net.BCrypt.HashPassword(senhaOriginal);

            // 2. SQL de Inserção
            string sql = @"INSERT INTO usuarios (nome, sigla, email, usuario, senha, id_acesso, imgbase64) 
                   VALUES (@nome, @sigla, @email, @usuario, @senha, @id_acesso, @img)";

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

                        // --- AJUSTE: Enviamos a senha com Hash para o banco ---
                        cmd.Parameters.AddWithValue("@senha", senhaComHash);

                        cmd.Parameters.AddWithValue("@id_acesso", cmb_Grupo_usuario.Text);

                        // Trata a imagem
                        if (string.IsNullOrEmpty(fotoBase64))
                            cmd.Parameters.AddWithValue("@img", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@img", fotoBase64);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuário cadastrado com sucesso e senha protegida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_grupo_usuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.FormattingEnabled = false; // Evita que o ComboBox tente formatar o texto, mostrando exatamente o que está no banco
        }

        private void lbl_servico_Click(object sender, EventArgs e)
        {

        }

        private void cmb_servico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}