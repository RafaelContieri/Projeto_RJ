namespace Projeto_RJ
{
    partial class frm_controleSenhas
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
            System.Windows.Forms.DateTimePicker dateTimePicker2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_controleSenhas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.btnChamarSenha = new System.Windows.Forms.Button();
            this.btn_refreshSenha = new System.Windows.Forms.Button();
            this.lbl_senhaChamada = new System.Windows.Forms.Label();
            this.panel_senhaChamada = new System.Windows.Forms.Panel();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.comb_tipoGuiche = new System.Windows.Forms.ComboBox();
            this.lbl_selecionarServico = new System.Windows.Forms.Label();
            this.tbl_chamarSenha = new System.Windows.Forms.DataGridView();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guichê = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_historicoSenhas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_senhasChamadas = new System.Windows.Forms.Label();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel_senhaChamada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_chamarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_historicoSenhas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.DarkOrange;
            dateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker2.Location = new System.Drawing.Point(1655, 25);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(222, 32);
            dateTimePicker2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Controls.Add(dateTimePicker2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 85);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(28, 27);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(523, 29);
            this.lbl_name_header.TabIndex = 7;
            this.lbl_name_header.Text = "PAINEL INICIAL > CONTROLE DE SENHAS";
            this.lbl_name_header.Click += new System.EventHandler(this.lbl_name_header_Click);
            // 
            // btnChamarSenha
            // 
            this.btnChamarSenha.BackColor = System.Drawing.Color.ForestGreen;
            this.btnChamarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamarSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamarSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChamarSenha.Location = new System.Drawing.Point(35, 140);
            this.btnChamarSenha.Name = "btnChamarSenha";
            this.btnChamarSenha.Size = new System.Drawing.Size(390, 95);
            this.btnChamarSenha.TabIndex = 12;
            this.btnChamarSenha.Text = "CHAMAR SENHA";
            this.btnChamarSenha.UseVisualStyleBackColor = false;
            this.btnChamarSenha.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btn_refreshSenha
            // 
            this.btn_refreshSenha.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_refreshSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refreshSenha.BackgroundImage")));
            this.btn_refreshSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refreshSenha.Location = new System.Drawing.Point(419, 140);
            this.btn_refreshSenha.Name = "btn_refreshSenha";
            this.btn_refreshSenha.Size = new System.Drawing.Size(95, 95);
            this.btn_refreshSenha.TabIndex = 13;
            this.btn_refreshSenha.TabStop = false;
            this.btn_refreshSenha.UseVisualStyleBackColor = false;
            this.btn_refreshSenha.Click += new System.EventHandler(this.btn_refreshSenha_Click);
            // 
            // lbl_senhaChamada
            // 
            this.lbl_senhaChamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_senhaChamada.AutoSize = true;
            this.lbl_senhaChamada.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhaChamada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_senhaChamada.Location = new System.Drawing.Point(27, 275);
            this.lbl_senhaChamada.Name = "lbl_senhaChamada";
            this.lbl_senhaChamada.Size = new System.Drawing.Size(462, 46);
            this.lbl_senhaChamada.TabIndex = 14;
            this.lbl_senhaChamada.Text = "SENHA A SER CHAMADA";
            this.lbl_senhaChamada.Click += new System.EventHandler(this.lbl_senhaChamada_Click);
            // 
            // panel_senhaChamada
            // 
            this.panel_senhaChamada.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_senhaChamada.Controls.Add(this.lblSenhaAtual);
            this.panel_senhaChamada.Location = new System.Drawing.Point(35, 333);
            this.panel_senhaChamada.Name = "panel_senhaChamada";
            this.panel_senhaChamada.Size = new System.Drawing.Size(479, 315);
            this.panel_senhaChamada.TabIndex = 15;
            this.panel_senhaChamada.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_senhaChamada_Paint);
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.Location = new System.Drawing.Point(0, 0);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(479, 315);
            this.lblSenhaAtual.TabIndex = 0;
            this.lblSenhaAtual.Text = "SenhaChamada";
            this.lblSenhaAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSenhaAtual.Click += new System.EventHandler(this.lblSenhaAtual_Click);
            // 
            // comb_tipoGuiche
            // 
            this.comb_tipoGuiche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_tipoGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_tipoGuiche.FormattingEnabled = true;
            this.comb_tipoGuiche.Location = new System.Drawing.Point(1047, 167);
            this.comb_tipoGuiche.Name = "comb_tipoGuiche";
            this.comb_tipoGuiche.Size = new System.Drawing.Size(244, 32);
            this.comb_tipoGuiche.TabIndex = 16;
            this.comb_tipoGuiche.SelectedIndexChanged += new System.EventHandler(this.comb_tipoGuiche_SelectedIndexChanged);
            // 
            // lbl_selecionarServico
            // 
            this.lbl_selecionarServico.AutoSize = true;
            this.lbl_selecionarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecionarServico.Location = new System.Drawing.Point(1043, 140);
            this.lbl_selecionarServico.Name = "lbl_selecionarServico";
            this.lbl_selecionarServico.Size = new System.Drawing.Size(262, 24);
            this.lbl_selecionarServico.TabIndex = 17;
            this.lbl_selecionarServico.Text = "Selecione o tipo de guichê";
            this.lbl_selecionarServico.Click += new System.EventHandler(this.lbl_selecionarServico_Click);
            // 
            // tbl_chamarSenha
            // 
            this.tbl_chamarSenha.AllowUserToOrderColumns = true;
            this.tbl_chamarSenha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_chamarSenha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Senha,
            this.Mesa,
            this.Guichê});
            this.tbl_chamarSenha.Location = new System.Drawing.Point(1047, 228);
            this.tbl_chamarSenha.Name = "tbl_chamarSenha";
            this.tbl_chamarSenha.Size = new System.Drawing.Size(782, 280);
            this.tbl_chamarSenha.TabIndex = 18;
            this.tbl_chamarSenha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_chamarSenha_CellContentClick);
            // 
            // Senha
            // 
            this.Senha.FillWeight = 500F;
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            // 
            // Mesa
            // 
            this.Mesa.HeaderText = "Mesa";
            this.Mesa.Name = "Mesa";
            // 
            // Guichê
            // 
            this.Guichê.HeaderText = "Guichê";
            this.Guichê.Name = "Guichê";
            // 
            // tbl_historicoSenhas
            // 
            this.tbl_historicoSenhas.AllowUserToOrderColumns = true;
            this.tbl_historicoSenhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_historicoSenhas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tbl_historicoSenhas.Location = new System.Drawing.Point(1047, 696);
            this.tbl_historicoSenhas.Name = "tbl_historicoSenhas";
            this.tbl_historicoSenhas.Size = new System.Drawing.Size(782, 280);
            this.tbl_historicoSenhas.TabIndex = 19;
            this.tbl_historicoSenhas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_historicoSenhas_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 500F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mesa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Guichê";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lbl_senhasChamadas
            // 
            this.lbl_senhasChamadas.AutoSize = true;
            this.lbl_senhasChamadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhasChamadas.Location = new System.Drawing.Point(1043, 660);
            this.lbl_senhasChamadas.Name = "lbl_senhasChamadas";
            this.lbl_senhasChamadas.Size = new System.Drawing.Size(181, 24);
            this.lbl_senhasChamadas.TabIndex = 20;
            this.lbl_senhasChamadas.Text = "Senhas chamadas";
            this.lbl_senhasChamadas.Click += new System.EventHandler(this.lbl_senhasChamadas_Click);
            // 
            // frm_controleSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lbl_senhasChamadas);
            this.Controls.Add(this.tbl_historicoSenhas);
            this.Controls.Add(this.tbl_chamarSenha);
            this.Controls.Add(this.lbl_selecionarServico);
            this.Controls.Add(this.comb_tipoGuiche);
            this.Controls.Add(this.panel_senhaChamada);
            this.Controls.Add(this.lbl_senhaChamada);
            this.Controls.Add(this.btnChamarSenha);
            this.Controls.Add(this.btn_refreshSenha);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_controleSenhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_controleSenhas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_senhaChamada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_chamarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_historicoSenhas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Button btnChamarSenha;
        private System.Windows.Forms.Button btn_refreshSenha;
        private System.Windows.Forms.Label lbl_senhaChamada;
        private System.Windows.Forms.Panel panel_senhaChamada;
        private System.Windows.Forms.ComboBox comb_tipoGuiche;
        private System.Windows.Forms.Label lbl_selecionarServico;
        private System.Windows.Forms.DataGridView tbl_chamarSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guichê;
        private System.Windows.Forms.DataGridView tbl_historicoSenhas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lbl_senhasChamadas;
        private System.Windows.Forms.Label lblSenhaAtual;
    }
}