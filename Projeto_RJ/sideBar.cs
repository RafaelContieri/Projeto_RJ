using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class sideBar : UserControl
    {
        public sideBar()
        {
            InitializeComponent();
            // Botão Gestão de Senhas
            gestaosenhas.MouseEnter += (s, e) => { gestaosenhas.BackColor = Color.FromArgb(255, 133, 47); };
            gestaosenhas.MouseLeave += (s, e) => { gestaosenhas.BackColor = Color.Transparent; };
            gestaosenhas.FlatStyle = FlatStyle.Flat;
            gestaosenhas.FlatAppearance.BorderSize = 0;

            // Botão Controle de Senhas
            controlesenhas.MouseEnter += (s, e) => { controlesenhas.BackColor = Color.FromArgb(255, 133, 47); };
            controlesenhas.MouseLeave += (s, e) => { controlesenhas.BackColor = Color.Transparent; };
            controlesenhas.FlatStyle = FlatStyle.Flat;
            controlesenhas.FlatAppearance.BorderSize = 0;

            // Botão Painel de Senhas
            painelsenhas.MouseEnter += (s, e) => { painelsenhas.BackColor = Color.FromArgb(255, 133, 47); };
            painelsenhas.MouseLeave += (s, e) => { painelsenhas.BackColor = Color.Transparent; };
            painelsenhas.FlatStyle = FlatStyle.Flat;
            painelsenhas.FlatAppearance.BorderSize = 0;

            // Botão Configurações
            configuracoes.MouseEnter += (s, e) => { configuracoes.BackColor = Color.FromArgb(255, 133, 47); };
            configuracoes.MouseLeave += (s, e) => { configuracoes.BackColor = Color.Transparent; };
            configuracoes.FlatStyle = FlatStyle.Flat;
            configuracoes.FlatAppearance.BorderSize = 0;

            // Botão Sair (Exit)
            exit.MouseEnter += (s, e) => { exit.BackColor = Color.FromArgb(255, 133, 47); };
            exit.MouseLeave += (s, e) => { exit.BackColor = Color.Transparent; };
            exit.FlatStyle = FlatStyle.Flat;
            exit.FlatAppearance.BorderSize = 0;

            this.Load += new EventHandler(sideBar_Load);


           

            


        }

        private void container_pai_Paint(object sender, PaintEventArgs e)
        {
            
                
        }

        private void panel2_Paint(object sender, PaintEventArgs e) //side menu
        {

        }

        private void container_GroupMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_fotoMenu_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nomeMenu_Click(object sender, EventArgs e)
        {

        }

        private void lbl_AcessoMenu_Click(object sender, EventArgs e)
        {

        }

        private void btn_exitMenu_Click(object sender, EventArgs e)
        {

        }

        private void container_BotoesMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gestaosenhas_Click(object sender, EventArgs e)
        {

        }

        private void controlesenhas_Click(object sender, EventArgs e)
        {

        }

        private void painelsenhas_Click(object sender, EventArgs e)
        {

        }

        private void configuracoes_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painel_botoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }

        private void gestaosenhas_Click_1(object sender, EventArgs e) //ok


        {
            Form frmAtual = this.FindForm(); // procurando a tela que eu estou

            if (frmAtual != null && this.Visible == true)
            {
                this.Visible = false; // Esconde a sidebar ao carregar, para só mostrar quando o botão for clicado
            }

            Form frm = Application.OpenForms["frm_gestaoSenha"];

            if (frm != null)
            {
                // Se ela existir, trazemos ela para a frente (foco)
                frm.BringToFront();

                
                if (frm.WindowState == FormWindowState.Minimized)
                    frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                
                frm_gestaoSenha telaabrir = new frm_gestaoSenha();
                telaabrir.Show();
            }

        }

        private void controlesenhas_Click_1(object sender, EventArgs e) //ok



        {

            Form frmAtual = this.FindForm(); // procurando a tela que eu estou

            if (frmAtual != null && this.Visible == true)
            {
                this.Visible = false; // Esconde a sidebar ao carregar, para só mostrar quando o botão for clicado
            }

            Form frm = Application.OpenForms["frm_controleSenhas"];

            if (frm != null)
            {
                // Se ela existir, trazemos ela para a frente (foco)
                frm.BringToFront();


                if (frm.WindowState == FormWindowState.Minimized)
                    frm.WindowState = FormWindowState.Normal;
            }
            else
            {

                frm_controleSenhas telaabrir = new frm_controleSenhas();
                telaabrir.Show();
            }
        }

        private void painelsenhas_Click_1(object sender, EventArgs e) //ok
        {

            Form frmAtual = this.FindForm(); // procurando a tela que eu estou

            if (frmAtual != null && this.Visible == true)
            {
                this.Visible = false; // Esconde a sidebar ao carregar, para só mostrar quando o botão for clicado
            }

            Form frm = Application.OpenForms["frm_telaSenhas"];

            if (frm != null)
            {
                // Se ela existir, trazemos ela para a frente (foco)
                frm.BringToFront();


                if (frm.WindowState == FormWindowState.Minimized)
                    frm.WindowState = FormWindowState.Normal;
            }
            else
            {

                frm_telaSenhas telaabrir = new frm_telaSenhas();
                telaabrir.Show();
            }
        }

        private void configuracoes_Click_1(object sender, EventArgs e)
        {

            Form frmAtual = this.FindForm(); // procurando a tela que eu estou

            if (frmAtual != null && this.Visible == true)
            {
                this.Visible = false; // Esconde a sidebar ao carregar, para só mostrar quando o botão for clicado
            }

            Form frm = Application.OpenForms["frm_config"];

            if (frm != null)
            {
                // Se ela existir, trazemos ela para a frente (foco)
                frm.BringToFront();


                if (frm.WindowState == FormWindowState.Minimized)
                    frm.WindowState = FormWindowState.Normal;
            }
            else
            {

                frm_config telaabrir = new frm_config();
                telaabrir.Show();
            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            deslogarToolStripMenuItem_Click(sender, e); // Reutiliza o método de deslogar para o botão de sair
        }

        private void lbl_nomeMenu_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lbl_AcessoMenu_Click_1(object sender, EventArgs e)
        {
        }  

        private void btn_close_Click_1(object sender, EventArgs e)
        
        {
            
            
                this.Visible = false; // Apenas torna o sidebar invisível, sem removê-lo do formulário
            
            
        }

        private void sideBar_Load(object sender, EventArgs e) // Carrega as informações do usuário na sidebar
        {
            lbl_nomeMenu.Text = SessaoUsuario.Nome;

            // Tratamento visual para exibir Administrador se for Adm no banco
            string nivel = SessaoUsuario.NivelAcesso;
            lbl_AcessoMenu.Text = (nivel == "Adm") ? "Administrador" : nivel;

            if (!string.IsNullOrEmpty(SessaoUsuario.FotoBase64))
            {
                
                Image imgDoBanco = ConvertBase64ToImage(SessaoUsuario.FotoBase64);

                if (imgDoBanco != null)
                {
                    
                    pic_fotoMenu.Image = EnquadrarPerfil(imgDoBanco, 81, 74);
                }
            }
        }

        public Image EnquadrarPerfil(Image img, int width, int height)
        {
            // Cria um canvas (tela) no tamanho 81x74
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(b))
            {
                // Configurações de alta qualidade para não borrar a foto
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                // Desenha a imagem original preenchendo o novo tamanho
                g.DrawImage(img, 0, 0, width, height);
            }
            return b;
        }



        public Image ConvertBase64ToImage(string base64String)
        {
            if (string.IsNullOrEmpty(base64String)) return null;
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        public void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessaoUsuario.LimparSessao(); //aqui
            Form frmLogin = Application.OpenForms["frm_Login"];
            if (frmLogin != null)
            {
                frmLogin.Show();
                frmLogin.BringToFront();
            }
            Application.OpenForms["frm_ADM"]?.Close();
        }

        private void pic_fotoMenu_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_exitMenu_Click_1(object sender, EventArgs e)
        {
            deslogarToolStripMenuItem_Click(sender, e); // Reutiliza o método de deslogar para o botão de sair
        }

        private void container_BotoesMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void container_pai_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }

    
}
