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
            sideBar1.Focus();
        }

       


        private void btn_gestaoSenhas_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_ADM_Load(object sender, EventArgs e)
        {
            this.MouseLeave += new EventHandler(sideBar1.container_pai_Leave);


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

            frm_telaSenhas telao = new frm_telaSenhas();
            telao.Show();
        }

        private void btn_controleSenha_Click_1(object sender, EventArgs e)
        {

            frm_controleSenhas frm_ControleSenhas = new frm_controleSenhas();
            frm_ControleSenhas.Show();
        }

        private void btn_config_Click_1(object sender, EventArgs e)
        {

            frm_config configUSER = new frm_config();
            configUSER.Show();

           
        }

        private void btn_gestaoSenhas_Click_1(object sender, EventArgs e)
        {

            frm_gestaoSenha telaabrir = new frm_gestaoSenha();
            telaabrir.Show();
        }

        private void sideBar1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frm_ADM_FormClosed(object sender, EventArgs e) 
        {
            modalError abrimodal = new modalError(); //modal de aviso
             abrimodal.Show();


            
        }

        private void sideBar1_Load_1(object sender, EventArgs e)
        {

        }

        private void sideBar1_Load_2(object sender, EventArgs e)
        {

        }

        private void frm_ADM_Leave(object sender, EventArgs e)
        {

        }
    }
    
}
