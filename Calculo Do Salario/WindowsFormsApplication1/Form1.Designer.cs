namespace WindowsFormsApplication1
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblNFilhos = new System.Windows.Forms.Label();
            this.lblInss = new System.Windows.Forms.Label();
            this.lblIrrf = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblDescInss = new System.Windows.Forms.Label();
            this.lblDescIrrf = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNFilhos = new System.Windows.Forms.TextBox();
            this.txtInss = new System.Windows.Forms.TextBox();
            this.txtIrrf = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtDescInss = new System.Windows.Forms.TextBox();
            this.txtDescIrrf = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSalario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalario.Location = new System.Drawing.Point(26, 19);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(73, 25);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salário";
            // 
            // lblNFilhos
            // 
            this.lblNFilhos.AutoSize = true;
            this.lblNFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNFilhos.Location = new System.Drawing.Point(26, 65);
            this.lblNFilhos.Name = "lblNFilhos";
            this.lblNFilhos.Size = new System.Drawing.Size(91, 25);
            this.lblNFilhos.TabIndex = 1;
            this.lblNFilhos.Text = "N° Filhos";
            // 
            // lblInss
            // 
            this.lblInss.AutoSize = true;
            this.lblInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblInss.Location = new System.Drawing.Point(26, 111);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(59, 25);
            this.lblInss.TabIndex = 2;
            this.lblInss.Text = "INSS";
            // 
            // lblIrrf
            // 
            this.lblIrrf.AutoSize = true;
            this.lblIrrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIrrf.Location = new System.Drawing.Point(26, 154);
            this.lblIrrf.Name = "lblIrrf";
            this.lblIrrf.Size = new System.Drawing.Size(55, 25);
            this.lblIrrf.TabIndex = 3;
            this.lblIrrf.Text = "IRRF";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSalLiquido.Location = new System.Drawing.Point(26, 203);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(114, 25);
            this.lblSalLiquido.TabIndex = 4;
            this.lblSalLiquido.Text = "Sal. Liquido";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSalFamilia.Location = new System.Drawing.Point(336, 65);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(113, 25);
            this.lblSalFamilia.TabIndex = 5;
            this.lblSalFamilia.Text = "Sal. Familia";
            // 
            // lblDescInss
            // 
            this.lblDescInss.AutoSize = true;
            this.lblDescInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescInss.Location = new System.Drawing.Point(336, 111);
            this.lblDescInss.Name = "lblDescInss";
            this.lblDescInss.Size = new System.Drawing.Size(114, 25);
            this.lblDescInss.TabIndex = 6;
            this.lblDescInss.Text = "Desc. INSS";
            // 
            // lblDescIrrf
            // 
            this.lblDescIrrf.AutoSize = true;
            this.lblDescIrrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescIrrf.Location = new System.Drawing.Point(336, 157);
            this.lblDescIrrf.Name = "lblDescIrrf";
            this.lblDescIrrf.Size = new System.Drawing.Size(110, 25);
            this.lblDescIrrf.TabIndex = 7;
            this.lblDescIrrf.Text = "Desc. IRRF";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSalario.Location = new System.Drawing.Point(146, 16);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(163, 30);
            this.txtSalario.TabIndex = 8;
            // 
            // txtNFilhos
            // 
            this.txtNFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNFilhos.Location = new System.Drawing.Point(146, 62);
            this.txtNFilhos.Name = "txtNFilhos";
            this.txtNFilhos.Size = new System.Drawing.Size(163, 30);
            this.txtNFilhos.TabIndex = 9;
            // 
            // txtInss
            // 
            this.txtInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtInss.Location = new System.Drawing.Point(146, 108);
            this.txtInss.Name = "txtInss";
            this.txtInss.Size = new System.Drawing.Size(163, 30);
            this.txtInss.TabIndex = 10;
            // 
            // txtIrrf
            // 
            this.txtIrrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtIrrf.Location = new System.Drawing.Point(146, 154);
            this.txtIrrf.Name = "txtIrrf";
            this.txtIrrf.Size = new System.Drawing.Size(163, 30);
            this.txtIrrf.TabIndex = 11;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSalLiquido.Location = new System.Drawing.Point(146, 200);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(163, 30);
            this.txtSalLiquido.TabIndex = 12;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSalFamilia.Location = new System.Drawing.Point(468, 62);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(151, 30);
            this.txtSalFamilia.TabIndex = 13;
            // 
            // txtDescInss
            // 
            this.txtDescInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtDescInss.Location = new System.Drawing.Point(468, 108);
            this.txtDescInss.Name = "txtDescInss";
            this.txtDescInss.Size = new System.Drawing.Size(151, 30);
            this.txtDescInss.TabIndex = 14;
            // 
            // txtDescIrrf
            // 
            this.txtDescIrrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtDescIrrf.Location = new System.Drawing.Point(468, 154);
            this.txtDescIrrf.Name = "txtDescIrrf";
            this.txtDescIrrf.Size = new System.Drawing.Size(151, 30);
            this.txtDescIrrf.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCalcular.Location = new System.Drawing.Point(31, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 45);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimpar.Location = new System.Drawing.Point(213, 277);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 45);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.Location = new System.Drawing.Point(520, 277);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 45);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 334);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDescIrrf);
            this.Controls.Add(this.txtDescInss);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtIrrf);
            this.Controls.Add(this.txtInss);
            this.Controls.Add(this.txtNFilhos);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblDescIrrf);
            this.Controls.Add(this.lblDescInss);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblIrrf);
            this.Controls.Add(this.lblInss);
            this.Controls.Add(this.lblNFilhos);
            this.Controls.Add(this.lblSalario);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Calculo mDo Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblNFilhos;
        private System.Windows.Forms.Label lblInss;
        private System.Windows.Forms.Label lblIrrf;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblDescInss;
        private System.Windows.Forms.Label lblDescIrrf;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNFilhos;
        private System.Windows.Forms.TextBox txtInss;
        private System.Windows.Forms.TextBox txtIrrf;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtDescInss;
        private System.Windows.Forms.TextBox txtDescIrrf;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

