using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class FrmLanchonete : Form
    {
        double total;
        public FrmLanchonete()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtQtd.Clear();
            txtTotal.Clear();
            ltbItens.Items.Clear();
            txtCodigo.Focus();

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            int codigo, qtd;
            double subtotal = 0.00;
            codigo = Convert.ToInt16(txtCodigo.Text);
            qtd = Convert.ToInt16(txtQtd.Text);

            switch (codigo)
            {
                case 1:
                    subtotal = qtd * 2.00;
                    ltbItens.Items.Add("Salgados " + qtd + " X " + " R$ 2,00 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                case 2:
                    subtotal = qtd * 1.50;
                    ltbItens.Items.Add("Pastel " + qtd + " X " + " R$ 1,50 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                case 3:
                    subtotal = qtd * 4.00;
                    ltbItens.Items.Add("X-Burguer " + qtd + " X " + " R$ 4,00 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                case 4:
                    subtotal = qtd * 4.50;
                    ltbItens.Items.Add("X-Salada " + qtd + " X " + " R$ 4,50 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                case 5:
                    subtotal = qtd * 5.50;
                    ltbItens.Items.Add("X-Bacon " + qtd + " X " + " R$ 5,50 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                case 6:
                    subtotal = qtd * 5.50;
                    ltbItens.Items.Add("X-Frango " + qtd + " X " + " R$ 5,50 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                case 7:
                    subtotal = qtd * 6.50;
                    ltbItens.Items.Add("X-Tudo " + qtd + " X " + " R$ 6,50 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                case 8:
                    subtotal = qtd * 3.50;
                    ltbItens.Items.Add("Refrigerante " + qtd + " X " + " R$ 3,50 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                case 9:
                    subtotal = qtd * 4.50;
                    ltbItens.Items.Add("Suco " + qtd + " X " + " R$ 4,50 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                case 10:
                    subtotal = qtd * 2.50;
                    ltbItens.Items.Add("Cafe " + qtd + " X " + " R$ 2,50 " + " = " +
                        String.Format("{0:00.00}", subtotal));
                    break;

                default:
                    MessageBox.Show("Codigo Invalido");
                    break;


            }
            total += subtotal;
            txtTotal.Text = String.Format("{0:00.00}",total);
            
            
            }




       
    }
}
