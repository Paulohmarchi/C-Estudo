using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;// classe para reconhecer o msql

namespace Materia_Nova
{
    public partial class FrmEscola : Form
    {
        public MySqlConnection bdConn;
        private DataSet bdDataSet;
        public int botao; // para saber qual botao foi precionado 1 = novo 2 = alterar 3 = excluir

        public FrmEscola()
        {
            InitializeComponent();
        }
        public void conectar()
        {
            bdDataSet = new DataSet();// instanciar objeto datset 
            //criando a string de conexao com o bd (local do bd, usuario, senha, o banco de dados, e a porta
            bdConn = new MySqlConnection("server=localhost; user id=root; password=''; database=linkwatts; port=3306");

            try // tentar abrir a conexao
            {
                bdConn.Open();
            }
            catch //Se não conseguir abrir a conexao executar
            {
                MessageBox.Show("Não Foi Possivel Estabelecer Conexão");
            }
        }

        private void FrmEscola_Load(object sender, EventArgs e)
        {
            txtCod.Enabled = false;
            txtEmail.Enabled = false;
            txtNome.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnExe.Enabled = false;
            botao = 0;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.conectar();
            if (bdConn.State == ConnectionState.Open)
            {
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtCod.Text = "";
                txtEmail.Text = "";
                txtNome.Text = "";
                MySqlCommand com = new MySqlCommand("SELECT MAX(codAlu) +1 AS codAlu FROM Aluno", bdConn);

                MySqlDataReader dr = null; //usado quando tem q executar uma script do sql

                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    txtCod.Text = dr["codAlu"].ToString();

                }
                if (txtCod.Text == "")
                {
                    txtCod.Text = "1";
                }
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = false;
                btnExe.Enabled = true;
                botao = 1;
                txtNome.Focus();

            }
            bdConn.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtCod.Enabled = true;
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnExe.Enabled = true;
            botao = 2;
            txtCod.Focus();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtCod.Enabled = true;
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnExe.Enabled = true;
            botao = 3;
            txtCod.Focus();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            this.conectar();
            if (bdConn.State == ConnectionState.Open)
            {
                MySqlCommand com1 = new MySqlCommand();
                com1.Connection = bdConn;

                if (botao == 1)
                {
                    com1.CommandText = "INSERT INTO Aluno (codAlu, nomeAlu, emailAlu) VALUES(" + txtCod.Text + ",'" + txtNome.Text + "','" + txtEmail.Text + "')";
                    com1.ExecuteNonQuery();

                }

                else if (botao == 2)
                {
                    com1.CommandText = "UPDATE Aluno set nomeAlu = '" + txtNome.Text + "', emailAlu = '" + txtEmail.Text + "'" + "WHERE codAlu = " + txtCod.Text;

                    try
                    {
                        Convert.ToInt16(txtCod.Text);
                        com1.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Codigo Invalido!");
                    }
                }
                else if (botao == 3)
                {
                    com1.CommandText = "DELETE FROM Aluno WHERE codAlu " + txtCod.Text;
                    try
                    {
                        Convert.ToInt16(txtCod.Text);
                        if (MessageBox.Show("Confirmar a Exclusão do Registro?",
                            "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            com1.ExecuteNonQuery();

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Codigo Invalido!");
                    }
                }

            }

            txtCod.Enabled = false;
            txtEmail.Enabled = false;
            txtNome.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnExe.Enabled = false;
            botao = 0;
            btnNovo.Focus();
        }

        private void txtCod_Leave(object sender, EventArgs e)
        {
            this.conectar();

            if ((botao == 1) || (botao == 2))
            {
                MySqlCommand com2 = new MySqlCommand("SELECT * FROM Aluno " + " WHERE codAlu = " + txtCod.Text, bdConn);
                MySqlDataReader dr1 = null;

                try
                {
                    dr1 = com2.ExecuteReader();
                    while (dr1.Read())
                    {
                        txtNome.Text = dr1["nomeAlu"].ToString();
                        txtEmail.Text = dr1["emailAlu"].ToString();

                    }
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Codigo Invalido");
                        txtCod.Focus();

                    }
                }
                catch
                {
                    MessageBox.Show("Codigo Invalido");
                    txtCod.Focus();

                }


                bdConn.Close();

            }
        }
  }

}