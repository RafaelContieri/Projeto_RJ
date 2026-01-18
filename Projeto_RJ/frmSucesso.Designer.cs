namespace Projeto_RJ
{
    partial class modalSucess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modalSucess));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lbl_senha_vinda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Red;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciar.Location = new System.Drawing.Point(258, 281);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(320, 60);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.Text = "FECHAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lbl_senha_vinda
            // 
            this.lbl_senha_vinda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_senha_vinda.Location = new System.Drawing.Point(0, 110);
            this.lbl_senha_vinda.Name = "lbl_senha_vinda";
            this.lbl_senha_vinda.Size = new System.Drawing.Size(823, 50);
            this.lbl_senha_vinda.TabIndex = 12;
            this.lbl_senha_vinda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_senha_vinda.Click += new System.EventHandler(this.lbl_senha_vinda_Click);
            // 
            // modalSucess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 376);
            this.Controls.Add(this.lbl_senha_vinda);
            this.Controls.Add(this.btnIniciar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1872, 882);
            this.MinimizeBox = false;
            this.Name = "modalSucess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lbl_senha_vinda;
    }
}