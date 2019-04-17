using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desconto
{
    public partial class Form1 : Form
   
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPor.Clear();
            txtVal.Clear();
            txtValcom.Clear();
            txtValTot.Clear();
            rbtDesc = null;
            rbtJur = null;
            txtValcom.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
        }
    }
}
