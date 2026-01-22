using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Necessário para MemoryStream
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_editarCadastro : Form
    {
        // Variável para armazenar o ID que será usado no UPDATE do SQL Server
        private int? idUsuarioEdicao = null;

        // O Construtor recebe os dados do formulário principal
        public frm_editarCadastro(int idSelecionado, string nomeSelecionado, string emailSelecionado, string siglaSelecionado, string usuarioSelecionado, string senhaSelecionada, string acessoSelecionado, string fotoSelecionada)
        {
            // 1. Inicializa os componentes visuais (botões, campos, etc)
            InitializeComponent();

            // 2. Guarda o ID para uso posterior no botão Salvar
            this.idUsuarioEdicao = idSelecionado;

            // 3. Preenche os campos de texto com os valores recebidos
            txtNome_editar.Text = nomeSelecionado;
            txtSigla_editar.Text = usuarioSelecionado;
            txtEmail_editar.Text = emailSelecionado;
            txtLogin_editar.Text = siglaSelecionado;
            txtSenha_editar.Text = senhaSelecionada;
            txtGrupoUsuario_editar.Text = acessoSelecionado;

            // --- AJUSTE DA FOTO (CONVERSÃO DE BASE64 PARA IMAGEM) ---
            if (!string.IsNullOrEmpty(fotoSelecionada))
            {
                try
                {
                    // Converte a string Base64 em um array de bytes
                    byte[] imageBytes = Convert.FromBase64String(fotoSelecionada);

                    // Cria um fluxo de memória para transformar os bytes em imagem
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        foto_usuario_edicao.Image = Image.FromStream(ms);
                    }

                    // Ajusta a imagem para preencher o componente corretamente
                    foto_usuario_edicao.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    // Caso a string não seja um Base64 válido
                    MessageBox.Show("Erro ao carregar a foto: " + ex.Message);
                    foto_usuario_edicao.Image = null;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Próximo passo: Lógica de UPDATE no SQL Server usando o this.idUsuarioEdicao
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o modal sem salvar nada
        }

        // Eventos vazios (podem ser mantidos ou removidos se não houver lógica específica)
        private void txtNome_editar_TextChanged(object sender, EventArgs e) { }
        private void txtLogin_editar_TextChanged(object sender, EventArgs e) { }
        private void txtSenha_editar_TextChanged(object sender, EventArgs e) { }
        private void txtGrupoUsuario_editar_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_editar_TextChanged(object sender, EventArgs e) { }
        private void txtSigla_editar_TextChanged(object sender, EventArgs e) { }
        private void foto_usuario_edicao_Click(object sender, EventArgs e) { }
    }
}