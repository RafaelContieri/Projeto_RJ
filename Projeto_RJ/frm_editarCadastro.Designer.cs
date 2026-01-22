namespace Projeto_RJ
{
    partial class frm_editarCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editarCadastro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btn_upload_picture = new System.Windows.Forms.Button();
            this.btn_excluir_foto = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome_editar = new System.Windows.Forms.TextBox();
            this.txtSenha_editar = new System.Windows.Forms.TextBox();
            this.txtGrupoUsuario_editar = new System.Windows.Forms.TextBox();
            this.txtEmail_editar = new System.Windows.Forms.TextBox();
            this.txtSigla_editar = new System.Windows.Forms.TextBox();
            this.txtLogin_editar = new System.Windows.Forms.TextBox();
            this.foto_usuario_edicao = new System.Windows.Forms.PictureBox();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_grupo_usuario = new System.Windows.Forms.Label();
            this.lbl_nome_usuario = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_sigla = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_usuario_edicao)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.DarkOrange;
            dateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker2.Location = new System.Drawing.Point(1028, 27);
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
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 85);
            this.panel1.TabIndex = 10;
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(9, 29);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(227, 29);
            this.lbl_name_header.TabIndex = 5;
            this.lbl_name_header.Text = "EDITAR USUÁRIO";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btn_upload_picture);
            this.grbOpcoes.Controls.Add(this.btn_excluir_foto);
            this.grbOpcoes.Controls.Add(this.btnRefresh);
            this.grbOpcoes.Location = new System.Drawing.Point(901, 332);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(200, 64);
            this.grbOpcoes.TabIndex = 36;
            this.grbOpcoes.TabStop = false;
            // 
            // btn_upload_picture
            // 
            this.btn_upload_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_upload_picture.BackgroundImage")));
            this.btn_upload_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_upload_picture.Location = new System.Drawing.Point(26, 17);
            this.btn_upload_picture.Name = "btn_upload_picture";
            this.btn_upload_picture.Size = new System.Drawing.Size(30, 32);
            this.btn_upload_picture.TabIndex = 7;
            this.btn_upload_picture.UseVisualStyleBackColor = true;
            // 
            // btn_excluir_foto
            // 
            this.btn_excluir_foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir_foto.BackgroundImage")));
            this.btn_excluir_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_excluir_foto.Location = new System.Drawing.Point(151, 16);
            this.btn_excluir_foto.Name = "btn_excluir_foto";
            this.btn_excluir_foto.Size = new System.Drawing.Size(29, 32);
            this.btn_excluir_foto.TabIndex = 9;
            this.btn_excluir_foto.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(89, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 32);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Projeto_RJ.Properties.Resources.Close;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(564, 478);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 53);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Projeto_RJ.Properties.Resources.Salvar_24_24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(382, 478);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 53);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome_editar
            // 
            this.txtNome_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome_editar.Location = new System.Drawing.Point(48, 161);
            this.txtNome_editar.Name = "txtNome_editar";
            this.txtNome_editar.Size = new System.Drawing.Size(424, 22);
            this.txtNome_editar.TabIndex = 21;
            this.txtNome_editar.TextChanged += new System.EventHandler(this.txtNome_editar_TextChanged);
            // 
            // txtSenha_editar
            // 
            this.txtSenha_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha_editar.Location = new System.Drawing.Point(564, 367);
            this.txtSenha_editar.Name = "txtSenha_editar";
            this.txtSenha_editar.Size = new System.Drawing.Size(256, 22);
            this.txtSenha_editar.TabIndex = 31;
            this.txtSenha_editar.TextChanged += new System.EventHandler(this.txtSenha_editar_TextChanged);
            // 
            // txtGrupoUsuario_editar
            // 
            this.txtGrupoUsuario_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupoUsuario_editar.Location = new System.Drawing.Point(564, 260);
            this.txtGrupoUsuario_editar.Name = "txtGrupoUsuario_editar";
            this.txtGrupoUsuario_editar.Size = new System.Drawing.Size(256, 22);
            this.txtGrupoUsuario_editar.TabIndex = 30;
            this.txtGrupoUsuario_editar.TextChanged += new System.EventHandler(this.txtGrupoUsuario_editar_TextChanged);
            // 
            // txtEmail_editar
            // 
            this.txtEmail_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail_editar.Location = new System.Drawing.Point(48, 260);
            this.txtEmail_editar.Name = "txtEmail_editar";
            this.txtEmail_editar.Size = new System.Drawing.Size(424, 22);
            this.txtEmail_editar.TabIndex = 24;
            this.txtEmail_editar.TextChanged += new System.EventHandler(this.txtEmail_editar_TextChanged);
            // 
            // txtSigla_editar
            // 
            this.txtSigla_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla_editar.Location = new System.Drawing.Point(564, 161);
            this.txtSigla_editar.Name = "txtSigla_editar";
            this.txtSigla_editar.Size = new System.Drawing.Size(248, 22);
            this.txtSigla_editar.TabIndex = 27;
            this.txtSigla_editar.TextChanged += new System.EventHandler(this.txtSigla_editar_TextChanged);
            // 
            // txtLogin_editar
            // 
            this.txtLogin_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin_editar.Location = new System.Drawing.Point(49, 367);
            this.txtLogin_editar.Name = "txtLogin_editar";
            this.txtLogin_editar.Size = new System.Drawing.Size(424, 22);
            this.txtLogin_editar.TabIndex = 26;
            this.txtLogin_editar.TextChanged += new System.EventHandler(this.txtLogin_editar_TextChanged);
            // 
            // foto_usuario_edicao
            // 
            this.foto_usuario_edicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.foto_usuario_edicao.Location = new System.Drawing.Point(901, 129);
            this.foto_usuario_edicao.Name = "foto_usuario_edicao";
            this.foto_usuario_edicao.Size = new System.Drawing.Size(200, 200);
            this.foto_usuario_edicao.TabIndex = 33;
            this.foto_usuario_edicao.TabStop = false;
            this.foto_usuario_edicao.Click += new System.EventHandler(this.foto_usuario_edicao_Click);
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.Location = new System.Drawing.Point(979, 110);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(38, 16);
            this.lbl_foto.TabIndex = 32;
            this.lbl_foto.Text = "Foto";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(561, 335);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(51, 16);
            this.lbl_senha.TabIndex = 29;
            this.lbl_senha.Text = "Senha";
            // 
            // lbl_grupo_usuario
            // 
            this.lbl_grupo_usuario.AutoSize = true;
            this.lbl_grupo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo_usuario.Location = new System.Drawing.Point(561, 226);
            this.lbl_grupo_usuario.Name = "lbl_grupo_usuario";
            this.lbl_grupo_usuario.Size = new System.Drawing.Size(126, 16);
            this.lbl_grupo_usuario.TabIndex = 28;
            this.lbl_grupo_usuario.Text = "Grupo de usuário";
            // 
            // lbl_nome_usuario
            // 
            this.lbl_nome_usuario.AutoSize = true;
            this.lbl_nome_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_usuario.Location = new System.Drawing.Point(46, 129);
            this.lbl_nome_usuario.Name = "lbl_nome_usuario";
            this.lbl_nome_usuario.Size = new System.Drawing.Size(48, 16);
            this.lbl_nome_usuario.TabIndex = 25;
            this.lbl_nome_usuario.Text = "Nome";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(45, 226);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 16);
            this.lbl_email.TabIndex = 23;
            this.lbl_email.Text = "Email";
            // 
            // lbl_sigla
            // 
            this.lbl_sigla.AutoSize = true;
            this.lbl_sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sigla.Location = new System.Drawing.Point(561, 129);
            this.lbl_sigla.Name = "lbl_sigla";
            this.lbl_sigla.Size = new System.Drawing.Size(43, 16);
            this.lbl_sigla.TabIndex = 22;
            this.lbl_sigla.Text = "Sigla";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(46, 335);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(45, 16);
            this.lbl_login.TabIndex = 20;
            this.lbl_login.Text = "Login";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_editarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 641);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome_editar);
            this.Controls.Add(this.txtSenha_editar);
            this.Controls.Add(this.txtGrupoUsuario_editar);
            this.Controls.Add(this.txtEmail_editar);
            this.Controls.Add(this.txtSigla_editar);
            this.Controls.Add(this.txtLogin_editar);
            this.Controls.Add(this.foto_usuario_edicao);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_grupo_usuario);
            this.Controls.Add(this.lbl_nome_usuario);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_sigla);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_editarCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foto_usuario_edicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btn_upload_picture;
        private System.Windows.Forms.Button btn_excluir_foto;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome_editar;
        private System.Windows.Forms.TextBox txtSenha_editar;
        private System.Windows.Forms.TextBox txtGrupoUsuario_editar;
        private System.Windows.Forms.TextBox txtEmail_editar;
        private System.Windows.Forms.TextBox txtSigla_editar;
        private System.Windows.Forms.TextBox txtLogin_editar;
        private System.Windows.Forms.PictureBox foto_usuario_edicao;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_grupo_usuario;
        private System.Windows.Forms.Label lbl_nome_usuario;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_sigla;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}