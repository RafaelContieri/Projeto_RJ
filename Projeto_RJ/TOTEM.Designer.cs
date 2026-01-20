namespace Projeto_RJ
{
    partial class TOTEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TOTEM));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnIniciar);
            this.panel2.Location = new System.Drawing.Point(334, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 359);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 200);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(-3, 270);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(600, 80);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "TOQUE PARA INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Controls.Add(dateTimePicker2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 85);
            this.panel1.TabIndex = 9;
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(9, 29);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(218, 29);
            this.lbl_name_header.TabIndex = 5;
            this.lbl_name_header.Text = "TOTEM VIRTUAL";
            // 
            // TOTEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TOTEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.Load += new System.EventHandler(this.TOTEM_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
    }
}