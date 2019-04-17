using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pares_Impares
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
            ltbImpares.Items.Clear();
            ltbPares.Items.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            /*for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    ltbPares.Items.Add(i);

                }
                else
                {
                    ltbImpares.Items.Add(i);
                }
            }
            // while
            int i = 1;


            while (i <= 20)
            {

                if (i % 2 == 0)
                {
                    ltbPares.Items.Add(i);
                }
                else
                {
                    ltbImpares.Items.Add(i);
                }
                i++;
            }*/
            // Do while

            int x = 1;
            do
            {
                if (x % 2 == 0)
                {
                    ltbPares.Items.Add(x);
                }
                else
                {
                    ltbImpares.Items.Add(x);
                }
                x++;
            } while (x <= 20);

        }
    }
}