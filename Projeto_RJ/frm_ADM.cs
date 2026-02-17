using System;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_ADM : Form
    {
        public frm_ADM()
        {
            InitializeComponent();
        }




        

        private void btn_gestaoSenhas_Click(object sender, EventArgs e)
        {
            frm_gestaoSenha telaabrir = new frm_gestaoSenha();
            telaabrir.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_ADM_Load(object sender, EventArgs e)
        {
            // COLOCAR VALIDAÇÃO DE LOGIN DE ADMINISTRADOR AQUI PARA DESATIVAR BOTÃO DE GESTÃO DE SENHAS SE NÃO FOR ADMIN
            //ESSA VALIDAÇÃO VAI DEPENDER DO MODAL DO USUARIO LOGADO, OU SEJA SE FOR ADMINISTRADOR, DEIXA O BOTÃO ATIVO, SE NÃO FOR, DESATIVA O BOTÃO

        }

        private void btn_controleSenha_Click(object sender, EventArgs e)
        {
            frm_controleSenhas frm_ControleSenhas = new frm_controleSenhas();
            frm_ControleSenhas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e) //botao da tela de senhas
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

        private void btn_config_Click(object sender, EventArgs e)
        {
             frm_config configUSER = new frm_config();
            configUSER.ShowDialog();

            
        }
    }
}
