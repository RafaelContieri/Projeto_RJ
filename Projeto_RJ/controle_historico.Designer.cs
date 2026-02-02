namespace Projeto_RJ
{
    partial class controle_historico
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_senha_hist = new System.Windows.Forms.Label();
            this.lbl_guiche_hist = new System.Windows.Forms.Label();
            this.lbl_guiche_banco = new System.Windows.Forms.Label();
            this.lbl_senhaBanco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_senha_hist
            // 
            this.lbl_senha_hist.AutoSize = true;
            this.lbl_senha_hist.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_senha_hist.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha_hist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_senha_hist.Location = new System.Drawing.Point(16, 36);
            this.lbl_senha_hist.Name = "lbl_senha_hist";
            this.lbl_senha_hist.Size = new System.Drawing.Size(124, 37);
            this.lbl_senha_hist.TabIndex = 0;
            this.lbl_senha_hist.Text = "Senha:";
            this.lbl_senha_hist.Click += new System.EventHandler(this.lbl_senha_hist_Click);
            // 
            // lbl_guiche_hist
            // 
            this.lbl_guiche_hist.AutoSize = true;
            this.lbl_guiche_hist.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guiche_hist.Location = new System.Drawing.Point(16, 89);
            this.lbl_guiche_hist.Name = "lbl_guiche_hist";
            this.lbl_guiche_hist.Size = new System.Drawing.Size(134, 37);
            this.lbl_guiche_hist.TabIndex = 2;
            this.lbl_guiche_hist.Text = "Guiche:";
            this.lbl_guiche_hist.Click += new System.EventHandler(this.lbl_guiche_hist_Click);
            // 
            // lbl_guiche_banco
            // 
            this.lbl_guiche_banco.AutoSize = true;
            this.lbl_guiche_banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guiche_banco.Location = new System.Drawing.Point(146, 91);
            this.lbl_guiche_banco.Name = "lbl_guiche_banco";
            this.lbl_guiche_banco.Size = new System.Drawing.Size(93, 33);
            this.lbl_guiche_banco.TabIndex = 5;
            this.lbl_guiche_banco.Text = "label3";
            this.lbl_guiche_banco.Click += new System.EventHandler(this.lbl_guiche_banco_Click);
            // 
            // lbl_senhaBanco
            // 
            this.lbl_senhaBanco.AutoSize = true;
            this.lbl_senhaBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhaBanco.Location = new System.Drawing.Point(146, 36);
            this.lbl_senhaBanco.Name = "lbl_senhaBanco";
            this.lbl_senhaBanco.Size = new System.Drawing.Size(93, 33);
            this.lbl_senhaBanco.TabIndex = 6;
            this.lbl_senhaBanco.Text = "label3";
            this.lbl_senhaBanco.Click += new System.EventHandler(this.lbl_senhaBanco_Click);
            // 
            // controle_historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.lbl_senhaBanco);
            this.Controls.Add(this.lbl_guiche_banco);
            this.Controls.Add(this.lbl_guiche_hist);
            this.Controls.Add(this.lbl_senha_hist);
            this.Name = "controle_historico";
            this.Size = new System.Drawing.Size(367, 164);
            this.Load += new System.EventHandler(this.controle_historico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_senha_hist;
        private System.Windows.Forms.Label lbl_guiche_hist;
        private System.Windows.Forms.Label lbl_guiche_banco;
        private System.Windows.Forms.Label lbl_senhaBanco;
    }
}
