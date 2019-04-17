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
            int dia;


            Console.WriteLine("---------- Programa para mostrar dia do mes!  ------------");
            Console.Write("\n Digite o Numero do Mes:   ");
            dia = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("---------- Programa para mostrar dia do mes!  ------------");
            switch (dia)
            {
                case 1:
                case 8:
                case 15:
                case 22:
                case 29:
                    Console.Write( "\n Esse Dia é: Domingo. ");
                    break;
                case 2:
                case 9:
                case 16:
                case 23:
                case 30:
                    Console.Write("\n Esse Dia é: Segunda. ");
                    break;
                case 3:
                case 10:
                case 17:
                case 24:
                case 31:
                    Console.Write("\n Esse Dia é: Terça. ");
                    break;
                case 4:
                case 11:
                case 18:
                case 25:
                    Console.Write("\n Esse Dia é: Quarta. ");
                    break;
                case 5:
                case 12:
                case 19:
                case 26:
                    Console.Write("\n Esse Dia é: Quinta. ");
                    break;
                case 6:
                case 13:
                case 20:
                case 27:
                    Console.Write("\n Esse Dia é: Sexta. ");
                    break;
                case 7:
                case 14:
                case 21:
                case 28:
                    Console.Write("\n Esse Dia é: Sabado. ");
                    break;

                default:
                    Console.Write( "\n Esse Dia é: Invalido.");
                    break;
            }
            Console.WriteLine("\n\n Obrigado Pela Atenção!");






            Console.ReadLine();
        }
    }
}
