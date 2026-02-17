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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DateTimePicker dateTimePicker2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_controleSenhas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.btn_refreshSenha = new System.Windows.Forms.Button();
            this.lbl_senhaChamada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChamarSenha = new System.Windows.Forms.Button();
            this.container_Senhas = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoatendimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusatendimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datageracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRBuscarSenhasChamadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_rjDataSet12 = new Projeto_RJ.projeto_rjDataSet12();
            this.lbl_senhas_chamadas = new System.Windows.Forms.Label();
            this.senhaChamada = new System.Windows.Forms.Label();
            this.pR_BuscarSenhasChamadasTableAdapter = new Projeto_RJ.projeto_rjDataSet12TableAdapters.PR_BuscarSenhasChamadasTableAdapter();
            this.atualizarListaAutomatico = new System.Windows.Forms.CheckBox();
            this.timerAtualizar = new System.Windows.Forms.Timer(this.components);
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRBuscarSenhasChamadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet12)).BeginInit();
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
            dateTimePicker2.Location = new System.Drawing.Point(1502, 27);
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
            // btn_refreshSenha
            // 
            this.btn_refreshSenha.BackColor = System.Drawing.Color.Indigo;
            this.btn_refreshSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refreshSenha.BackgroundImage")));
            this.btn_refreshSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refreshSenha.Location = new System.Drawing.Point(456, 140);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 763);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Histórico de chamadas";
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
            // container_Senhas
            // 
            this.container_Senhas.Location = new System.Drawing.Point(17, 805);
            this.container_Senhas.Name = "container_Senhas";
            this.container_Senhas.Size = new System.Drawing.Size(1854, 224);
            this.container_Senhas.TabIndex = 24;
            this.container_Senhas.WrapContents = false;
            this.container_Senhas.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Senhas_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.tipoatendimentoDataGridViewTextBoxColumn,
            this.servicoDataGridViewTextBoxColumn,
            this.statusatendimentoDataGridViewTextBoxColumn,
            this.datageracaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRBuscarSenhasChamadasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(952, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 575);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // tipoatendimentoDataGridViewTextBoxColumn
            // 
            this.tipoatendimentoDataGridViewTextBoxColumn.DataPropertyName = "tipo_atendimento";
            this.tipoatendimentoDataGridViewTextBoxColumn.HeaderText = "tipo_atendimento";
            this.tipoatendimentoDataGridViewTextBoxColumn.Name = "tipoatendimentoDataGridViewTextBoxColumn";
            // 
            // servicoDataGridViewTextBoxColumn
            // 
            this.servicoDataGridViewTextBoxColumn.DataPropertyName = "servico";
            this.servicoDataGridViewTextBoxColumn.HeaderText = "servico";
            this.servicoDataGridViewTextBoxColumn.Name = "servicoDataGridViewTextBoxColumn";
            // 
            // statusatendimentoDataGridViewTextBoxColumn
            // 
            this.statusatendimentoDataGridViewTextBoxColumn.DataPropertyName = "status_atendimento";
            this.statusatendimentoDataGridViewTextBoxColumn.HeaderText = "status_atendimento";
            this.statusatendimentoDataGridViewTextBoxColumn.Name = "statusatendimentoDataGridViewTextBoxColumn";
            // 
            // datageracaoDataGridViewTextBoxColumn
            // 
            this.datageracaoDataGridViewTextBoxColumn.DataPropertyName = "data_geracao";
            this.datageracaoDataGridViewTextBoxColumn.HeaderText = "data_geracao";
            this.datageracaoDataGridViewTextBoxColumn.Name = "datageracaoDataGridViewTextBoxColumn";
            // 
            // pRBuscarSenhasChamadasBindingSource
            // 
            this.pRBuscarSenhasChamadasBindingSource.DataMember = "PR_BuscarSenhasChamadas";
            this.pRBuscarSenhasChamadasBindingSource.DataSource = this.projeto_rjDataSet12;
            // 
            // projeto_rjDataSet12
            // 
            this.projeto_rjDataSet12.DataSetName = "projeto_rjDataSet12";
            this.projeto_rjDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_senhas_chamadas
            // 
            this.lbl_senhas_chamadas.AutoSize = true;
            this.lbl_senhas_chamadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhas_chamadas.Location = new System.Drawing.Point(947, 142);
            this.lbl_senhas_chamadas.Name = "lbl_senhas_chamadas";
            this.lbl_senhas_chamadas.Size = new System.Drawing.Size(192, 25);
            this.lbl_senhas_chamadas.TabIndex = 26;
            this.lbl_senhas_chamadas.Text = "Próximas senhas";
            // 
            // senhaChamada
            // 
            this.senhaChamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.senhaChamada.AutoSize = true;
            this.senhaChamada.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaChamada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.senhaChamada.Location = new System.Drawing.Point(27, 390);
            this.senhaChamada.Name = "senhaChamada";
            this.senhaChamada.Size = new System.Drawing.Size(0, 46);
            this.senhaChamada.TabIndex = 27;
            this.senhaChamada.Click += new System.EventHandler(this.senhaChamada_Click);
            // 
            // pR_BuscarSenhasChamadasTableAdapter
            // 
            this.pR_BuscarSenhasChamadasTableAdapter.ClearBeforeFill = true;
            // 
            // atualizarListaAutomatico
            // 
            this.atualizarListaAutomatico.AutoSize = true;
            this.atualizarListaAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarListaAutomatico.Location = new System.Drawing.Point(952, 170);
            this.atualizarListaAutomatico.Name = "atualizarListaAutomatico";
            this.atualizarListaAutomatico.Size = new System.Drawing.Size(147, 20);
            this.atualizarListaAutomatico.TabIndex = 28;
            this.atualizarListaAutomatico.Text = "Atualizar Automático";
            this.atualizarListaAutomatico.UseVisualStyleBackColor = true;
            this.atualizarListaAutomatico.CheckedChanged += new System.EventHandler(this.atualizarListaAutomatico_CheckedChanged);
            // 
            // timerAtualizar
            // 
            this.timerAtualizar.Interval = 10000;
            this.timerAtualizar.Tick += new System.EventHandler(this.timerAtualizar_Tick);
            // 
            // frm_controleSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.atualizarListaAutomatico);
            this.Controls.Add(this.senhaChamada);
            this.Controls.Add(this.lbl_senhas_chamadas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.container_Senhas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_senhaChamada);
            this.Controls.Add(this.btnChamarSenha);
            this.Controls.Add(this.btn_refreshSenha);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_controleSenhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_controleSenhas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRBuscarSenhasChamadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Button btn_refreshSenha;
        private System.Windows.Forms.Label lbl_senhaChamada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChamarSenha;
        private System.Windows.Forms.FlowLayoutPanel container_Senhas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_senhas_chamadas;
        private System.Windows.Forms.Label senhaChamada;
        private System.Windows.Forms.BindingSource pRBuscarSenhasChamadasBindingSource;
        private projeto_rjDataSet12 projeto_rjDataSet12;
        private projeto_rjDataSet12TableAdapters.PR_BuscarSenhasChamadasTableAdapter pR_BuscarSenhasChamadasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoatendimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusatendimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datageracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox atualizarListaAutomatico;
        private System.Windows.Forms.Timer timerAtualizar;
    }
}