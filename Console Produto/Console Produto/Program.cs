using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prd = new Produto();
            Console.Write("Digite a Descrição do Produto: ");
            prd.Descricao = Console.ReadLine();
            Console.Write("Preço de Compra do Produto: ");
            prd.PrecoCompra = double.Parse(Console.ReadLine());
            Console.Write("Porcentagem de Lucro: ");
            prd.Lucro = double.Parse(Console.ReadLine());

            prd.PrecoVenda = prd.calcularPrecoVenda();
            prd.listarProdutos();
            Console.ReadKey();



        }
    }
}
