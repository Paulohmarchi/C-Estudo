namespace Calculo_dos_Eleitores
{
    partial class frmCalculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEleitores = new System.Windows.Forms.TextBox();
            this.txtValidos = new System.Windows.Forms.TextBox();
            this.txtBrancos = new System.Windows.Forms.TextBox();
            this.txtNulos = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPorValidos = new System.Windows.Forms.Label();
            this.lblPorBrancos = new System.Windows.Forms.Label();
            this.lblPorNulos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total De Eleitores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Votos Validos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Votos em Branco:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Votos Nulos:";
            // 
            // txtEleitores
            // 
            this.txtEleitores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEleitores.Location = new System.Drawing.Point(207, 6);
            this.txtEleitores.Name = "txtEleitores";
            this.txtEleitores.Size = new System.Drawing.Size(100, 30);
            this.txtEleitores.TabIndex = 4;
            // 
            // txtValidos
            // 
            this.txtValidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtValidos.Location = new System.Drawing.Point(207, 49);
            this.txtValidos.Name = "txtValidos";
            this.txtValidos.Size = new System.Drawing.Size(100, 30);
            this.txtValidos.TabIndex = 5;
            // 
            // txtBrancos
            // 
            this.txtBrancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBrancos.Location = new System.Drawing.Point(207, 89);
            this.txtBrancos.Name = "txtBrancos";
            this.txtBrancos.Size = new System.Drawing.Size(100, 30);
            this.txtBrancos.TabIndex = 6;
            // 
            // txtNulos
            // 
            this.txtNulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNulos.Location = new System.Drawing.Point(207, 130);
            this.txtNulos.Name = "txtNulos";
            this.txtNulos.Size = new System.Drawing.Size(100, 30);
            this.txtNulos.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCalcular.Location = new System.Drawing.Point(320, 49);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 31);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimpar.Location = new System.Drawing.Point(320, 88);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 33);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.Location = new System.Drawing.Point(320, 128);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 34);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(106, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Porcentagem dos Votos Validos.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(106, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Porcentagem de Votos em Branco.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(106, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Porcentagem dos Votos Nulos.";
            // 
            // lblPorValidos
            // 
            this.lblPorValidos.AutoSize = true;
            this.lblPorValidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPorValidos.Location = new System.Drawing.Point(17, 196);
            this.lblPorValidos.Name = "lblPorValidos";
            this.lblPorValidos.Size = new System.Drawing.Size(0, 25);
            this.lblPorValidos.TabIndex = 14;
            // 
            // lblPorBrancos
            // 
            this.lblPorBrancos.AutoSize = true;
            this.lblPorBrancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPorBrancos.Location = new System.Drawing.Point(22, 251);
            this.lblPorBrancos.Name = "lblPorBrancos";
            this.lblPorBrancos.Size = new System.Drawing.Size(0, 25);
            this.lblPorBrancos.TabIndex = 15;
            // 
            // lblPorNulos
            // 
            this.lblPorNulos.AutoSize = true;
            this.lblPorNulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPorNulos.Location = new System.Drawing.Point(27, 308);
            this.lblPorNulos.Name = "lblPorNulos";
            this.lblPorNulos.Size = new System.Drawing.Size(0, 25);
            this.lblPorNulos.TabIndex = 16;
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 351);
            this.Controls.Add(this.lblPorNulos);
            this.Controls.Add(this.lblPorBrancos);
            this.Controls.Add(this.lblPorValidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNulos);
            this.Controls.Add(this.txtBrancos);
            this.Controls.Add(this.txtValidos);
            this.Controls.Add(this.txtEleitores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculo";
            this.Text = "Calculo De Eleitores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEleitores;
        private System.Windows.Forms.TextBox txtValidos;
        private System.Windows.Forms.TextBox txtBrancos;
        private System.Windows.Forms.TextBox txtNulos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPorValidos;
        private System.Windows.Forms.Label lblPorBrancos;
        private System.Windows.Forms.Label lblPorNulos;
    }
}

