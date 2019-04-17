using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerde verde = new FrmVerde();
            verde.Show();

        }

        private void vermelhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVermelho vermelho = new FrmVermelho();
            vermelho.Show();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAzul azul = new FrmAzul();
            azul.Show();
        }

        private void gTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGTA gta = new FrmGTA();
            gta.Show();
        }

        private void pHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPHD phd = new FrmPHD();
            phd.Show();
        }

        private void monalisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMona mona = new FrmMona();
            mona.Show();
        }

        private void sodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSoda soda = new FrmSoda();
            soda.Show();
        }
    }
}
