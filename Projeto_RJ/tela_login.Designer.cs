namespace Projeto_RJ
{
    partial class tela_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_header_login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_senha_login = new System.Windows.Forms.Label();
            this.txt_usuario_login = new System.Windows.Forms.TextBox();
            this.txt_senha_login = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 85);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(549, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 80);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(643, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 476);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_header_login
            // 
            this.lbl_header_login.AutoSize = true;
            this.lbl_header_login.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header_login.Location = new System.Drawing.Point(15, 167);
            this.lbl_header_login.Name = "lbl_header_login";
            this.lbl_header_login.Size = new System.Drawing.Size(508, 86);
            this.lbl_header_login.TabIndex = 12;
            this.lbl_header_login.Text = "Faça seu Login";
            this.lbl_header_login.Click += new System.EventHandler(this.lbl_header_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usuário";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_senha_login
            // 
            this.lbl_senha_login.AutoSize = true;
            this.lbl_senha_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha_login.Location = new System.Drawing.Point(27, 421);
            this.lbl_senha_login.Name = "lbl_senha_login";
            this.lbl_senha_login.Size = new System.Drawing.Size(51, 16);
            this.lbl_senha_login.TabIndex = 14;
            this.lbl_senha_login.Text = "Senha";
            this.lbl_senha_login.Click += new System.EventHandler(this.lbl_senha_login_Click);
            // 
            // txt_usuario_login
            // 
            this.txt_usuario_login.Location = new System.Drawing.Point(27, 321);
            this.txt_usuario_login.Name = "txt_usuario_login";
            this.txt_usuario_login.Size = new System.Drawing.Size(305, 20);
            this.txt_usuario_login.TabIndex = 15;
            this.txt_usuario_login.TextChanged += new System.EventHandler(this.txt_usuario_login_TextChanged);
            // 
            // txt_senha_login
            // 
            this.txt_senha_login.Location = new System.Drawing.Point(27, 456);
            this.txt_senha_login.Name = "txt_senha_login";
            this.txt_senha_login.Size = new System.Drawing.Size(305, 20);
            this.txt_senha_login.TabIndex = 16;
            this.txt_senha_login.UseSystemPasswordChar = true;
            this.txt_senha_login.TextChanged += new System.EventHandler(this.txt_senha_login_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(27, 543);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(195, 37);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_senha_login);
            this.Controls.Add(this.txt_usuario_login);
            this.Controls.Add(this.lbl_senha_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_header_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "tela_login";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_header_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_senha_login;
        private System.Windows.Forms.TextBox txt_usuario_login;
        private System.Windows.Forms.TextBox txt_senha_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button1;
    }
}