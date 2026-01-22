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
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_cadastrar_usuario = new System.Windows.Forms.Button();
            this.tbl_usuarios = new System.Windows.Forms.DataGridView();
            this.projeto_rjDataSet4 = new Projeto_RJ.projeto_rjDataSet4();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Projeto_RJ.projeto_rjDataSet4TableAdapters.usuariosTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
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
            this.btn_cadastrar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_usuario.Location = new System.Drawing.Point(1652, 175);
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
            this.tbl_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.sigla,
            this.email,
            this.usuario,
            this.senha,
            this.acesso,
            this.base64,
            this.btn_excluir,
            this.btn_editar});
            this.tbl_usuarios.DataSource = this.usuariosBindingSource;
            this.tbl_usuarios.Location = new System.Drawing.Point(2, 229);
            this.tbl_usuarios.Name = "tbl_usuarios";
            this.tbl_usuarios.Size = new System.Drawing.Size(1900, 548);
            this.tbl_usuarios.TabIndex = 15;
            this.tbl_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_usuarios_CellContentClick);
            // 
            // projeto_rjDataSet4
            // 
            this.projeto_rjDataSet4.DataSetName = "projeto_rjDataSet4";
            this.projeto_rjDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.projeto_rjDataSet4;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            // 
            // sigla
            // 
            this.sigla.DataPropertyName = "sigla";
            this.sigla.HeaderText = "sigla";
            this.sigla.Name = "sigla";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "senha";
            this.senha.Name = "senha";
            // 
            // acesso
            // 
            this.acesso.DataPropertyName = "acesso";
            this.acesso.HeaderText = "acesso";
            this.acesso.Name = "acesso";
            // 
            // base64
            // 
            this.base64.DataPropertyName = "imgbase64";
            this.base64.HeaderText = "imgbase64";
            this.base64.Name = "base64";
            this.base64.Visible = false;
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
            // btn_editar
            // 
            this.btn_editar.HeaderText = "";
            this.btn_editar.MinimumWidth = 40;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Width = 40;
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
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView tbl_usuarios;
        private projeto_rjDataSet4 projeto_rjDataSet4;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private projeto_rjDataSet4TableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn acesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn base64;
        private System.Windows.Forms.DataGridViewButtonColumn btn_excluir;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
    }
}