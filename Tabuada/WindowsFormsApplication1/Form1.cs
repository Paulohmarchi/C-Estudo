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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtNumero.Focus();
            ltbTabuada.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero, mult, result;
            mult = 1;
            numero = Convert.ToInt16(txtNumero.Text);
            ltbTabuada.Items.Clear();

            while (mult <= 10)
            {
                ;
                result = mult * numero;
                ltbTabuada.Items.Add(numero + " X " + mult + " = " + result);
                mult++;
            }
            txtNumero.Focus();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int numero, i, result;
            
            numero = Convert.ToInt16(txtNumero.Text);
            ltbTabuada.Items.Clear();

            for(i = 1,i <= 10,i++){
            
            
            }

        }
        
    }
}
