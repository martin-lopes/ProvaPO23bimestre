namespace Prova
{
    partial class Inicial
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
            this.lb_bemvindo = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tx_numfun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_bemvindo
            // 
            this.lb_bemvindo.AutoSize = true;
            this.lb_bemvindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bemvindo.Location = new System.Drawing.Point(270, 42);
            this.lb_bemvindo.Name = "lb_bemvindo";
            this.lb_bemvindo.Size = new System.Drawing.Size(211, 42);
            this.lb_bemvindo.TabIndex = 1;
            this.lb_bemvindo.Text = "Bem-Vindo";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(177, 128);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(435, 29);
            this.lb_nome.TabIndex = 2;
            this.lb_nome.Text = "Quantos funcionários deseja cadastrar?";
            // 
            // tx_numfun
            // 
            this.tx_numfun.Location = new System.Drawing.Point(251, 178);
            this.tx_numfun.Name = "tx_numfun";
            this.tx_numfun.Size = new System.Drawing.Size(230, 20);
            this.tx_numfun.TabIndex = 8;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_numfun);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_bemvindo);
            this.Name = "Inicial";
            this.Text = "Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_bemvindo;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tx_numfun;
    }
}