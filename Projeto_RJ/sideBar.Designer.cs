namespace Projeto_RJ
{
    partial class sideBar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sideBar));
            this.container_pai = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_itens = new System.Windows.Forms.Panel();
            this.pic_fotoMenu = new System.Windows.Forms.PictureBox();
            this.btn_exitMenu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_nomeMenu = new System.Windows.Forms.Label();
            this.lbl_AcessoMenu = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.container_BotoesMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.gestaosenhas = new System.Windows.Forms.Button();
            this.controlesenhas = new System.Windows.Forms.Button();
            this.painelsenhas = new System.Windows.Forms.Button();
            this.configuracoes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.container_pai.SuspendLayout();
            this.panel_itens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotoMenu)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.container_BotoesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_pai
            // 
            this.container_pai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.container_pai.AutoSize = true;
            this.container_pai.BackColor = System.Drawing.Color.LightGray;
            this.container_pai.Controls.Add(this.panel_itens);
            this.container_pai.Controls.Add(this.container_BotoesMenu);
            this.container_pai.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.container_pai.Location = new System.Drawing.Point(0, 0);
            this.container_pai.Name = "container_pai";
            this.container_pai.Size = new System.Drawing.Size(441, 465);
            this.container_pai.TabIndex = 22;
            this.container_pai.WrapContents = false;
            this.container_pai.Paint += new System.Windows.Forms.PaintEventHandler(this.container_pai_Paint);
            this.container_pai.MouseEnter += new System.EventHandler(this.container_pai_MouseEnter);
            // 
            // panel_itens
            // 
            this.panel_itens.AutoSize = true;
            this.panel_itens.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_itens.Controls.Add(this.pic_fotoMenu);
            this.panel_itens.Controls.Add(this.btn_exitMenu);
            this.panel_itens.Controls.Add(this.flowLayoutPanel1);
            this.panel_itens.Controls.Add(this.btn_close);
            this.panel_itens.Location = new System.Drawing.Point(3, 3);
            this.panel_itens.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel_itens.Name = "panel_itens";
            this.panel_itens.Size = new System.Drawing.Size(433, 82);
            this.panel_itens.TabIndex = 25;
            // 
            // pic_fotoMenu
            // 
            this.pic_fotoMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_fotoMenu.Image = ((System.Drawing.Image)(resources.GetObject("pic_fotoMenu.Image")));
            this.pic_fotoMenu.Location = new System.Drawing.Point(46, 5);
            this.pic_fotoMenu.Name = "pic_fotoMenu";
            this.pic_fotoMenu.Size = new System.Drawing.Size(81, 74);
            this.pic_fotoMenu.TabIndex = 17;
            this.pic_fotoMenu.TabStop = false;
            this.pic_fotoMenu.Click += new System.EventHandler(this.pic_fotoMenu_Click_1);
            // 
            // btn_exitMenu
            // 
            this.btn_exitMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exitMenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_exitMenu.Image")));
            this.btn_exitMenu.Location = new System.Drawing.Point(335, 27);
            this.btn_exitMenu.Name = "btn_exitMenu";
            this.btn_exitMenu.Size = new System.Drawing.Size(34, 37);
            this.btn_exitMenu.TabIndex = 20;
            this.btn_exitMenu.UseVisualStyleBackColor = true;
            this.btn_exitMenu.Click += new System.EventHandler(this.btn_exitMenu_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_nomeMenu);
            this.flowLayoutPanel1.Controls.Add(this.lbl_AcessoMenu);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(131, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 66);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // lbl_nomeMenu
            // 
            this.lbl_nomeMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_nomeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nomeMenu.Location = new System.Drawing.Point(3, 0);
            this.lbl_nomeMenu.Name = "lbl_nomeMenu";
            this.lbl_nomeMenu.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_nomeMenu.Size = new System.Drawing.Size(194, 26);
            this.lbl_nomeMenu.TabIndex = 18;
            this.lbl_nomeMenu.Text = "NULL";
            this.lbl_nomeMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_nomeMenu.Click += new System.EventHandler(this.lbl_nomeMenu_Click_1);
            // 
            // lbl_AcessoMenu
            // 
            this.lbl_AcessoMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_AcessoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AcessoMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AcessoMenu.Location = new System.Drawing.Point(3, 26);
            this.lbl_AcessoMenu.Name = "lbl_AcessoMenu";
            this.lbl_AcessoMenu.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_AcessoMenu.Size = new System.Drawing.Size(194, 31);
            this.lbl_AcessoMenu.TabIndex = 19;
            this.lbl_AcessoMenu.Text = "NULL";
            this.lbl_AcessoMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_AcessoMenu.Click += new System.EventHandler(this.lbl_AcessoMenu_Click_1);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(404, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 24);
            this.btn_close.TabIndex = 22;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // container_BotoesMenu
            // 
            this.container_BotoesMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.container_BotoesMenu.BackColor = System.Drawing.Color.Transparent;
            this.container_BotoesMenu.Controls.Add(this.gestaosenhas);
            this.container_BotoesMenu.Controls.Add(this.controlesenhas);
            this.container_BotoesMenu.Controls.Add(this.painelsenhas);
            this.container_BotoesMenu.Controls.Add(this.configuracoes);
            this.container_BotoesMenu.Controls.Add(this.exit);
            this.container_BotoesMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.container_BotoesMenu.Location = new System.Drawing.Point(3, 98);
            this.container_BotoesMenu.Name = "container_BotoesMenu";
            this.container_BotoesMenu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.container_BotoesMenu.Size = new System.Drawing.Size(432, 358);
            this.container_BotoesMenu.TabIndex = 21;
            this.container_BotoesMenu.WrapContents = false;
            this.container_BotoesMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.container_BotoesMenu_Paint_1);
            // 
            // gestaosenhas
            // 
            this.gestaosenhas.AutoSize = true;
            this.gestaosenhas.BackColor = System.Drawing.Color.Transparent;
            this.gestaosenhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gestaosenhas.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestaosenhas.Location = new System.Drawing.Point(3, 8);
            this.gestaosenhas.Name = "gestaosenhas";
            this.gestaosenhas.Size = new System.Drawing.Size(427, 64);
            this.gestaosenhas.TabIndex = 0;
            this.gestaosenhas.Text = "Gestão de Senhas";
            this.gestaosenhas.UseVisualStyleBackColor = false;
            this.gestaosenhas.Click += new System.EventHandler(this.gestaosenhas_Click_1);
            // 
            // controlesenhas
            // 
            this.controlesenhas.AutoSize = true;
            this.controlesenhas.BackColor = System.Drawing.Color.Transparent;
            this.controlesenhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlesenhas.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlesenhas.Location = new System.Drawing.Point(3, 78);
            this.controlesenhas.Name = "controlesenhas";
            this.controlesenhas.Size = new System.Drawing.Size(427, 64);
            this.controlesenhas.TabIndex = 1;
            this.controlesenhas.Text = "Controle de Senhas";
            this.controlesenhas.UseVisualStyleBackColor = false;
            this.controlesenhas.Click += new System.EventHandler(this.controlesenhas_Click_1);
            // 
            // painelsenhas
            // 
            this.painelsenhas.AutoSize = true;
            this.painelsenhas.BackColor = System.Drawing.Color.Transparent;
            this.painelsenhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.painelsenhas.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelsenhas.Location = new System.Drawing.Point(3, 148);
            this.painelsenhas.Name = "painelsenhas";
            this.painelsenhas.Size = new System.Drawing.Size(427, 64);
            this.painelsenhas.TabIndex = 2;
            this.painelsenhas.Text = "Painel de Senhas";
            this.painelsenhas.UseVisualStyleBackColor = false;
            this.painelsenhas.Click += new System.EventHandler(this.painelsenhas_Click_1);
            // 
            // configuracoes
            // 
            this.configuracoes.AutoSize = true;
            this.configuracoes.BackColor = System.Drawing.Color.Transparent;
            this.configuracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configuracoes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracoes.Location = new System.Drawing.Point(3, 218);
            this.configuracoes.Name = "configuracoes";
            this.configuracoes.Size = new System.Drawing.Size(427, 64);
            this.configuracoes.TabIndex = 3;
            this.configuracoes.Text = "Configurações";
            this.configuracoes.UseVisualStyleBackColor = false;
            this.configuracoes.Click += new System.EventHandler(this.configuracoes_Click_1);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(3, 288);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(427, 61);
            this.exit.TabIndex = 4;
            this.exit.Text = "Sair";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // sideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container_pai);
            this.Name = "sideBar";
            this.Size = new System.Drawing.Size(441, 468);
            this.container_pai.ResumeLayout(false);
            this.container_pai.PerformLayout();
            this.panel_itens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotoMenu)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.container_BotoesMenu.ResumeLayout(false);
            this.container_BotoesMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel container_pai;
        private System.Windows.Forms.FlowLayoutPanel container_BotoesMenu;
        private System.Windows.Forms.Button gestaosenhas;
        private System.Windows.Forms.Button controlesenhas;
        private System.Windows.Forms.Button painelsenhas;
        private System.Windows.Forms.Button configuracoes;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel_itens;
        private System.Windows.Forms.PictureBox pic_fotoMenu;
        private System.Windows.Forms.Button btn_exitMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_nomeMenu;
        private System.Windows.Forms.Label lbl_AcessoMenu;
        private System.Windows.Forms.Button btn_close;
    }
}
