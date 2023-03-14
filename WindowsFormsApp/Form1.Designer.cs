namespace WindowsFormsApp
{
    partial class Form1
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
            this.CPF = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.DiasTrabalhados = new System.Windows.Forms.Label();
            this.ValorDiaria = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtDiaria = new System.Windows.Forms.TextBox();
            this.SalarioBase = new System.Windows.Forms.Label();
            this.ValorIR = new System.Windows.Forms.Label();
            this.SalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalBase = new System.Windows.Forms.TextBox();
            this.txtValorIR = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(30, 32);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(30, 13);
            this.CPF.TabIndex = 0;
            this.CPF.Text = "CPF";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(30, 87);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(39, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // DiasTrabalhados
            // 
            this.DiasTrabalhados.AutoSize = true;
            this.DiasTrabalhados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasTrabalhados.Location = new System.Drawing.Point(289, 32);
            this.DiasTrabalhados.Name = "DiasTrabalhados";
            this.DiasTrabalhados.Size = new System.Drawing.Size(102, 13);
            this.DiasTrabalhados.TabIndex = 2;
            this.DiasTrabalhados.Text = "Dias trabalhados";
            // 
            // ValorDiaria
            // 
            this.ValorDiaria.AutoSize = true;
            this.ValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorDiaria.Location = new System.Drawing.Point(289, 87);
            this.ValorDiaria.Name = "ValorDiaria";
            this.ValorDiaria.Size = new System.Drawing.Size(89, 13);
            this.ValorDiaria.TabIndex = 3;
            this.ValorDiaria.Text = "Valor da diária";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(404, 29);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(102, 20);
            this.txtDias.TabIndex = 6;
            // 
            // txtDiaria
            // 
            this.txtDiaria.Location = new System.Drawing.Point(404, 84);
            this.txtDiaria.Name = "txtDiaria";
            this.txtDiaria.Size = new System.Drawing.Size(102, 20);
            this.txtDiaria.TabIndex = 7;
            this.txtDiaria.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SalarioBase
            // 
            this.SalarioBase.AutoSize = true;
            this.SalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioBase.Location = new System.Drawing.Point(45, 213);
            this.SalarioBase.Name = "SalarioBase";
            this.SalarioBase.Size = new System.Drawing.Size(78, 13);
            this.SalarioBase.TabIndex = 8;
            this.SalarioBase.Text = "Salário Base";
            // 
            // ValorIR
            // 
            this.ValorIR.AutoSize = true;
            this.ValorIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorIR.Location = new System.Drawing.Point(231, 213);
            this.ValorIR.Name = "ValorIR";
            this.ValorIR.Size = new System.Drawing.Size(71, 13);
            this.ValorIR.TabIndex = 9;
            this.ValorIR.Text = "Valor do IR";
            // 
            // SalarioLiquido
            // 
            this.SalarioLiquido.AutoSize = true;
            this.SalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioLiquido.Location = new System.Drawing.Point(413, 213);
            this.SalarioLiquido.Name = "SalarioLiquido";
            this.SalarioLiquido.Size = new System.Drawing.Size(93, 13);
            this.SalarioLiquido.TabIndex = 10;
            this.SalarioLiquido.Text = "Salário Líquido";
            this.SalarioLiquido.Click += new System.EventHandler(this.SalarioLiquido_Click_1);
            // 
            // txtSalBase
            // 
            this.txtSalBase.Location = new System.Drawing.Point(33, 190);
            this.txtSalBase.Name = "txtSalBase";
            this.txtSalBase.Size = new System.Drawing.Size(102, 20);
            this.txtSalBase.TabIndex = 11;
            // 
            // txtValorIR
            // 
            this.txtValorIR.Location = new System.Drawing.Point(215, 190);
            this.txtValorIR.Name = "txtValorIR";
            this.txtValorIR.Size = new System.Drawing.Size(102, 20);
            this.txtValorIR.TabIndex = 12;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Location = new System.Drawing.Point(404, 190);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(102, 20);
            this.txtSalLiquido.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(542, 49);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 36);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(77, 29);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(82, 20);
            this.txtCPF.TabIndex = 15;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 249);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtValorIR);
            this.Controls.Add(this.txtSalBase);
            this.Controls.Add(this.SalarioLiquido);
            this.Controls.Add(this.ValorIR);
            this.Controls.Add(this.SalarioBase);
            this.Controls.Add(this.txtDiaria);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.ValorDiaria);
            this.Controls.Add(this.DiasTrabalhados);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.CPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label DiasTrabalhados;
        private System.Windows.Forms.Label ValorDiaria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtDiaria;
        private System.Windows.Forms.Label SalarioBase;
        private System.Windows.Forms.Label ValorIR;
        private System.Windows.Forms.Label SalarioLiquido;
        private System.Windows.Forms.TextBox txtSalBase;
        private System.Windows.Forms.TextBox txtValorIR;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox txtCPF;
    }
}

