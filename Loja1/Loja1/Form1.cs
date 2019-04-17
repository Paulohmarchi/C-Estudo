using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int qtd1, qtd2, qtd3, qtd4;
            double valor1, valor2, valor3, valor4,
            percDesconto, desconto, total1, liquido;

            qtd1 = int.Parse(txtQ1.Text);
            qtd2 = int.Parse(txtQ2.Text);
            qtd3 = int.Parse(txtQ3.Text);
            qtd4 = int.Parse(txtQ4.Text);

            valor1 = double.Parse(txtPr1.Text);
            valor2 = double.Parse(txtPr2.Text);
            valor3 = double.Parse(txtPr3.Text);
            valor4 = double.Parse(txtPr4.Text);

            percDesconto = double.Parse(txtDesconto.Text);

            total1 = (qtd1 * valor1) + (qtd2 * valor2) + (qtd3 * valor3) + (qtd4 * valor4);
            desconto = (total1 * percDesconto) / 100;
            liquido = total1 - desconto;

            txtTotal.Text = String.Format("{0:c}", total1);
            txtVD.Text = String.Format("{0:c}", desconto);
            txtLiquido.Text = String.Format("{0:c}", liquido);


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
            txtP4.Clear();
            txtPr1.Clear();
            txtPr2.Clear();
            txtPr3.Clear();
            txtPr4.Clear();
            txtQ1.Clear();
            txtQ2.Clear();
            txtQ3.Clear();
            txtQ4.Clear();
            txtTotal.Clear();
            txtVD.Clear();
            txtDesconto.Clear();
            txtLiquido.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

    
    }
}
