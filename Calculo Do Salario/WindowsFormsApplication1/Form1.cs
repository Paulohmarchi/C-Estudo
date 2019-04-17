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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescInss.Clear();
            txtDescIrrf.Clear();
            txtInss.Clear();
            txtIrrf.Clear();
            txtNFilhos.Clear();
            txtSalario.Clear();
            txtSalFamilia.Clear();
            txtSalLiquido.Clear();
            txtSalario.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int filhos;
            double sal, salFam = 0, inss, irrf, salLiq;
            filhos = int.Parse(txtNFilhos.Text);
            sal = Convert.ToDouble(txtSalario.Text);

            if (sal <= 682.5)
            {
                salFam = 35 * filhos;
            }
            if (sal <= 1317)
            {
                txtInss.Text = "8%";
                inss = sal * 8 / 100;
            }
            else
            {
                txtInss.Text = "9%";
                inss = sal * 9 / 100;
            }
            if (sal > 1800)
            {
                txtIrrf.Text = "7,5%";
                irrf = (sal - inss) * 7.5 / 100;
            }
            else
            {
                txtIrrf.Text = "0";
                irrf = 0;
            }
            salLiq = sal + salFam - inss - irrf;
            
            
            txtSalFamilia.Text = Convert.ToString(salFam);
            txtDescInss.Text = inss.ToString();
            txtDescIrrf.Text = irrf.ToString();
            txtSalLiquido.Text = salLiq.ToString();



        }

    }
}
