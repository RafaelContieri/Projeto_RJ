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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.lbl_pesquisa_nome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_cadastrar_usuario = new System.Windows.Forms.Button();
            this.tbl_usuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_acesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipoAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.usuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.datasetUSUARIOS = new Projeto_RJ.datasetUSUARIOS();
            this.usuariosTableAdapter2 = new Projeto_RJ.datasetUSUARIOSTableAdapters.usuariosTableAdapter();
            this.projetorjDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter1 = new Projeto_RJ.tabela_usuarioTableAdapters.usuariosTableAdapter();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabela_usuario = new Projeto_RJ.tabela_usuario();
            this.usuariosTableAdapter = new Projeto_RJ.projeto_rjDataSet5TableAdapters.usuariosTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetorjDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_rjDataSet9 = new Projeto_RJ.projeto_rjDataSet9();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetUSUARIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetorjDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetorjDataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Location = new System.Drawing.Point(-164, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 85);
            this.panel1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1835, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 24;
            this.button2.Text = "   9";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(171, 27);
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
            this.lbl_pesquisa_nome.Location = new System.Drawing.Point(12, 101);
            this.lbl_pesquisa_nome.Name = "lbl_pesquisa_nome";
            this.lbl_pesquisa_nome.Size = new System.Drawing.Size(110, 16);
            this.lbl_pesquisa_nome.TabIndex = 11;
            this.lbl_pesquisa_nome.Text = "Nome do usuário";
            this.lbl_pesquisa_nome.Click += new System.EventHandler(this.lbl_pesquisa_nome_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1386, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // btn_cadastrar_usuario
            // 
            this.btn_cadastrar_usuario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cadastrar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_usuario.Location = new System.Drawing.Point(1203, 158);
            this.btn_cadastrar_usuario.Name = "btn_cadastrar_usuario";
            this.btn_cadastrar_usuario.Size = new System.Drawing.Size(195, 37);
            this.btn_cadastrar_usuario.TabIndex = 16;
            this.btn_cadastrar_usuario.Text = "CADASTRAR";
            this.btn_cadastrar_usuario.UseVisualStyleBackColor = false;
            this.btn_cadastrar_usuario.Click += new System.EventHandler(this.btn_cadastrar_usuario_Click);
            // 
            // tbl_usuarios
            // 
            this.tbl_usuarios.AllowUserToOrderColumns = true;
            this.tbl_usuarios.AutoGenerateColumns = false;
            this.tbl_usuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tbl_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_acesso,
            this.nome,
            this.sigla,
            this.email,
            this.usuario,
            this.senha,
            this.base64,
            this.id_servico,
            this.id_tipoAtendimento,
            this.btn_excluir,
            this.btn_editar});
            this.tbl_usuarios.DataSource = this.usuariosBindingSource2;
            this.tbl_usuarios.Location = new System.Drawing.Point(15, 201);
            this.tbl_usuarios.Name = "tbl_usuarios";
            this.tbl_usuarios.RowHeadersWidth = 51;
            this.tbl_usuarios.Size = new System.Drawing.Size(1383, 620);
            this.tbl_usuarios.TabIndex = 15;
            this.tbl_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_usuarios_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // id_acesso
            // 
            this.id_acesso.DataPropertyName = "id_acesso";
            this.id_acesso.HeaderText = "id_acesso";
            this.id_acesso.MinimumWidth = 6;
            this.id_acesso.Name = "id_acesso";
            this.id_acesso.Width = 125;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 125;
            // 
            // sigla
            // 
            this.sigla.DataPropertyName = "sigla";
            this.sigla.HeaderText = "sigla";
            this.sigla.MinimumWidth = 6;
            this.sigla.Name = "sigla";
            this.sigla.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.Width = 125;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "senha";
            this.senha.MinimumWidth = 6;
            this.senha.Name = "senha";
            this.senha.Width = 125;
            // 
            // base64
            // 
            this.base64.DataPropertyName = "imgbase64";
            this.base64.HeaderText = "imgbase64";
            this.base64.MinimumWidth = 6;
            this.base64.Name = "base64";
            this.base64.Width = 125;
            // 
            // id_servico
            // 
            this.id_servico.DataPropertyName = "id_servico";
            this.id_servico.HeaderText = "id_servico";
            this.id_servico.MinimumWidth = 6;
            this.id_servico.Name = "id_servico";
            this.id_servico.Width = 125;
            // 
            // id_tipoAtendimento
            // 
            this.id_tipoAtendimento.DataPropertyName = "id_tipoAtendimento";
            this.id_tipoAtendimento.HeaderText = "id_tipoAtendimento";
            this.id_tipoAtendimento.MinimumWidth = 6;
            this.id_tipoAtendimento.Name = "id_tipoAtendimento";
            this.id_tipoAtendimento.Width = 125;
            // 
            // btn_excluir
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_excluir.DefaultCellStyle = dataGridViewCellStyle2;
            this.btn_excluir.HeaderText = "";
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.MinimumWidth = 40;
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_excluir.Width = 40;
            // 
            // btn_editar
            // 
            this.btn_editar.HeaderText = "";
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.MinimumWidth = 40;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_editar.Width = 40;
            // 
            // usuariosBindingSource2
            // 
            this.usuariosBindingSource2.DataMember = "usuarios";
            this.usuariosBindingSource2.DataSource = this.datasetUSUARIOS;
            // 
            // datasetUSUARIOS
            // 
            this.datasetUSUARIOS.DataSetName = "datasetUSUARIOS";
            this.datasetUSUARIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter2
            // 
            this.usuariosTableAdapter2.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "usuarios";
            // 
            // tabela_usuario
            // 
            this.tabela_usuario.DataSetName = "tabela_usuario";
            this.tabela_usuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // projetorjDataSet9BindingSource
            // 
            this.projetorjDataSet9BindingSource.DataSource = this.projeto_rjDataSet9;
            this.projetorjDataSet9BindingSource.Position = 0;
            // 
            // projeto_rjDataSet9
            // 
            this.projeto_rjDataSet9.DataSetName = "projeto_rjDataSet9";
            this.projeto_rjDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 857);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetUSUARIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetorjDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetorjDataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Label lbl_pesquisa_nome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_cadastrar_usuario;
        private System.Windows.Forms.Button button2;
        private sideBar sideBar1;
        private System.Windows.Forms.DataGridView tbl_usuarios;
        private System.Windows.Forms.BindingSource usuariosBindingSource2;
        private datasetUSUARIOS datasetUSUARIOS;
        private datasetUSUARIOSTableAdapters.usuariosTableAdapter usuariosTableAdapter2;
        private System.Windows.Forms.BindingSource projetorjDataSet5BindingSource;
        private tabela_usuarioTableAdapters.usuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private tabela_usuario tabela_usuario;
        private projeto_rjDataSet5TableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.BindingSource projetorjDataSet9BindingSource;
        private projeto_rjDataSet9 projeto_rjDataSet9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_acesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn base64;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipoAtendimento;
        private System.Windows.Forms.DataGridViewImageColumn btn_excluir;
        private System.Windows.Forms.DataGridViewImageColumn btn_editar;
    }
}