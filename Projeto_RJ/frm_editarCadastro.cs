using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public frm_editarCadastro(int idSelecionado, string nomeSelecionado, string usuarioSelecionado, string senhaSelecionada, string acessoSelecionado)
        {
            // 1. Inicializa os componentes visuais (botões, campos, etc)
            InitializeComponent();

            // 2. Guarda o ID para uso posterior no botão Salvar
            this.idUsuarioEdicao = idSelecionado;

            // 3. Preenche os campos de texto com os valores recebidos
            txtNome_editar.Text = nomeSelecionado;
            txtLogin_editar.Text = usuarioSelecionado;
            txtSenha_editar.Text = senhaSelecionada;
            txtGrupoUsuario_editar.Text = acessoSelecionado;

            // Se você tiver um campo de email/sigla, adicione aqui também:
            // txtEmail_editar.Text = ...
        }

        // Eventos TextChanged devem ficar vazios para permitir que o usuário digite livremente
        private void txtNome_editar_TextChanged(object sender, EventArgs e) { }

        private void txtLogin_editar_TextChanged(object sender, EventArgs e) { }

        private void txtSenha_editar_TextChanged(object sender, EventArgs e) { }

        private void txtGrupoUsuario_editar_TextChanged(object sender, EventArgs e) { }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Próximo passo: Lógica de UPDATE no SQL Server usando o this.idUsuarioEdicao
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o modal sem salvar nada
        }

        // Outros eventos que você não estiver usando podem permanecer vazios ou ser removidos
        private void txtEmail_editar_TextChanged(object sender, EventArgs e) { }
        private void txtSigla_editar_TextChanged(object sender, EventArgs e) { }
        private void foto_usuario_edicao_Click(object sender, EventArgs e) { }
    }
}