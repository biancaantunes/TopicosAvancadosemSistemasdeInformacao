using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio8
    {
        static void Main(string[] args)
        {
            double a, b, c, soma;

            do
            {
                Console.Write("Digite o primeiro valor: ");
                a = double.Parse(Console.ReadLine());
                
                if (a <= 0)
                {
                    Console.WriteLine("Valor inválido, informe novamente!");
                }

            } while (a <= 0);

            do
            {
                Console.Write("Digite o segundo valor: ");
                b = double.Parse(Console.ReadLine());

                if (b <= 0)
                {
                    Console.WriteLine("Valor inválido, informe novamente!");
                }

            } while (b <= 0);

            do
            {
                Console.Write("Digite o terceiro valor: ");
                c = double.Parse(Console.ReadLine());

                if (c <= 0)
                {
                    Console.WriteLine("Valor inválido, informe novamente!");
                }

            } while (c <= 0);

            soma = a + b + c;
            
            if (a >= (b + c) || b >= (a + c) || c >= (a + b))
            {
                Console.WriteLine("\nNão é um triângulo!");
            }
            else
            {
                Console.WriteLine("\nÉ um triângulo!");
            }

            Console.ReadKey();
        }
    }
}
