using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculo_dos_Eleitores
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBrancos.Clear();
            txtEleitores.Clear();
            txtNulos.Clear();
            txtValidos.Clear();
            lblPorBrancos.Text = null;
            lblPorNulos.Text = null;
            lblPorValidos.Text = null;
            txtEleitores.Focus();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
           double tot,soma;
           double eleitores = Convert.ToDouble(txtEleitores.Text);
           double brancos = Convert.ToDouble(txtBrancos.Text);
           double nulos = Convert.ToDouble(txtNulos.Text);
           double validos = Convert.ToDouble(txtValidos.Text);
           double porvalidos;
           double pornulos ;
           double porbrancos;

            porvalidos = (validos / eleitores) * 100 ;
            lblPorValidos.Text = porvalidos.ToString() + "%";
            pornulos = (nulos / eleitores) * 100;
            lblPorNulos.Text = pornulos.ToString() + "%";
            porbrancos = (brancos / eleitores) * 100;
            lblPorBrancos.Text = porbrancos.ToString() + "%";

            soma = validos + nulos + brancos;
            if (validos + nulos + brancos > eleitores)
            {
                tot = soma - eleitores;
                MessageBox.Show("Houve " + tot + " Fraudes Nessa Eleição");
            }
            else
            {
            }
            
            
           
        }
    }
}
