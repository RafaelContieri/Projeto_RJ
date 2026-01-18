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
    public partial class frm_ADM : Form
    {
        public frm_ADM()
        {
            InitializeComponent();
        }

        

        private void btn_gestaoSenhas_Click(object sender, EventArgs e)
        {
            frm_gestaoSenha telaabrir = new frm_gestaoSenha();
            telaabrir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_ADM_Load(object sender, EventArgs e)
        {
            // COLOCAR VALIDAÇÃO DE LOGIN DE ADMINISTRADOR AQUI PARA DESATIVAR BOTÃO DE GESTÃO DE SENHAS SE NÃO FOR ADMIN


        }

        private void btn_controleSenha_Click(object sender, EventArgs e)
        {
            frm_controleSenhas frm_ControleSenhas = new frm_controleSenhas();
            frm_ControleSenhas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e) //botão para acessar a tela de senhas ==>  (TV)
        {
            frm_telaSenhas frm_TelaSenhas = new frm_telaSenhas();
            frm_TelaSenhas.Show();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
             frm_config configUSER = new frm_config();
            configUSER.Show();

            
        }
    }
}
