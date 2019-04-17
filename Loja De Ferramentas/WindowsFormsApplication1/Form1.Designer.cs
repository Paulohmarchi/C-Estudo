namespace WindowsFormsApplication1
{
    partial class frmLoja_de_ferra
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
            this.grpDados_vend = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtQtd_de_peca = new System.Windows.Forms.TextBox();
            this.lblQtd_de_peca = new System.Windows.Forms.Label();
            this.txtVal_uni = new System.Windows.Forms.TextBox();
            this.lblVal_uni = new System.Windows.Forms.Label();
            this.txtN_da_peca = new System.Windows.Forms.TextBox();
            this.lblN_da_peca = new System.Windows.Forms.Label();
            this.txtN_do_vend = new System.Windows.Forms.TextBox();
            this.lblN_do_vend = new System.Windows.Forms.Label();
            this.grpDados_comp = new System.Windows.Forms.GroupBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.lblCom_do_vend1 = new System.Windows.Forms.Label();
            this.lblCom_do_vend = new System.Windows.Forms.Label();
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPre_fin1 = new System.Windows.Forms.Label();
            this.lblPre_fin = new System.Windows.Forms.Label();
            this.lblSaida_qtd_peca = new System.Windows.Forms.Label();
            this.lblSaida_val_uni = new System.Windows.Forms.Label();
            this.lblSaida_nome_peca = new System.Windows.Forms.Label();
            this.lblSaida_nome_vend = new System.Windows.Forms.Label();
            this.lblQtd_de_peca1 = new System.Windows.Forms.Label();
            this.lblVal_uni1 = new System.Windows.Forms.Label();
            this.lblN_da_peca1 = new System.Windows.Forms.Label();
            this.lblN_do_vend1 = new System.Windows.Forms.Label();
            this.grpDados_vend.SuspendLayout();
            this.grpDados_comp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados_vend
            // 
            this.grpDados_vend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpDados_vend.Controls.Add(this.btnSair);
            this.grpDados_vend.Controls.Add(this.btnLimpar);
            this.grpDados_vend.Controls.Add(this.btnCalcular);
            this.grpDados_vend.Controls.Add(this.txtQtd_de_peca);
            this.grpDados_vend.Controls.Add(this.lblQtd_de_peca);
            this.grpDados_vend.Controls.Add(this.txtVal_uni);
            this.grpDados_vend.Controls.Add(this.lblVal_uni);
            this.grpDados_vend.Controls.Add(this.txtN_da_peca);
            this.grpDados_vend.Controls.Add(this.lblN_da_peca);
            this.grpDados_vend.Controls.Add(this.txtN_do_vend);
            this.grpDados_vend.Controls.Add(this.lblN_do_vend);
            this.grpDados_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpDados_vend.Location = new System.Drawing.Point(13, 13);
            this.grpDados_vend.Margin = new System.Windows.Forms.Padding(4);
            this.grpDados_vend.Name = "grpDados_vend";
            this.grpDados_vend.Padding = new System.Windows.Forms.Padding(4);
            this.grpDados_vend.Size = new System.Drawing.Size(611, 292);
            this.grpDados_vend.TabIndex = 0;
            this.grpDados_vend.TabStop = false;
            this.grpDados_vend.Text = "Dados Da Venda";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.Location = new System.Drawing.Point(524, 238);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 47);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimpar.Location = new System.Drawing.Point(169, 238);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 47);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCalcular.Location = new System.Drawing.Point(12, 238);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 47);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtQtd_de_peca
            // 
            this.txtQtd_de_peca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtQtd_de_peca.Location = new System.Drawing.Point(499, 161);
            this.txtQtd_de_peca.Name = "txtQtd_de_peca";
            this.txtQtd_de_peca.Size = new System.Drawing.Size(105, 30);
            this.txtQtd_de_peca.TabIndex = 7;
            // 
            // lblQtd_de_peca
            // 
            this.lblQtd_de_peca.AutoSize = true;
            this.lblQtd_de_peca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQtd_de_peca.Location = new System.Drawing.Point(283, 164);
            this.lblQtd_de_peca.Name = "lblQtd_de_peca";
            this.lblQtd_de_peca.Size = new System.Drawing.Size(210, 25);
            this.lblQtd_de_peca.TabIndex = 6;
            this.lblQtd_de_peca.Text = "Quantidade De Peças:";
            // 
            // txtVal_uni
            // 
            this.txtVal_uni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtVal_uni.Location = new System.Drawing.Point(148, 161);
            this.txtVal_uni.Name = "txtVal_uni";
            this.txtVal_uni.Size = new System.Drawing.Size(118, 30);
            this.txtVal_uni.TabIndex = 5;
            // 
            // lblVal_uni
            // 
            this.lblVal_uni.AutoSize = true;
            this.lblVal_uni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVal_uni.Location = new System.Drawing.Point(7, 164);
            this.lblVal_uni.Name = "lblVal_uni";
            this.lblVal_uni.Size = new System.Drawing.Size(135, 25);
            this.lblVal_uni.TabIndex = 4;
            this.lblVal_uni.Text = "Valor Unitario:";
            // 
            // txtN_da_peca
            // 
            this.txtN_da_peca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtN_da_peca.Location = new System.Drawing.Point(198, 90);
            this.txtN_da_peca.Name = "txtN_da_peca";
            this.txtN_da_peca.Size = new System.Drawing.Size(406, 30);
            this.txtN_da_peca.TabIndex = 3;
            // 
            // lblN_da_peca
            // 
            this.lblN_da_peca.AutoSize = true;
            this.lblN_da_peca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblN_da_peca.Location = new System.Drawing.Point(7, 93);
            this.lblN_da_peca.Name = "lblN_da_peca";
            this.lblN_da_peca.Size = new System.Drawing.Size(150, 25);
            this.lblN_da_peca.TabIndex = 2;
            this.lblN_da_peca.Text = "Nome Da Peça:";
            // 
            // txtN_do_vend
            // 
            this.txtN_do_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtN_do_vend.Location = new System.Drawing.Point(198, 31);
            this.txtN_do_vend.Name = "txtN_do_vend";
            this.txtN_do_vend.Size = new System.Drawing.Size(406, 30);
            this.txtN_do_vend.TabIndex = 1;
            // 
            // lblN_do_vend
            // 
            this.lblN_do_vend.AutoSize = true;
            this.lblN_do_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblN_do_vend.Location = new System.Drawing.Point(7, 34);
            this.lblN_do_vend.Name = "lblN_do_vend";
            this.lblN_do_vend.Size = new System.Drawing.Size(191, 25);
            this.lblN_do_vend.TabIndex = 0;
            this.lblN_do_vend.Text = "Nome Do Vendedor:";
            // 
            // grpDados_comp
            // 
            this.grpDados_comp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpDados_comp.Controls.Add(this.lblLinha);
            this.grpDados_comp.Controls.Add(this.lblCom_do_vend1);
            this.grpDados_comp.Controls.Add(this.lblCom_do_vend);
            this.grpDados_comp.Controls.Add(this.lblDesc1);
            this.grpDados_comp.Controls.Add(this.lblDesc);
            this.grpDados_comp.Controls.Add(this.lblPre_fin1);
            this.grpDados_comp.Controls.Add(this.lblPre_fin);
            this.grpDados_comp.Controls.Add(this.lblSaida_qtd_peca);
            this.grpDados_comp.Controls.Add(this.lblSaida_val_uni);
            this.grpDados_comp.Controls.Add(this.lblSaida_nome_peca);
            this.grpDados_comp.Controls.Add(this.lblSaida_nome_vend);
            this.grpDados_comp.Controls.Add(this.lblQtd_de_peca1);
            this.grpDados_comp.Controls.Add(this.lblVal_uni1);
            this.grpDados_comp.Controls.Add(this.lblN_da_peca1);
            this.grpDados_comp.Controls.Add(this.lblN_do_vend1);
            this.grpDados_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpDados_comp.Location = new System.Drawing.Point(13, 312);
            this.grpDados_comp.Name = "grpDados_comp";
            this.grpDados_comp.Size = new System.Drawing.Size(612, 321);
            this.grpDados_comp.TabIndex = 1;
            this.grpDados_comp.TabStop = false;
            this.grpDados_comp.Text = "Dados Da Compra";
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(24, 149);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(558, 20);
            this.lblLinha.TabIndex = 15;
            this.lblLinha.Text = "_____________________________________________________________";
            // 
            // lblCom_do_vend1
            // 
            this.lblCom_do_vend1.AutoSize = true;
            this.lblCom_do_vend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCom_do_vend1.Location = new System.Drawing.Point(236, 280);
            this.lblCom_do_vend1.Name = "lblCom_do_vend1";
            this.lblCom_do_vend1.Size = new System.Drawing.Size(0, 25);
            this.lblCom_do_vend1.TabIndex = 14;
            // 
            // lblCom_do_vend
            // 
            this.lblCom_do_vend.AutoSize = true;
            this.lblCom_do_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCom_do_vend.Location = new System.Drawing.Point(3, 280);
            this.lblCom_do_vend.Name = "lblCom_do_vend";
            this.lblCom_do_vend.Size = new System.Drawing.Size(227, 25);
            this.lblCom_do_vend.TabIndex = 13;
            this.lblCom_do_vend.Text = "Comissão Do Vendedor:";
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDesc1.Location = new System.Drawing.Point(125, 230);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(0, 25);
            this.lblDesc1.TabIndex = 12;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDesc.Location = new System.Drawing.Point(3, 230);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(101, 25);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Desconto:";
            // 
            // lblPre_fin1
            // 
            this.lblPre_fin1.AutoSize = true;
            this.lblPre_fin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPre_fin1.Location = new System.Drawing.Point(125, 184);
            this.lblPre_fin1.Name = "lblPre_fin1";
            this.lblPre_fin1.Size = new System.Drawing.Size(0, 25);
            this.lblPre_fin1.TabIndex = 10;
            // 
            // lblPre_fin
            // 
            this.lblPre_fin.AutoSize = true;
            this.lblPre_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPre_fin.Location = new System.Drawing.Point(3, 184);
            this.lblPre_fin.Name = "lblPre_fin";
            this.lblPre_fin.Size = new System.Drawing.Size(116, 25);
            this.lblPre_fin.TabIndex = 9;
            this.lblPre_fin.Text = "Preço Final:";
            // 
            // lblSaida_qtd_peca
            // 
            this.lblSaida_qtd_peca.AutoSize = true;
            this.lblSaida_qtd_peca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSaida_qtd_peca.Location = new System.Drawing.Point(494, 114);
            this.lblSaida_qtd_peca.Name = "lblSaida_qtd_peca";
            this.lblSaida_qtd_peca.Size = new System.Drawing.Size(0, 25);
            this.lblSaida_qtd_peca.TabIndex = 8;
            // 
            // lblSaida_val_uni
            // 
            this.lblSaida_val_uni.AutoSize = true;
            this.lblSaida_val_uni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSaida_val_uni.Location = new System.Drawing.Point(143, 114);
            this.lblSaida_val_uni.Name = "lblSaida_val_uni";
            this.lblSaida_val_uni.Size = new System.Drawing.Size(0, 25);
            this.lblSaida_val_uni.TabIndex = 7;
            // 
            // lblSaida_nome_peca
            // 
            this.lblSaida_nome_peca.AutoSize = true;
            this.lblSaida_nome_peca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSaida_nome_peca.Location = new System.Drawing.Point(191, 69);
            this.lblSaida_nome_peca.Name = "lblSaida_nome_peca";
            this.lblSaida_nome_peca.Size = new System.Drawing.Size(0, 25);
            this.lblSaida_nome_peca.TabIndex = 6;
            // 
            // lblSaida_nome_vend
            // 
            this.lblSaida_nome_vend.AutoSize = true;
            this.lblSaida_nome_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSaida_nome_vend.Location = new System.Drawing.Point(193, 29);
            this.lblSaida_nome_vend.Name = "lblSaida_nome_vend";
            this.lblSaida_nome_vend.Size = new System.Drawing.Size(0, 25);
            this.lblSaida_nome_vend.TabIndex = 5;
            // 
            // lblQtd_de_peca1
            // 
            this.lblQtd_de_peca1.AutoSize = true;
            this.lblQtd_de_peca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQtd_de_peca1.Location = new System.Drawing.Point(283, 114);
            this.lblQtd_de_peca1.Name = "lblQtd_de_peca1";
            this.lblQtd_de_peca1.Size = new System.Drawing.Size(210, 25);
            this.lblQtd_de_peca1.TabIndex = 3;
            this.lblQtd_de_peca1.Text = "Quantidade De Peças:";
            // 
            // lblVal_uni1
            // 
            this.lblVal_uni1.AutoSize = true;
            this.lblVal_uni1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVal_uni1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVal_uni1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVal_uni1.Location = new System.Drawing.Point(3, 114);
            this.lblVal_uni1.Name = "lblVal_uni1";
            this.lblVal_uni1.Size = new System.Drawing.Size(135, 25);
            this.lblVal_uni1.TabIndex = 2;
            this.lblVal_uni1.Text = "Valor Unitario:";
            // 
            // lblN_da_peca1
            // 
            this.lblN_da_peca1.AutoSize = true;
            this.lblN_da_peca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblN_da_peca1.Location = new System.Drawing.Point(3, 69);
            this.lblN_da_peca1.Name = "lblN_da_peca1";
            this.lblN_da_peca1.Size = new System.Drawing.Size(150, 25);
            this.lblN_da_peca1.TabIndex = 1;
            this.lblN_da_peca1.Text = "Nome Da Peça:";
            // 
            // lblN_do_vend1
            // 
            this.lblN_do_vend1.AutoSize = true;
            this.lblN_do_vend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblN_do_vend1.Location = new System.Drawing.Point(3, 29);
            this.lblN_do_vend1.Name = "lblN_do_vend1";
            this.lblN_do_vend1.Size = new System.Drawing.Size(191, 25);
            this.lblN_do_vend1.TabIndex = 0;
            this.lblN_do_vend1.Text = "Nome Do Vendedor:";
            // 
            // frmLoja_de_ferra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 643);
            this.Controls.Add(this.grpDados_comp);
            this.Controls.Add(this.grpDados_vend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoja_de_ferra";
            this.Text = "Loja De Ferramentas";
            this.grpDados_vend.ResumeLayout(false);
            this.grpDados_vend.PerformLayout();
            this.grpDados_comp.ResumeLayout(false);
            this.grpDados_comp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados_vend;
        private System.Windows.Forms.Label lblN_do_vend;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtQtd_de_peca;
        private System.Windows.Forms.Label lblQtd_de_peca;
        private System.Windows.Forms.TextBox txtVal_uni;
        private System.Windows.Forms.Label lblVal_uni;
        private System.Windows.Forms.TextBox txtN_da_peca;
        private System.Windows.Forms.Label lblN_da_peca;
        private System.Windows.Forms.TextBox txtN_do_vend;
        private System.Windows.Forms.GroupBox grpDados_comp;
        private System.Windows.Forms.Label lblVal_uni1;
        private System.Windows.Forms.Label lblN_da_peca1;
        private System.Windows.Forms.Label lblN_do_vend1;
        private System.Windows.Forms.Label lblQtd_de_peca1;
        private System.Windows.Forms.Label lblSaida_nome_vend;
        private System.Windows.Forms.Label lblSaida_qtd_peca;
        private System.Windows.Forms.Label lblSaida_val_uni;
        private System.Windows.Forms.Label lblSaida_nome_peca;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Label lblCom_do_vend1;
        private System.Windows.Forms.Label lblCom_do_vend;
        private System.Windows.Forms.Label lblDesc1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPre_fin1;
        private System.Windows.Forms.Label lblPre_fin;
    }
}

