namespace Lanchonete
{
    partial class FrmLanchonete
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPastel = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.ltbItens = new System.Windows.Forms.ListBox();
            this.ltbCardapio = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Font = new System.Drawing.Font("Bradley Hand ITC", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(42, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(570, 44);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Lanchonete e Pastelaria ChingLing";
            // 
            // lblPastel
            // 
            this.lblPastel.AutoSize = true;
            this.lblPastel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPastel.Font = new System.Drawing.Font("Bradley Hand ITC", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastel.Location = new System.Drawing.Point(129, 62);
            this.lblPastel.Name = "lblPastel";
            this.lblPastel.Size = new System.Drawing.Size(393, 44);
            this.lblPastel.TabIndex = 1;
            this.lblPastel.Text = "Melhor Pastel da Região";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCodigo.Location = new System.Drawing.Point(22, 133);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 25);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQtd.Location = new System.Drawing.Point(22, 173);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(120, 25);
            this.lblQtd.TabIndex = 3;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCodigo.Location = new System.Drawing.Point(166, 130);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(64, 30);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtQtd.Location = new System.Drawing.Point(166, 170);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(64, 30);
            this.txtQtd.TabIndex = 5;
            // 
            // ltbItens
            // 
            this.ltbItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ltbItens.FormattingEnabled = true;
            this.ltbItens.ItemHeight = 20;
            this.ltbItens.Location = new System.Drawing.Point(12, 219);
            this.ltbItens.Name = "ltbItens";
            this.ltbItens.Size = new System.Drawing.Size(317, 424);
            this.ltbItens.TabIndex = 6;
            // 
            // ltbCardapio
            // 
            this.ltbCardapio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ltbCardapio.FormattingEnabled = true;
            this.ltbCardapio.ItemHeight = 20;
            this.ltbCardapio.Items.AddRange(new object[] {
            "1)Salgados Unidade - 2,00",
            "",
            "2)Pasteis Unidade - 1,50",
            "",
            "Lanches",
            "",
            "3)X-Burguer - 4,00",
            "4)X-Salada - 4,50",
            "5)X-Bacon - 5,50",
            "6)X-Frango - 5,50",
            "7)X-Tudo - 6,50",
            "",
            "Bebidas",
            "",
            "8)Refrigerante (Lata 450ml) - 3,50",
            "9)Sucos (Copo 400ml) - 4,00",
            "10)Cafe - 2,50"});
            this.ltbCardapio.Location = new System.Drawing.Point(340, 219);
            this.ltbCardapio.Name = "ltbCardapio";
            this.ltbCardapio.Size = new System.Drawing.Size(291, 424);
            this.ltbCardapio.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTotal.Location = new System.Drawing.Point(19, 685);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 46);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtTotal.Location = new System.Drawing.Point(150, 681);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(179, 53);
            this.txtTotal.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSair.Location = new System.Drawing.Point(503, 685);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 50);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLimpar.Location = new System.Drawing.Point(376, 685);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 50);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnConfirma.Location = new System.Drawing.Point(394, 130);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(179, 64);
            this.btnConfirma.TabIndex = 12;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // FrmLanchonete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lanchonete.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 775);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.ltbCardapio);
            this.Controls.Add(this.ltbItens);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPastel);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmLanchonete";
            this.Text = "Lanchonete & Pastelaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPastel;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.ListBox ltbItens;
        private System.Windows.Forms.ListBox ltbCardapio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirma;
    }
}

