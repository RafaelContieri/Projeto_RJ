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
    public partial class TOTEM : Form
    {
        public TOTEM()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //ABRIR TELA INCIAL DAS SENHAS
            telaInicial telaabrir = new telaInicial();
            telaabrir.ShowDialog();
        }

        private void TOTEM_Load(object sender, EventArgs e)
        {

        }
    }
}
