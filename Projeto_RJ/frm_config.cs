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
    public partial class frm_config : Form
    {
        public frm_config()
        {
            InitializeComponent();
            sideBar1.Visible = false;
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            frm_usuarios telaUsers = new frm_usuarios();
            telaUsers.ShowDialog();
        }

        private void frm_config_Load(object sender, EventArgs e)
        {

        }
    }
}
