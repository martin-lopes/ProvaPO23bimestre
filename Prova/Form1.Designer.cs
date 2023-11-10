namespace Prova
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_gurudev = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_matricula = new System.Windows.Forms.Label();
            this.lb_datanasc = new System.Windows.Forms.Label();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.lb_salario = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_matricula = new System.Windows.Forms.TextBox();
            this.date_datanasc = new System.Windows.Forms.DateTimePicker();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_sexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_gurudev
            // 
            this.lb_gurudev.AutoSize = true;
            this.lb_gurudev.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gurudev.Location = new System.Drawing.Point(260, 22);
            this.lb_gurudev.Name = "lb_gurudev";
            this.lb_gurudev.Size = new System.Drawing.Size(175, 42);
            this.lb_gurudev.TabIndex = 0;
            this.lb_gurudev.Text = "GuruDev";
            this.lb_gurudev.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(42, 107);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(85, 29);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(42, 196);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(67, 29);
            this.lb_cpf.TabIndex = 2;
            this.lb_cpf.Text = "CPF:";
            // 
            // lb_matricula
            // 
            this.lb_matricula.AutoSize = true;
            this.lb_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricula.Location = new System.Drawing.Point(42, 282);
            this.lb_matricula.Name = "lb_matricula";
            this.lb_matricula.Size = new System.Drawing.Size(116, 29);
            this.lb_matricula.TabIndex = 3;
            this.lb_matricula.Text = "Matrícula:";
            // 
            // lb_datanasc
            // 
            this.lb_datanasc.AutoSize = true;
            this.lb_datanasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datanasc.Location = new System.Drawing.Point(286, 196);
            this.lb_datanasc.Name = "lb_datanasc";
            this.lb_datanasc.Size = new System.Drawing.Size(231, 29);
            this.lb_datanasc.TabIndex = 4;
            this.lb_datanasc.Text = "Data de nascimento:";
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sexo.Location = new System.Drawing.Point(352, 107);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(74, 29);
            this.lb_sexo.TabIndex = 5;
            this.lb_sexo.Text = "Sexo:";
            // 
            // lb_salario
            // 
            this.lb_salario.AutoSize = true;
            this.lb_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salario.Location = new System.Drawing.Point(286, 278);
            this.lb_salario.Name = "lb_salario";
            this.lb_salario.Size = new System.Drawing.Size(95, 29);
            this.lb_salario.TabIndex = 6;
            this.lb_salario.Text = "Salário:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(47, 139);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(292, 20);
            this.tx_nome.TabIndex = 7;
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(47, 223);
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(233, 20);
            this.tx_cpf.TabIndex = 8;
            // 
            // tx_matricula
            // 
            this.tx_matricula.Location = new System.Drawing.Point(47, 310);
            this.tx_matricula.Name = "tx_matricula";
            this.tx_matricula.Size = new System.Drawing.Size(233, 20);
            this.tx_matricula.TabIndex = 9;
            // 
            // date_datanasc
            // 
            this.date_datanasc.Location = new System.Drawing.Point(291, 223);
            this.date_datanasc.Name = "date_datanasc";
            this.date_datanasc.Size = new System.Drawing.Size(226, 20);
            this.date_datanasc.TabIndex = 10;
            // 
            // tx_salario
            // 
            this.tx_salario.Location = new System.Drawing.Point(291, 310);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(226, 20);
            this.tx_salario.TabIndex = 12;
            // 
            // tx_sexo
            // 
            this.tx_sexo.FormattingEnabled = true;
            this.tx_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não dizer"});
            this.tx_sexo.Location = new System.Drawing.Point(357, 139);
            this.tx_sexo.Name = "tx_sexo";
            this.tx_sexo.Size = new System.Drawing.Size(160, 21);
            this.tx_sexo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_sexo);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.date_datanasc);
            this.Controls.Add(this.tx_matricula);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.lb_salario);
            this.Controls.Add(this.lb_sexo);
            this.Controls.Add(this.lb_datanasc);
            this.Controls.Add(this.lb_matricula);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_gurudev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_gurudev;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_matricula;
        private System.Windows.Forms.Label lb_datanasc;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.Label lb_salario;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.TextBox tx_matricula;
        private System.Windows.Forms.DateTimePicker date_datanasc;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.ComboBox tx_sexo;
    }
}

