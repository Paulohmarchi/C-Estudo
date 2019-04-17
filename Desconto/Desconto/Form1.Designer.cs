namespace Desconto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValcom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPor = new System.Windows.Forms.TextBox();
            this.rbtDesc = new System.Windows.Forms.RadioButton();
            this.rbtJur = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValTot = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Da Compra";
            // 
            // txtValcom
            // 
            this.txtValcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtValcom.Location = new System.Drawing.Point(151, 15);
            this.txtValcom.Name = "txtValcom";
            this.txtValcom.Size = new System.Drawing.Size(100, 23);
            this.txtValcom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porcentagem";
            // 
            // txtPor
            // 
            this.txtPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPor.Location = new System.Drawing.Point(151, 55);
            this.txtPor.Name = "txtPor";
            this.txtPor.Size = new System.Drawing.Size(100, 23);
            this.txtPor.TabIndex = 3;
            // 
            // rbtDesc
            // 
            this.rbtDesc.AutoSize = true;
            this.rbtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtDesc.Location = new System.Drawing.Point(15, 104);
            this.rbtDesc.Name = "rbtDesc";
            this.rbtDesc.Size = new System.Drawing.Size(86, 21);
            this.rbtDesc.TabIndex = 4;
            this.rbtDesc.TabStop = true;
            this.rbtDesc.Text = "Desconto";
            this.rbtDesc.UseVisualStyleBackColor = true;
            // 
            // rbtJur
            // 
            this.rbtJur.AutoSize = true;
            this.rbtJur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtJur.Location = new System.Drawing.Point(151, 104);
            this.rbtJur.Name = "rbtJur";
            this.rbtJur.Size = new System.Drawing.Size(61, 21);
            this.rbtJur.TabIndex = 5;
            this.rbtJur.TabStop = true;
            this.rbtJur.Text = "Juros";
            this.rbtJur.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor";
            // 
            // txtVal
            // 
            this.txtVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVal.Location = new System.Drawing.Point(151, 143);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(100, 23);
            this.txtVal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Total";
            // 
            // txtValTot
            // 
            this.txtValTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtValTot.Location = new System.Drawing.Point(151, 185);
            this.txtValTot.Name = "txtValTot";
            this.txtValTot.Size = new System.Drawing.Size(100, 23);
            this.txtValTot.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalc.Location = new System.Drawing.Point(11, 221);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(78, 32);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(95, 221);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 32);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Location = new System.Drawing.Point(177, 221);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 32);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(269, 265);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtValTot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtJur);
            this.Controls.Add(this.rbtDesc);
            this.Controls.Add(this.txtPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValcom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Desc / Juros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValcom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPor;
        private System.Windows.Forms.RadioButton rbtDesc;
        private System.Windows.Forms.RadioButton rbtJur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValTot;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

