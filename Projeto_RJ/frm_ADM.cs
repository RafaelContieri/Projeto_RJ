using System;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_ADM : Form
    {

        public string modalusuario { get; set; } // Propriedade para armazenar o modal do usuário logado
        public frm_ADM()
        {
            InitializeComponent();
            sideBar1.Visible = false;
            
            
        }


        public void botaoChamarMenu()
        {
            sideBar1.Visible = true;

        }

       


        private void btn_gestaoSenhas_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_ADM_Load(object sender, EventArgs e)
        {
            // COLOCAR VALIDAÇÃO DE LOGIN DE ADMINISTRADOR AQUI PARA DESATIVAR BOTÃO DE GESTÃO DE SENHAS SE NÃO FOR ADMIN
            //ESSA VALIDAÇÃO VAI DEPENDER DO MODAL DO USUARIO LOGADO, OU SEJA SE FOR ADMINISTRADOR, DEIXA O BOTÃO ATIVO, SE NÃO FOR, DESATIVA O BOTÃO

        }
        private void btn_config_Click(object sender, EventArgs e)
        {
             

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e) //side menu
        {

        }


        private void painel_botoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_name_header_Click(object sender, EventArgs e)
        {

        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            botaoChamarMenu();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //Verifica se o telão já não está aberto (para não abrir duplicado)
            if (frm_telaSenhas.Instancia == null || frm_telaSenhas.Instancia.IsDisposed)
            {
                frm_telaSenhas telao = new frm_telaSenhas();
                telao.Show();

            }
            else
            {
                // Se já estiver aberto, apenas traz ele para a frente
                frm_telaSenhas.Instancia.BringToFront();
            }
        }

        private void btn_controleSenha_Click_1(object sender, EventArgs e)
        {
            frm_controleSenhas frm_ControleSenhas = new frm_controleSenhas();
            frm_ControleSenhas.Show();
        }

        private void btn_config_Click_1(object sender, EventArgs e)
        {
            frm_config configUSER = new frm_config();
            configUSER.ShowDialog();
        }

        private void btn_gestaoSenhas_Click_1(object sender, EventArgs e)
        {
            frm_gestaoSenha telaabrir = new frm_gestaoSenha();
            telaabrir.ShowDialog();
        }

        private void sideBar1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frm_ADM_FormClosed(object sender, FormClosedEventArgs e) //Evento para garantir que a sessão seja limpa ao fechar o formulário principal
        {
            modalError abrimodal = new modalError();
             abrimodal.ShowDialog();

            //corrigir aqui para abrir o modal de confirmação, e se o usuário clicar em sim, aí sim limpar a sessão, se clicar em não, apenas fechar o modal e manter a sessão ativa
        }
    }
    
}
