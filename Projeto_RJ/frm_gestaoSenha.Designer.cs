namespace Projeto_RJ
{
    partial class frm_gestaoSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gestaoSenha));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.panel_atendimentoTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbl_qtdPessoas = new System.Windows.Forms.Label();
            this.lbl_atTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRecepcao = new System.Windows.Forms.Label();
            this.lbl_pessoas = new System.Windows.Forms.Label();
            this.lbl_recepcao = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRetiradaExames = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_retiradaExames = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPreferencial = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_atendimentoTotal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 85);
            this.panel1.TabIndex = 12;
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(28, 27);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(486, 29);
            this.lbl_name_header.TabIndex = 7;
            this.lbl_name_header.Text = "PAINEL INICIAL > GESTÃO DE SENHAS";
            // 
            // panel_atendimentoTotal
            // 
            this.panel_atendimentoTotal.BackColor = System.Drawing.Color.Green;
            this.panel_atendimentoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_atendimentoTotal.Controls.Add(this.lblTotal);
            this.panel_atendimentoTotal.Controls.Add(this.lbl_qtdPessoas);
            this.panel_atendimentoTotal.Controls.Add(this.lbl_atTotal);
            this.panel_atendimentoTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_atendimentoTotal.Location = new System.Drawing.Point(12, 101);
            this.panel_atendimentoTotal.Name = "panel_atendimentoTotal";
            this.panel_atendimentoTotal.Size = new System.Drawing.Size(200, 200);
            this.panel_atendimentoTotal.TabIndex = 13;
            this.panel_atendimentoTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_atendimentoTotal_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(-1, 56);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 86);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.Click += new System.EventHandler(this.lbl_quantidade_Click);
            // 
            // lbl_qtdPessoas
            // 
            this.lbl_qtdPessoas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_qtdPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdPessoas.Location = new System.Drawing.Point(3, 174);
            this.lbl_qtdPessoas.Name = "lbl_qtdPessoas";
            this.lbl_qtdPessoas.Size = new System.Drawing.Size(192, 16);
            this.lbl_qtdPessoas.TabIndex = 1;
            this.lbl_qtdPessoas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_qtdPessoas.Click += new System.EventHandler(this.lbl_qtdPessoas_Click);
            // 
            // lbl_atTotal
            // 
            this.lbl_atTotal.AutoSize = true;
            this.lbl_atTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_atTotal.Location = new System.Drawing.Point(15, 18);
            this.lbl_atTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_atTotal.Name = "lbl_atTotal";
            this.lbl_atTotal.Size = new System.Drawing.Size(170, 16);
            this.lbl_atTotal.TabIndex = 0;
            this.lbl_atTotal.Text = "ATENDIMENTO TOTAL";
            this.lbl_atTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_atTotal.Click += new System.EventHandler(this.lbl_atTotal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblRecepcao);
            this.panel2.Controls.Add(this.lbl_pessoas);
            this.panel2.Controls.Add(this.lbl_recepcao);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(237, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 14;
            // 
            // lblRecepcao
            // 
            this.lblRecepcao.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecepcao.Location = new System.Drawing.Point(-1, 56);
            this.lblRecepcao.Name = "lblRecepcao";
            this.lblRecepcao.Size = new System.Drawing.Size(200, 86);
            this.lblRecepcao.TabIndex = 2;
            this.lblRecepcao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecepcao.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_pessoas
            // 
            this.lbl_pessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pessoas.Location = new System.Drawing.Point(3, 174);
            this.lbl_pessoas.Name = "lbl_pessoas";
            this.lbl_pessoas.Size = new System.Drawing.Size(196, 16);
            this.lbl_pessoas.TabIndex = 1;
            this.lbl_pessoas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pessoas.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_recepcao
            // 
            this.lbl_recepcao.AutoSize = true;
            this.lbl_recepcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recepcao.Location = new System.Drawing.Point(57, 18);
            this.lbl_recepcao.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_recepcao.Name = "lbl_recepcao";
            this.lbl_recepcao.Size = new System.Drawing.Size(89, 16);
            this.lbl_recepcao.TabIndex = 0;
            this.lbl_recepcao.Text = "RECEPÇÃO";
            this.lbl_recepcao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_recepcao.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblRetiradaExames);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbl_retiradaExames);
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(462, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 200);
            this.panel3.TabIndex = 15;
            // 
            // lblRetiradaExames
            // 
            this.lblRetiradaExames.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiradaExames.Location = new System.Drawing.Point(-1, 56);
            this.lblRetiradaExames.Name = "lblRetiradaExames";
            this.lblRetiradaExames.Size = new System.Drawing.Size(200, 86);
            this.lblRetiradaExames.TabIndex = 2;
            this.lblRetiradaExames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRetiradaExames.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 16);
            this.label5.TabIndex = 1;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_retiradaExames
            // 
            this.lbl_retiradaExames.AutoSize = true;
            this.lbl_retiradaExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_retiradaExames.Location = new System.Drawing.Point(9, 18);
            this.lbl_retiradaExames.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_retiradaExames.Name = "lbl_retiradaExames";
            this.lbl_retiradaExames.Size = new System.Drawing.Size(174, 16);
            this.lbl_retiradaExames.TabIndex = 0;
            this.lbl_retiradaExames.Text = "RETIRADA DE EXAMES";
            this.lbl_retiradaExames.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_retiradaExames.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblPreferencial);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(687, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 200);
            this.panel4.TabIndex = 16;
            // 
            // lblPreferencial
            // 
            this.lblPreferencial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreferencial.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferencial.Location = new System.Drawing.Point(-1, 56);
            this.lblPreferencial.Name = "lblPreferencial";
            this.lblPreferencial.Size = new System.Drawing.Size(200, 86);
            this.lblPreferencial.TabIndex = 2;
            this.lblPreferencial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreferencial.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 16);
            this.label8.TabIndex = 1;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "PREFERÊNCIAL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // frm_gestaoSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_atendimentoTotal);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_gestaoSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliníca Exames";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_gestaoSenha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_atendimentoTotal.ResumeLayout(false);
            this.panel_atendimentoTotal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Panel panel_atendimentoTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbl_atTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRecepcao;
        private System.Windows.Forms.Label lbl_recepcao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRetiradaExames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_retiradaExames;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPreferencial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lbl_qtdPessoas;
        private System.Windows.Forms.Label lbl_pessoas;
    }
}