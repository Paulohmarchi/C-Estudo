using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotaAluno
{
    public partial class FrnAluno : Form
    {


        private void FrnAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMedia.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtNome.Clear();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Aluno alu = new Aluno();
            alu.CalcularMedia;

        }
    }
}
