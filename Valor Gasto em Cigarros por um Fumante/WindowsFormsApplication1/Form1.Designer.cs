namespace WindowsFormsApplication1
{
    partial class FrmQuantogastodecigarros
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblFuma = new System.Windows.Forms.Label();
            this.lblQuantos = new System.Windows.Forms.Label();
            this.lblQual = new System.Windows.Forms.Label();
            this.txtFuma = new System.Windows.Forms.TextBox();
            this.txtQuantos = new System.Windows.Forms.TextBox();
            this.txtQual = new System.Windows.Forms.TextBox();
            this.lblTotalgasto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalcular.Location = new System.Drawing.Point(17, 202);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 28);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(200, 202);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 28);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Location = new System.Drawing.Point(398, 202);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 28);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblFuma
            // 
            this.lblFuma.AutoSize = true;
            this.lblFuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFuma.Location = new System.Drawing.Point(12, 19);
            this.lblFuma.Name = "lblFuma";
            this.lblFuma.Size = new System.Drawing.Size(225, 25);
            this.lblFuma.TabIndex = 3;
            this.lblFuma.Text = "Fuma  a Quantos Anos?";
            // 
            // lblQuantos
            // 
            this.lblQuantos.AutoSize = true;
            this.lblQuantos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuantos.Location = new System.Drawing.Point(12, 64);
            this.lblQuantos.Name = "lblQuantos";
            this.lblQuantos.Size = new System.Drawing.Size(246, 25);
            this.lblQuantos.TabIndex = 4;
            this.lblQuantos.Text = "Quantos Cigarros Por Dia?";
            // 
            // lblQual
            // 
            this.lblQual.AutoSize = true;
            this.lblQual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQual.Location = new System.Drawing.Point(12, 113);
            this.lblQual.Name = "lblQual";
            this.lblQual.Size = new System.Drawing.Size(315, 25);
            this.lblQual.TabIndex = 5;
            this.lblQual.Text = "Qual é Valor Do Maço De Cigarro?";
            // 
            // txtFuma
            // 
            this.txtFuma.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtFuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFuma.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFuma.Location = new System.Drawing.Point(368, 16);
            this.txtFuma.Name = "txtFuma";
            this.txtFuma.Size = new System.Drawing.Size(128, 30);
            this.txtFuma.TabIndex = 6;
            // 
            // txtQuantos
            // 
            this.txtQuantos.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtQuantos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtQuantos.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuantos.Location = new System.Drawing.Point(368, 61);
            this.txtQuantos.Name = "txtQuantos";
            this.txtQuantos.Size = new System.Drawing.Size(128, 30);
            this.txtQuantos.TabIndex = 7;
            // 
            // txtQual
            // 
            this.txtQual.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtQual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtQual.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQual.Location = new System.Drawing.Point(368, 110);
            this.txtQual.Name = "txtQual";
            this.txtQual.Size = new System.Drawing.Size(128, 30);
            this.txtQual.TabIndex = 8;
            // 
            // lblTotalgasto
            // 
            this.lblTotalgasto.AutoSize = true;
            this.lblTotalgasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalgasto.Location = new System.Drawing.Point(12, 163);
            this.lblTotalgasto.Name = "lblTotalgasto";
            this.lblTotalgasto.Size = new System.Drawing.Size(336, 20);
            this.lblTotalgasto.TabIndex = 9;
            this.lblTotalgasto.Text = "Total Gasto Na Compra de Cigarros em Reais:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.Location = new System.Drawing.Point(363, 163);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 10;
            // 
            // FrmQuantogastodecigarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 234);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalgasto);
            this.Controls.Add(this.txtQual);
            this.Controls.Add(this.txtQuantos);
            this.Controls.Add(this.txtFuma);
            this.Controls.Add(this.lblQual);
            this.Controls.Add(this.lblQuantos);
            this.Controls.Add(this.lblFuma);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FrmQuantogastodecigarros";
            this.Text = "Valor Gasto em Maços de Cigarro em Sua Vida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblFuma;
        private System.Windows.Forms.Label lblQuantos;
        private System.Windows.Forms.Label lblQual;
        private System.Windows.Forms.TextBox txtFuma;
        private System.Windows.Forms.TextBox txtQuantos;
        private System.Windows.Forms.TextBox txtQual;
        private System.Windows.Forms.Label lblTotalgasto;
        private System.Windows.Forms.Label lblTotal;
    }
}

