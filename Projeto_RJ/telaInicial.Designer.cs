namespace Projeto_RJ
{
    partial class telaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.containerImagem = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerImagem)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 85);
            this.panel1.TabIndex = 8;
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(28, 27);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(218, 29);
            this.lbl_name_header.TabIndex = 7;
            this.lbl_name_header.Text = "TOTEM VIRTUAL";
            this.lbl_name_header.Click += new System.EventHandler(this.lbl_name_header_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.containerImagem);
            this.panel2.Controls.Add(this.btnIniciar);
            this.panel2.Location = new System.Drawing.Point(655, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 835);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(600, 80);
            this.button1.TabIndex = 14;
            this.button1.Text = "ATENDIMENTO PRIORITÁRIO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 751);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(600, 80);
            this.button3.TabIndex = 13;
            this.button3.Text = "SAIR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(600, 80);
            this.button2.TabIndex = 12;
            this.button2.Text = "RETIRADA DE EXAMES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // containerImagem
            // 
            this.containerImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.containerImagem.Image = ((System.Drawing.Image)(resources.GetObject("containerImagem.Image")));
            this.containerImagem.Location = new System.Drawing.Point(0, 0);
            this.containerImagem.Name = "containerImagem";
            this.containerImagem.Size = new System.Drawing.Size(600, 200);
            this.containerImagem.TabIndex = 9;
            this.containerImagem.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(0, 401);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(600, 80);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "RECEPÇÃO";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "telaInicial";
            this.Text = " Clínica Exames";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaInicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox containerImagem;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}