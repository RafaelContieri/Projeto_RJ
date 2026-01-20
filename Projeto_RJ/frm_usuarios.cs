using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void lbl_name_header_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pesquisa_nome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //barra de pesquisa por nome de usuario
        {

        }



        private void CarregarDadosGrid() // RECRIA O MÉTODO PARA ATUALIZAR O GRID APÓS UMA EXCLUSÃO
        {
            try
            {
                // Esta linha faz o TableAdapter buscar os dados novos no SQL Server e atualizar o Grid
                this.usuariosTableAdapter.Fill(this.projeto_rjDataSet.usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a lista: " + ex.Message);
            }
        }


        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text)) //pesquisa por nome
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = tbl_usuarios.DataSource;
                bs.Filter = $"Nome LIKE '%{textBox1.Text}%'";
                tbl_usuarios.DataSource = bs;
            }
            else
            {

                //ao clicar no botao pesquisar sem nada digitado, ele recarrega o grid completo
                BindingSource bs = new BindingSource();
                bs.DataSource = tbl_usuarios.DataSource;
                bs.RemoveFilter();
                tbl_usuarios.DataSource = bs;

                //CarregarDadosGrid();
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void DeletarUsuarioNoBanco(int id) //comando para deletar usuario no banco
        {
            string strCon = "Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    string query = "DELETE FROM usuarios WHERE id = @id"; //realizo a query diretamente aqui
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário removido com sucesso!");

                    // Chame aqui o seu método que preenche o DataGridView para atualizar a lista
                    CarregarDadosGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar: " + ex.Message);
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//


        private void tbl_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e) // EVENTO DOS BOTÕES DE EXCLUIR E EDITAR
        {
            if (e.RowIndex < 0) return;

            // Captura o ID da linha clicada
            // Certifique-se que o nome da coluna no Grid é "Id" ou use o índice (ex: Cells[0])
            int idSelecionado = Convert.ToInt32(tbl_usuarios.Rows[e.RowIndex].Cells["Id"].Value);
            string nomeUsuario = tbl_usuarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

            // Lógica para o botão EXCLUIR
            if (tbl_usuarios.Columns[e.ColumnIndex].Name == "btnExcluir")
            {
                var confirmacao = MessageBox.Show($"Tem certeza que deseja excluir o usuário {nomeUsuario}?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    DeletarUsuarioNoBanco(idSelecionado);
                }
            }

            // Lógica para o botão EDITAR
            if (tbl_usuarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
               
                // Exemplo:
                // frmCadastro telaEdit = new frmCadastro(idSelecionado);
                // telaEdit.ShowDialog();
                // CarregarGrid(); // Para atualizar os dados após fechar a edição
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//


        private void btn_cadastrar_usuario_Click(object sender, EventArgs e)
        {
            frm_modalCadastro frm_CadastroUsuario = new frm_modalCadastro();
            frm_CadastroUsuario.Show();

            
        }

        private void frm_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_rjDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.projeto_rjDataSet.usuarios);

        }

        private void btn_pesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

        }
    }
}
