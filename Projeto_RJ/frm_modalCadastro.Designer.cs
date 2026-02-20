namespace Projeto_RJ
{
    partial class frm_modalCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modalCadastro));
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_sigla = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_nome_usuario = new System.Windows.Forms.Label();
            this.lbl_grupo_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.picture_imagemUsuario = new System.Windows.Forms.PictureBox();
            this.cmb_Grupo_usuario = new System.Windows.Forms.ComboBox();
            this.acessosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_rjDataSet7 = new Projeto_RJ.projeto_rjDataSet7();
            this.projetorjDataSet61BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acessosTableAdapter = new Projeto_RJ.projeto_rjDataSet7TableAdapters.acessosTableAdapter();
            this.btn_upload_picture = new System.Windows.Forms.Button();
            this.btn_excluir_foto = new System.Windows.Forms.Button();
            this.projeto_rjDataSet16 = new Projeto_RJ.projeto_rjDataSet16();
            this.acessosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.acessosTableAdapter1 = new Projeto_RJ.projeto_rjDataSet16TableAdapters.acessosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagemUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetorjDataSet61BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(50, 324);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(45, 16);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // lbl_sigla
            // 
            this.lbl_sigla.AutoSize = true;
            this.lbl_sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sigla.Location = new System.Drawing.Point(587, 118);
            this.lbl_sigla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sigla.Name = "lbl_sigla";
            this.lbl_sigla.Size = new System.Drawing.Size(43, 16);
            this.lbl_sigla.TabIndex = 1;
            this.lbl_sigla.Text = "Sigla";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(49, 215);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 16);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // lbl_nome_usuario
            // 
            this.lbl_nome_usuario.AutoSize = true;
            this.lbl_nome_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_usuario.Location = new System.Drawing.Point(50, 118);
            this.lbl_nome_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome_usuario.Name = "lbl_nome_usuario";
            this.lbl_nome_usuario.Size = new System.Drawing.Size(48, 16);
            this.lbl_nome_usuario.TabIndex = 3;
            this.lbl_nome_usuario.Text = "Nome";
            this.lbl_nome_usuario.Click += new System.EventHandler(this.lbl_nome_usuario_Click);
            // 
            // lbl_grupo_usuario
            // 
            this.lbl_grupo_usuario.AutoSize = true;
            this.lbl_grupo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo_usuario.Location = new System.Drawing.Point(587, 215);
            this.lbl_grupo_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_grupo_usuario.Name = "lbl_grupo_usuario";
            this.lbl_grupo_usuario.Size = new System.Drawing.Size(126, 16);
            this.lbl_grupo_usuario.TabIndex = 4;
            this.lbl_grupo_usuario.Text = "Grupo de usuário";
            this.lbl_grupo_usuario.Click += new System.EventHandler(this.lbl_grupo_usuario_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(587, 324);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(51, 16);
            this.lbl_senha.TabIndex = 5;
            this.lbl_senha.Text = "Senha";
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.Location = new System.Drawing.Point(1029, 99);
            this.lbl_foto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(38, 16);
            this.lbl_foto.TabIndex = 6;
            this.lbl_foto.Text = "Foto";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Location = new System.Drawing.Point(-105, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 85);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(118, 30);
            this.lbl_name_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(316, 29);
            this.lbl_name_header.TabIndex = 5;
            this.lbl_name_header.Text = "CADASTRO DE USUÁRIO";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(54, 356);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(424, 22);
            this.txtLogin.TabIndex = 3;
            // 
            // txtSigla
            // 
            this.txtSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.Location = new System.Drawing.Point(590, 150);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(248, 22);
            this.txtSigla.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(52, 249);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(424, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(52, 150);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(424, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(590, 356);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(248, 22);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(666, 472);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Size = new System.Drawing.Size(118, 53);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(457, 472);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Size = new System.Drawing.Size(118, 53);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // picture_imagemUsuario
            // 
            this.picture_imagemUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_imagemUsuario.BackgroundImage")));
            this.picture_imagemUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_imagemUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_imagemUsuario.Location = new System.Drawing.Point(948, 118);
            this.picture_imagemUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture_imagemUsuario.Name = "picture_imagemUsuario";
            this.picture_imagemUsuario.Size = new System.Drawing.Size(200, 200);
            this.picture_imagemUsuario.TabIndex = 10;
            this.picture_imagemUsuario.TabStop = false;
            this.picture_imagemUsuario.Click += new System.EventHandler(this.picture_imagemUsuario_Click);
            // 
            // cmb_Grupo_usuario
            // 
            this.cmb_Grupo_usuario.DataSource = this.acessosBindingSource1;
            this.cmb_Grupo_usuario.DisplayMember = "NomeMenu";
            this.cmb_Grupo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Grupo_usuario.FormattingEnabled = true;
            this.cmb_Grupo_usuario.Location = new System.Drawing.Point(590, 247);
            this.cmb_Grupo_usuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Grupo_usuario.Name = "cmb_Grupo_usuario";
            this.cmb_Grupo_usuario.Size = new System.Drawing.Size(248, 24);
            this.cmb_Grupo_usuario.TabIndex = 37;
            this.cmb_Grupo_usuario.ValueMember = "ID";
            // 
            // acessosBindingSource
            // 
            this.acessosBindingSource.DataMember = "acessos";
            this.acessosBindingSource.DataSource = this.projeto_rjDataSet7;
            // 
            // projeto_rjDataSet7
            // 
            this.projeto_rjDataSet7.DataSetName = "projeto_rjDataSet7";
            this.projeto_rjDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acessosTableAdapter
            // 
            this.acessosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_upload_picture
            // 
            this.btn_upload_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_upload_picture.BackgroundImage")));
            this.btn_upload_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_upload_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_upload_picture.Location = new System.Drawing.Point(998, 324);
            this.btn_upload_picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_upload_picture.Name = "btn_upload_picture";
            this.btn_upload_picture.Size = new System.Drawing.Size(35, 32);
            this.btn_upload_picture.TabIndex = 38;
            this.btn_upload_picture.UseVisualStyleBackColor = true;
            this.btn_upload_picture.Click += new System.EventHandler(this.btn_upload_picture_Click_1);
            // 
            // btn_excluir_foto
            // 
            this.btn_excluir_foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir_foto.BackgroundImage")));
            this.btn_excluir_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_excluir_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir_foto.Location = new System.Drawing.Point(1071, 324);
            this.btn_excluir_foto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_excluir_foto.Name = "btn_excluir_foto";
            this.btn_excluir_foto.Size = new System.Drawing.Size(34, 32);
            this.btn_excluir_foto.TabIndex = 39;
            this.btn_excluir_foto.UseVisualStyleBackColor = true;
            this.btn_excluir_foto.Click += new System.EventHandler(this.btn_excluir_foto_Click);
            // 
            // projeto_rjDataSet16
            // 
            this.projeto_rjDataSet16.DataSetName = "projeto_rjDataSet16";
            this.projeto_rjDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acessosBindingSource1
            // 
            this.acessosBindingSource1.DataMember = "acessos";
            this.acessosBindingSource1.DataSource = this.projeto_rjDataSet16;
            // 
            // acessosTableAdapter1
            // 
            this.acessosTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_modalCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 641);
            this.Controls.Add(this.btn_upload_picture);
            this.Controls.Add(this.btn_excluir_foto);
            this.Controls.Add(this.cmb_Grupo_usuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.picture_imagemUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_grupo_usuario);
            this.Controls.Add(this.lbl_nome_usuario);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_sigla);
            this.Controls.Add(this.lbl_login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_modalCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.Load += new System.EventHandler(this.frm_modalCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagemUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetorjDataSet61BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_sigla;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_nome_usuario;
        private System.Windows.Forms.Label lbl_grupo_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.PictureBox picture_imagemUsuario;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cmb_Grupo_usuario;
        private System.Windows.Forms.BindingSource projetorjDataSet61BindingSource;
        private projeto_rjDataSet7 projeto_rjDataSet7;
        private System.Windows.Forms.BindingSource acessosBindingSource;
        private projeto_rjDataSet7TableAdapters.acessosTableAdapter acessosTableAdapter;
        private System.Windows.Forms.Button btn_upload_picture;
        private System.Windows.Forms.Button btn_excluir_foto;
        private projeto_rjDataSet16 projeto_rjDataSet16;
        private System.Windows.Forms.BindingSource acessosBindingSource1;
        private projeto_rjDataSet16TableAdapters.acessosTableAdapter acessosTableAdapter1;
    }
}