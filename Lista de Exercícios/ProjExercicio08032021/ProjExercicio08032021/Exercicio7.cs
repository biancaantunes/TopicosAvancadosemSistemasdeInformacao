using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio7
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Digite o primeiro valor: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = double.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.WriteLine("\nO maior valor informado é " + a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("\nO maior valor informado é " + b);
            }
            else
            {
                Console.WriteLine("\nO maior valor informado é " + c);
            }

            Console.ReadKey();
        }
    }
}
