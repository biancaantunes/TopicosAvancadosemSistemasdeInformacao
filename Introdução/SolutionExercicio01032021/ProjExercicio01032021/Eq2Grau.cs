using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class Eq2Grau
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());


            delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("\nO valor de delta é: " + delta);

            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);


            if (delta > 0)
            {
                Console.WriteLine("\nExistem 2 raizes diferentes \nX1: " + x1 + "\nX2: " + x2);
            }
            else if (delta == 0)
            {
                Console.WriteLine("\nExistem 2 raizes iguais: \nX1: " + x1 + "\nX2: " + x2);
            }
            else
            {
                Console.WriteLine("\nNão existem raizes reais!");
            }

            Console.ReadKey();
        }
    }
}
