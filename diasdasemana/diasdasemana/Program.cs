using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace diasdasemana
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_mes;
            double dia;


            Console.WriteLine("Programa para mostrar dia do mes!");
            Console.Write("Digite o Numero do Mes: ");
            dia = Convert.ToDouble(Console.ReadLine());

            switch ("dia")
            {
                case 1:
                case 8:
                case 15:
                case 22:
                case 29:

                    Console.Write( "Domingo");
                    break;

                case 2:
                case 9:
                case 16:
                case 23:
                case 30:

                    Console.Write( "Segunda");
                    break;

                case 3:
                case 10:
                case 17:
                case 24:
                case 31:

                    Console.Write( "Terça");
                    break;

                case 4:
                case 11:
                case 18:
                case 25:

                    Console.Write( "Quarta");
                    break;

                case 5:
                case 12:
                case 19:
                case 26:

                    Console.Write( "Quinta");
                    break;

                case 6:
                case 20:
                case 13:
                case 27:

                    Console.Write( "Sexta");
                    break;

                case 7:
                case 14:
                case 21:
                case 28:

                    Console.Write( "Sabado");
                    break;
                default:
                    Console.Write( "Esse Dia é Invalido");
                    break;
            }
            Console.WriteLine("Obrigado Pela Atenção!");





            Console.ReadLine();
        }
    }
}
