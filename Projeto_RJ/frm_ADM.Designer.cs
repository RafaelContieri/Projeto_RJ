namespace Projeto_RJ
{
    partial class frm_ADM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ADM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.painel_botoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_gestaoSenhas = new System.Windows.Forms.Button();
            this.btn_controleSenha = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.sideBar1 = new Projeto_RJ.sideBar();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btn_perfil);
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 85);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_perfil
            // 
            this.btn_perfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_perfil.AutoSize = true;
            this.btn_perfil.BackColor = System.Drawing.Color.White;
            this.btn_perfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_perfil.Image = ((System.Drawing.Image)(resources.GetObject("btn_perfil.Image")));
            this.btn_perfil.Location = new System.Drawing.Point(1821, 24);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(32, 32);
            this.btn_perfil.TabIndex = 8;
            this.btn_perfil.Text = "   9";
            this.btn_perfil.UseVisualStyleBackColor = false;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(28, 27);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(450, 29);
            this.lbl_name_header.TabIndex = 7;
            this.lbl_name_header.Text = "PAINEL INICIAL > CONFIGURAÇÕES";
            this.lbl_name_header.Click += new System.EventHandler(this.lbl_name_header_Click);
            // 
            // painel_botoes
            // 
            this.painel_botoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painel_botoes.AutoSize = true;
            this.painel_botoes.Controls.Add(this.btn_gestaoSenhas);
            this.painel_botoes.Controls.Add(this.btn_controleSenha);
            this.painel_botoes.Controls.Add(this.button1);
            this.painel_botoes.Controls.Add(this.btn_config);
            this.painel_botoes.Location = new System.Drawing.Point(12, 108);
            this.painel_botoes.Name = "painel_botoes";
            this.painel_botoes.Size = new System.Drawing.Size(760, 350);
            this.painel_botoes.TabIndex = 21;
            this.painel_botoes.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_botoes_Paint);
            // 
            // btn_gestaoSenhas
            // 
            this.btn_gestaoSenhas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_gestaoSenhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gestaoSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestaoSenhas.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestaoSenhas.Image")));
            this.btn_gestaoSenhas.Location = new System.Drawing.Point(0, 0);
            this.btn_gestaoSenhas.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btn_gestaoSenhas.Name = "btn_gestaoSenhas";
            this.btn_gestaoSenhas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_gestaoSenhas.Size = new System.Drawing.Size(150, 150);
            this.btn_gestaoSenhas.TabIndex = 16;
            this.btn_gestaoSenhas.Text = "Gestão de Senhas";
            this.btn_gestaoSenhas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gestaoSenhas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_gestaoSenhas.UseVisualStyleBackColor = false;
            this.btn_gestaoSenhas.Click += new System.EventHandler(this.btn_gestaoSenhas_Click_1);
            // 
            // btn_controleSenha
            // 
            this.btn_controleSenha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_controleSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_controleSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_controleSenha.Image = ((System.Drawing.Image)(resources.GetObject("btn_controleSenha.Image")));
            this.btn_controleSenha.Location = new System.Drawing.Point(190, 0);
            this.btn_controleSenha.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btn_controleSenha.Name = "btn_controleSenha";
            this.btn_controleSenha.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_controleSenha.Size = new System.Drawing.Size(150, 150);
            this.btn_controleSenha.TabIndex = 17;
            this.btn_controleSenha.Text = "Controle de Senhas";
            this.btn_controleSenha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_controleSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_controleSenha.UseVisualStyleBackColor = false;
            this.btn_controleSenha.Click += new System.EventHandler(this.btn_controleSenha_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(380, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 19;
            this.button1.Text = "senha_painel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.Image = ((System.Drawing.Image)(resources.GetObject("btn_config.Image")));
            this.btn_config.Location = new System.Drawing.Point(570, 0);
            this.btn_config.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btn_config.Name = "btn_config";
            this.btn_config.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_config.Size = new System.Drawing.Size(150, 150);
            this.btn_config.TabIndex = 18;
            this.btn_config.Text = "Configurações";
            this.btn_config.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_config.UseVisualStyleBackColor = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click_1);
            // 
            // sideBar1
            // 
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideBar1.Location = new System.Drawing.Point(1463, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(441, 1041);
            this.sideBar1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1116, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 23;
            this.button2.Text = "   9";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.painel_botoes);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_ADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ADM_FormClosed);
            this.Load += new System.EventHandler(this.frm_ADM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.FlowLayoutPanel painel_botoes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_gestaoSenhas;
        private System.Windows.Forms.Button btn_controleSenha;
        private System.Windows.Forms.Button btn_config;
        private sideBar sideBar1;
        private System.Windows.Forms.Button button2;
    }
}