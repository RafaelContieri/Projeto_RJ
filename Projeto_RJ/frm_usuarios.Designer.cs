namespace Projeto_RJ
{
    partial class frm_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.lbl_pesquisa_nome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_rjDataSet = new Projeto_RJ.projeto_rjDataSet();
            this.usuariosTableAdapter = new Projeto_RJ.projeto_rjDataSetTableAdapters.usuariosTableAdapter();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.projetorjDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senhasTableAdapter = new Projeto_RJ.projeto_rjDataSetTableAdapters.senhasTableAdapter();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_rjDataSet1 = new Projeto_RJ.projeto_rjDataSet1();
            this.btn_cadastrar_usuario = new System.Windows.Forms.Button();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbl_usuarios = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetorjDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senhasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource3)).BeginInit();
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
            dateTimePicker2.Location = new System.Drawing.Point(1512, 27);
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
            this.panel1.TabIndex = 10;
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(28, 27);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(610, 29);
            this.lbl_name_header.TabIndex = 7;
            this.lbl_name_header.Text = "PAINEL INICIAL > CONFIGURAÇÕES > USUÁRIOS";
            this.lbl_name_header.Click += new System.EventHandler(this.lbl_name_header_Click);
            // 
            // lbl_pesquisa_nome
            // 
            this.lbl_pesquisa_nome.AutoSize = true;
            this.lbl_pesquisa_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisa_nome.Location = new System.Drawing.Point(12, 123);
            this.lbl_pesquisa_nome.Name = "lbl_pesquisa_nome";
            this.lbl_pesquisa_nome.Size = new System.Drawing.Size(110, 16);
            this.lbl_pesquisa_nome.TabIndex = 11;
            this.lbl_pesquisa_nome.Text = "Nome do usuário";
            this.lbl_pesquisa_nome.Click += new System.EventHandler(this.lbl_pesquisa_nome_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1835, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.projeto_rjDataSet;
            // 
            // projeto_rjDataSet
            // 
            this.projeto_rjDataSet.DataSetName = "projeto_rjDataSet";
            this.projeto_rjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.BackgroundImage")));
            this.btn_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Location = new System.Drawing.Point(1853, 135);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(39, 34);
            this.btn_pesquisar.TabIndex = 14;
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            this.btn_pesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_pesquisar_KeyDown);
            // 
            // projetorjDataSetBindingSource
            // 
            this.projetorjDataSetBindingSource.DataSource = this.projeto_rjDataSet;
            this.projetorjDataSetBindingSource.Position = 0;
            // 
            // senhasBindingSource
            // 
            this.senhasBindingSource.DataMember = "senhas";
            this.senhasBindingSource.DataSource = this.projetorjDataSetBindingSource;
            // 
            // senhasTableAdapter
            // 
            this.senhasTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "usuarios";
            this.usuariosBindingSource1.DataSource = this.projetorjDataSetBindingSource;
            // 
            // usuariosBindingSource2
            // 
            this.usuariosBindingSource2.DataMember = "usuarios";
            this.usuariosBindingSource2.DataSource = this.projetorjDataSetBindingSource;
            // 
            // projeto_rjDataSet1
            // 
            this.projeto_rjDataSet1.DataSetName = "projeto_rjDataSet1";
            this.projeto_rjDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_cadastrar_usuario
            // 
            this.btn_cadastrar_usuario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cadastrar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_usuario.Location = new System.Drawing.Point(1652, 175);
            this.btn_cadastrar_usuario.Name = "btn_cadastrar_usuario";
            this.btn_cadastrar_usuario.Size = new System.Drawing.Size(195, 37);
            this.btn_cadastrar_usuario.TabIndex = 16;
            this.btn_cadastrar_usuario.Text = "CADASTRAR";
            this.btn_cadastrar_usuario.UseVisualStyleBackColor = false;
            this.btn_cadastrar_usuario.Click += new System.EventHandler(this.btn_cadastrar_usuario_Click);
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btn_editar
            // 
            this.btn_editar.HeaderText = "";
            this.btn_editar.MinimumWidth = 40;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Width = 40;
            // 
            // btn_excluir
            // 
            this.btn_excluir.HeaderText = "";
            this.btn_excluir.MinimumWidth = 40;
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_excluir.Width = 40;
            // 
            // tbl_usuarios
            // 
            this.tbl_usuarios.AllowUserToOrderColumns = true;
            this.tbl_usuarios.AutoGenerateColumns = false;
            this.tbl_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.btn_excluir,
            this.btn_editar});
            this.tbl_usuarios.DataSource = this.usuariosBindingSource3;
            this.tbl_usuarios.Location = new System.Drawing.Point(2, 229);
            this.tbl_usuarios.Name = "tbl_usuarios";
            this.tbl_usuarios.Size = new System.Drawing.Size(1900, 548);
            this.tbl_usuarios.TabIndex = 15;
            this.tbl_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_usuarios_CellContentClick);
            // 
            // usuariosBindingSource3
            // 
            this.usuariosBindingSource3.DataMember = "usuarios";
            this.usuariosBindingSource3.DataSource = this.projetorjDataSetBindingSource;
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_cadastrar_usuario);
            this.Controls.Add(this.tbl_usuarios);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_pesquisa_nome);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetorjDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senhasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Label lbl_pesquisa_nome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_pesquisar;
        private projeto_rjDataSet projeto_rjDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private projeto_rjDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource projetorjDataSetBindingSource;
        private System.Windows.Forms.BindingSource senhasBindingSource;
        private projeto_rjDataSetTableAdapters.senhasTableAdapter senhasTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.BindingSource usuariosBindingSource2;
        private projeto_rjDataSet1 projeto_rjDataSet1;
        private System.Windows.Forms.Button btn_cadastrar_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_excluir;
        private System.Windows.Forms.DataGridView tbl_usuarios;
        private System.Windows.Forms.BindingSource usuariosBindingSource3;
    }
}