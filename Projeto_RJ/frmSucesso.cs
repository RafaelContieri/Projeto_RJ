using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projeto_RJ
{
    public partial class modalSucess : Form
    {
        public modalSucess()
        {
            InitializeComponent();
        }

        public string _senhaInterna;


        public modalSucess(string senhaFinal)
        {
            InitializeComponent();
            _senhaInterna = senhaFinal; // Guarda a senha que veio do banco
            lbl_senha_vinda.Text = "Senha gerada com sucesso ! : " + _senhaInterna; // SENHA GERADA VINDO DO BANCO. FOI CRIADO UM MÉTODO PARA ISSO NA TELA INICIAL
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            this.Close();

            // inserir um código para fechar todas as outras forms abertas, se houver ==> por que ao fechar o modal correspondente a tela, ele deixa
            //outras abas abertas.
        }

        private void lbl_senha_vinda_Click(object sender, EventArgs e)

        {
            
        }
    }
}
