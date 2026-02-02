namespace Projeto_RJ
{
    partial class frm_telaSenhas
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
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_telaSenhas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_senhaDB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_guicheDB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flow_historico = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.DarkOrange;
            dateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new System.Drawing.Point(579, 471);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(326, 149);
            dateTimePicker2.TabIndex = 6;
            dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DarkOrange;
            dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(12, 665);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(62, 25);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 85);
            this.panel1.TabIndex = 9;
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(28, 27);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(289, 29);
            this.lbl_name_header.TabIndex = 7;
            this.lbl_name_header.Text = "CHAMADA DE SENHAS";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft YaHei", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(3, 111);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(539, 142);
            this.lbl_senha.TabIndex = 10;
            this.lbl_senha.Text = "SENHA  :";
            this.lbl_senha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_senha.Click += new System.EventHandler(this.lbl_senha_Click);
            // 
            // lbl_senhaDB
            // 
            this.lbl_senhaDB.AutoSize = true;
            this.lbl_senhaDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhaDB.Location = new System.Drawing.Point(563, 122);
            this.lbl_senhaDB.Name = "lbl_senhaDB";
            this.lbl_senhaDB.Size = new System.Drawing.Size(328, 120);
            this.lbl_senhaDB.TabIndex = 13;
            this.lbl_senhaDB.Text = "NULL";
            this.lbl_senhaDB.Click += new System.EventHandler(this.lbl_senhaDB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 142);
            this.label2.TabIndex = 15;
            this.label2.Text = "GUICHÊ :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_guicheDB
            // 
            this.lbl_guicheDB.AutoSize = true;
            this.lbl_guicheDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guicheDB.Location = new System.Drawing.Point(561, 264);
            this.lbl_guicheDB.Name = "lbl_guicheDB";
            this.lbl_guicheDB.Size = new System.Drawing.Size(328, 120);
            this.lbl_guicheDB.TabIndex = 16;
            this.lbl_guicheDB.Text = "NULL";
            this.lbl_guicheDB.Click += new System.EventHandler(this.lbl_guicheDB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 732);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Histórico de chamadas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flow_historico
            // 
            this.flow_historico.Location = new System.Drawing.Point(12, 798);
            this.flow_historico.Name = "flow_historico";
            this.flow_historico.Size = new System.Drawing.Size(1891, 231);
            this.flow_historico.TabIndex = 18;
            this.flow_historico.Paint += new System.Windows.Forms.PaintEventHandler(this.flow_historico_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 142);
            this.label1.TabIndex = 20;
            this.label1.Text = "HORA:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_telaSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(dateTimePicker1);
            this.Controls.Add(this.flow_historico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_guicheDB);
            this.Controls.Add(dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_senhaDB);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_telaSenhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_telaSenhas_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_senhaDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_guicheDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flow_historico;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}