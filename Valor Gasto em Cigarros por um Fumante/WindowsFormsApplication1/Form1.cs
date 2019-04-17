using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmQuantogastodecigarros : Form
    {
        public FrmQuantogastodecigarros()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFuma.Clear();
            txtQual.Clear();
            txtQuantos.Clear();
            lblTotal.Text = null;
            
            txtFuma.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double quantos = Convert.ToDouble(txtQuantos.Text);
            double fuma = Convert.ToDouble(txtFuma.Text);
            double qual = Convert.ToDouble(txtQual.Text);

            double val_tot, qtd_ano, qtd_vida, tot_maco;

            qtd_ano = quantos * 365;
            qtd_vida = qtd_ano * fuma;
            tot_maco = qtd_vida / 20;
            val_tot = tot_maco * qual;

            lblTotal.Text = val_tot.ToString();
            
        }

       

      

       
    }
}
