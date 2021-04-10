using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio13
    {
        static void Main(string[] args)
        {
            int i, n;

            do
            {
                Console.Write("Digite a quantidades de valores que serão informados: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Número inválido, informe um número maior que zero!");
                }
            } while (n <= 0);

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
