using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_Produto
{
    class Produto
    {
        private string descricao;
        private double precoCompra;
        private double lucro;
        private double precoVenda;

        public Produto()
        {
            this.descricao = "";
            this.precoCompra = 0.0;
            this.lucro = 0.0;
            this.precoVenda = 0.0;

        }
        public Produto(string desc, double pc, double lucro, double pv)
        {
            this.descricao = desc;
            this.precoCompra = pc;
            this.lucro = lucro;
            this.precoVenda = pv;

        }

        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        public double PrecoCompra
        {
            get { return this.precoCompra; }
            set { this.precoCompra = value; }
        }
        public double Lucro
        {
            get { return this.lucro; }
            set { this.lucro = value; }
        }
        public double PrecoVenda
        {
            get { return this.precoVenda; }
            set { this.precoVenda = value; }
        }

        public double calcularPrecoVenda()
        {
            double pv;
            pv = this.precoCompra + (this.precoCompra * this.lucro / 100);
            return pv;
        }
        public void listarProdutos()
        {
            Console.WriteLine("Dados do Produto \n");
            Console.WriteLine("Descrição: " + this.descricao);
            Console.WriteLine("Preço de Compra: " + this.precoCompra);
            Console.WriteLine("% de Lucro: " + this.lucro);
            Console.WriteLine("Preço De Venda: " + this.precoVenda);
        }

    }

}
