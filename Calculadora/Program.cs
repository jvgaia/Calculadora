using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão \n");

            int operecao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operecao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }

                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }

                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }

                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Numero invalido, digite outro numero");
                    break;
            }

            Console.WriteLine("O resultado da opercao com os numeros {0} e {1} é: {2}", num1, num2, resultado);
            Console.ReadLine(); 

        }



        public static int Adicao(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;

        }

        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;

        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;

        }

        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;

        }
    }
}
