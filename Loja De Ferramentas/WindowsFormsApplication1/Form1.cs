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
    public partial class frmLoja_de_ferra : Form
    {
        public frmLoja_de_ferra()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome_peca, nome_vende;
            double  val_tot = 0,val_luc, val_peca_luc, val_com, val_des, val_tot_des = 0;


            lblSaida_nome_vend.Text = txtN_do_vend.Text;
            lblSaida_nome_peca.Text = txtN_da_peca.Text;
            lblSaida_val_uni.Text = txtVal_uni.Text;
            lblSaida_qtd_peca.Text = txtQtd_de_peca.Text;


            double val_uni = Convert.ToDouble(txtVal_uni.Text);
            double qtd = Convert.ToDouble(txtQtd_de_peca.Text);


            if (qtd < 5)
            {
                val_luc = (val_uni * 45) / 100;
                val_peca_luc = val_uni + val_luc;
                val_tot = val_peca_luc * qtd;

                lblPre_fin1.Text = val_tot.ToString();
            }
            else
            {
                if (qtd >= 5)
                {
                    val_luc = (val_uni * 30) / 100;
                    val_peca_luc = val_uni + val_luc;
                    val_tot = val_peca_luc * qtd;


                    lblPre_fin1.Text = val_tot.ToString();

                }
            }

            if (qtd > 10 || val_tot > 200)
            {
                val_des = (val_tot * 10) / 100;
                val_tot_des = val_tot - val_des;

                lblDesc1.Text = val_tot_des.ToString();

                val_com = (val_tot_des * 5) / 100;
                lblCom_do_vend1.Text = val_com.ToString();
            }
            else
            {
                lblDesc1.Text = val_tot.ToString();
                
                val_com = (val_tot * 5) / 100;
                lblCom_do_vend1.Text = val_com.ToString();
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSaida_nome_vend.Text = null;
            lblSaida_nome_peca.Text = null;
            lblSaida_val_uni.Text = null;
            lblSaida_qtd_peca.Text = null;
            txtN_do_vend.Text = null;
            txtN_da_peca.Text = null;
            txtVal_uni.Text = null;
            txtQtd_de_peca.Text = null;
            lblCom_do_vend1.Text = null;
            lblDesc1.Text = null;
            lblPre_fin1.Text = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
