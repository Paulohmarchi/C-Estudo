namespace Menu
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vermelhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monalisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coresToolStripMenuItem,
            this.imagensToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(392, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coresToolStripMenuItem
            // 
            this.coresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verdeToolStripMenuItem,
            this.vermelhoToolStripMenuItem,
            this.azulToolStripMenuItem});
            this.coresToolStripMenuItem.Name = "coresToolStripMenuItem";
            this.coresToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.coresToolStripMenuItem.Text = "Cores";
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // vermelhoToolStripMenuItem
            // 
            this.vermelhoToolStripMenuItem.Name = "vermelhoToolStripMenuItem";
            this.vermelhoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vermelhoToolStripMenuItem.Text = "Vermelho";
            this.vermelhoToolStripMenuItem.Click += new System.EventHandler(this.vermelhoToolStripMenuItem_Click);
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // imagensToolStripMenuItem
            // 
            this.imagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gTAToolStripMenuItem,
            this.pHDToolStripMenuItem,
            this.monalisaToolStripMenuItem,
            this.sodaToolStripMenuItem});
            this.imagensToolStripMenuItem.Name = "imagensToolStripMenuItem";
            this.imagensToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.imagensToolStripMenuItem.Text = "Imagens";
            // 
            // gTAToolStripMenuItem
            // 
            this.gTAToolStripMenuItem.Name = "gTAToolStripMenuItem";
            this.gTAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gTAToolStripMenuItem.Text = "GTA";
            this.gTAToolStripMenuItem.Click += new System.EventHandler(this.gTAToolStripMenuItem_Click);
            // 
            // pHDToolStripMenuItem
            // 
            this.pHDToolStripMenuItem.Name = "pHDToolStripMenuItem";
            this.pHDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pHDToolStripMenuItem.Text = "PHD";
            this.pHDToolStripMenuItem.Click += new System.EventHandler(this.pHDToolStripMenuItem_Click);
            // 
            // monalisaToolStripMenuItem
            // 
            this.monalisaToolStripMenuItem.Name = "monalisaToolStripMenuItem";
            this.monalisaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.monalisaToolStripMenuItem.Text = "Monalisa";
            this.monalisaToolStripMenuItem.Click += new System.EventHandler(this.monalisaToolStripMenuItem_Click);
            // 
            // sodaToolStripMenuItem
            // 
            this.sodaToolStripMenuItem.Name = "sodaToolStripMenuItem";
            this.sodaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sodaToolStripMenuItem.Text = "Soda";
            this.sodaToolStripMenuItem.Click += new System.EventHandler(this.sodaToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 468);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vermelhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monalisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sodaToolStripMenuItem;
    }
}