using System;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editarCadastro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome_editar = new System.Windows.Forms.TextBox();
            this.txtSenha_editar = new System.Windows.Forms.TextBox();
            this.txtEmail_editar = new System.Windows.Forms.TextBox();
            this.txtSigla_editar = new System.Windows.Forms.TextBox();
            this.txtLogin_editar = new System.Windows.Forms.TextBox();
            this.foto_usuario_edicao = new System.Windows.Forms.PictureBox();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_nome_usuario = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_sigla = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_excluir_foto = new System.Windows.Forms.Button();
            this.btn_upload_picture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.acessosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_rjDataSet6 = new Projeto_RJ.projeto_rjDataSet6();
            this.acessosTableAdapter = new Projeto_RJ.projeto_rjDataSet6TableAdapters.acessosTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarios = new Projeto_RJ.usuarios();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_servico = new System.Windows.Forms.ComboBox();
            this.lbl_servico = new System.Windows.Forms.Label();
            this.cmb_Grupo_usuario = new System.Windows.Forms.ComboBox();
            this.lbl_grupo_usuario = new System.Windows.Forms.Label();
            this.datasetUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Projeto_RJ.usuariosTableAdapters.usuariosTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.id_tipoAtendimentoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.id_tipoAtendimentoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_usuario_edicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetUSUARIOSBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Location = new System.Drawing.Point(10, 0);
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(635, 567);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Size = new System.Drawing.Size(118, 53);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(442, 567);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Size = new System.Drawing.Size(118, 53);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
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
            this.txtSenha_editar.MaxLength = 100;
            this.txtSenha_editar.Name = "txtSenha_editar";
            this.txtSenha_editar.Size = new System.Drawing.Size(256, 22);
            this.txtSenha_editar.TabIndex = 31;
            this.txtSenha_editar.UseSystemPasswordChar = true;
            this.txtSenha_editar.TextChanged += new System.EventHandler(this.txtSenha_editar_TextChanged);
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
            this.foto_usuario_edicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // btn_excluir_foto
            // 
            this.btn_excluir_foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir_foto.BackgroundImage")));
            this.btn_excluir_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_excluir_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir_foto.Location = new System.Drawing.Point(1014, 335);
            this.btn_excluir_foto.Name = "btn_excluir_foto";
            this.btn_excluir_foto.Size = new System.Drawing.Size(29, 32);
            this.btn_excluir_foto.TabIndex = 9;
            this.btn_excluir_foto.UseVisualStyleBackColor = true;
            this.btn_excluir_foto.Click += new System.EventHandler(this.btn_excluir_foto_Click);
            // 
            // btn_upload_picture
            // 
            this.btn_upload_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_upload_picture.BackgroundImage")));
            this.btn_upload_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_upload_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_upload_picture.Location = new System.Drawing.Point(951, 335);
            this.btn_upload_picture.Name = "btn_upload_picture";
            this.btn_upload_picture.Size = new System.Drawing.Size(30, 32);
            this.btn_upload_picture.TabIndex = 7;
            this.btn_upload_picture.UseVisualStyleBackColor = true;
            this.btn_upload_picture.Click += new System.EventHandler(this.btn_upload_picture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // acessosBindingSource
            // 
            this.acessosBindingSource.DataMember = "acessos";
            this.acessosBindingSource.DataSource = this.projeto_rjDataSet6;
            // 
            // projeto_rjDataSet6
            // 
            this.projeto_rjDataSet6.DataSetName = "projeto_rjDataSet6";
            this.projeto_rjDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acessosTableAdapter
            // 
            this.acessosTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usuariosBindingSource;
            this.comboBox1.DisplayMember = "id_tipoAtendimento";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 474);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 24);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.ValueMember = "id_tipoAtendimento";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.usuarios;
            // 
            // usuarios
            // 
            this.usuarios.DataSetName = "usuarios";
            this.usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tipo de Atendimento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_servico
            // 
            this.cmb_servico.DataSource = this.usuariosBindingSource;
            this.cmb_servico.DisplayMember = "id_servico";
            this.cmb_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_servico.FormattingEnabled = true;
            this.cmb_servico.Location = new System.Drawing.Point(564, 474);
            this.cmb_servico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_servico.Name = "cmb_servico";
            this.cmb_servico.Size = new System.Drawing.Size(248, 24);
            this.cmb_servico.TabIndex = 45;
            this.cmb_servico.ValueMember = "id_acesso";
            this.cmb_servico.SelectedIndexChanged += new System.EventHandler(this.cmb_servico_SelectedIndexChanged);
            // 
            // lbl_servico
            // 
            this.lbl_servico.AutoSize = true;
            this.lbl_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servico.Location = new System.Drawing.Point(561, 442);
            this.lbl_servico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_servico.Name = "lbl_servico";
            this.lbl_servico.Size = new System.Drawing.Size(60, 16);
            this.lbl_servico.TabIndex = 44;
            this.lbl_servico.Text = "Serviço";
            this.lbl_servico.Click += new System.EventHandler(this.lbl_servico_Click);
            // 
            // cmb_Grupo_usuario
            // 
            this.cmb_Grupo_usuario.DataSource = this.acessosBindingSource;
            this.cmb_Grupo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Grupo_usuario.FormattingEnabled = true;
            this.cmb_Grupo_usuario.Location = new System.Drawing.Point(564, 260);
            this.cmb_Grupo_usuario.Name = "cmb_Grupo_usuario";
            this.cmb_Grupo_usuario.Size = new System.Drawing.Size(248, 24);
            this.cmb_Grupo_usuario.TabIndex = 36;
            this.cmb_Grupo_usuario.SelectedIndexChanged += new System.EventHandler(this.cmb_Grupo_usuario_SelectedIndexChanged);
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
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.id_tipoAtendimentoToolStripLabel,
            this.id_tipoAtendimentoToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1283, 25);
            this.fillByToolStrip.TabIndex = 46;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // id_tipoAtendimentoToolStripLabel
            // 
            this.id_tipoAtendimentoToolStripLabel.Name = "id_tipoAtendimentoToolStripLabel";
            this.id_tipoAtendimentoToolStripLabel.Size = new System.Drawing.Size(116, 15);
            this.id_tipoAtendimentoToolStripLabel.Text = "id_tipoAtendimento:";
            // 
            // id_tipoAtendimentoToolStripTextBox
            // 
            this.id_tipoAtendimentoToolStripTextBox.Name = "id_tipoAtendimentoToolStripTextBox";
            this.id_tipoAtendimentoToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 19);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // frm_editarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 641);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.cmb_servico);
            this.Controls.Add(this.lbl_servico);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Grupo_usuario);
            this.Controls.Add(this.btn_upload_picture);
            this.Controls.Add(this.btn_excluir_foto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome_editar);
            this.Controls.Add(this.txtSenha_editar);
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
            this.Load += new System.EventHandler(this.frm_editarCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_usuario_edicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_rjDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetUSUARIOSBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome_editar;
        private System.Windows.Forms.TextBox txtSenha_editar;
        private System.Windows.Forms.TextBox txtEmail_editar;
        private System.Windows.Forms.TextBox txtSigla_editar;
        private System.Windows.Forms.TextBox txtLogin_editar;
        private System.Windows.Forms.PictureBox foto_usuario_edicao;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_nome_usuario;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_sigla;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_excluir_foto;
        private System.Windows.Forms.Button btn_upload_picture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private void frm_editarCadastro_Load(object sender, EventArgs e)
        {
            try
            {
                
                this.acessosTableAdapter.Fill(this.projeto_rjDataSet6.acessos);

                // O Visual Studio costuma colocar a linha de Fill aqui embaixo:

            }
            catch (Exception ex)
            {
                // Se houver qualquer erro ao carregar, ele te avisa sem travar o programa
                MessageBox.Show("Aviso ao carregar dados: " + ex.Message);
            }
        }
        private projeto_rjDataSet6 projeto_rjDataSet6;
        private BindingSource acessosBindingSource;
        private projeto_rjDataSet6TableAdapters.acessosTableAdapter acessosTableAdapter;
        public ComboBox comboBox1;
        private Label label1;
        public ComboBox cmb_servico;
        private Label lbl_servico;
        private BindingSource datasetUSUARIOSBindingSource;
        public ComboBox cmb_Grupo_usuario;
        private Label lbl_grupo_usuario;
        private usuarios usuarios;
        private BindingSource usuariosBindingSource;
        private usuariosTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private ToolStrip fillByToolStrip;
        private ToolStripLabel id_tipoAtendimentoToolStripLabel;
        private ToolStripTextBox id_tipoAtendimentoToolStripTextBox;
        private ToolStripButton fillByToolStripButton;
    }
}