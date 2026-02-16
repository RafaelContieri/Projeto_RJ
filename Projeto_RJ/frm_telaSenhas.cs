using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_telaSenhas : Form
    {
        //string strCon = @"Data Source=100.65.33.58,1414;Initial Catalog=projeto_rj;User ID=sa;Password=ap23@#$);";
        //private int ultimaSenhaId = 0;

        public frm_telaSenhas()
        {
            InitializeComponent();
            //AtualizarPainel();
        }

        private void frm_telaSenhas_Load(object sender, EventArgs e)
        {
            // Configura o timer para 3 segundos
            timer1.Interval = 3000;
            timer1.Start();

            // Chamada inicial
            //AtualizarPainel();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Configura o seu timer de atualização de dados para 3 segundos
            timer1.Interval = 3000;
            timer1.Start();
            // Busca as senhas
            //AtualizarPainel();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {

            
        }
        private void lbl_senhaDB_Click(object sender, EventArgs e) { }
        private void lbl_senha_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lbl_mesaDB_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void lbl_guicheDB_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void flow_historico_Paint(object sender, PaintEventArgs e) { }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void frm_telaSenhas_Load_1(object sender, EventArgs e)
        {

        }
    }
}