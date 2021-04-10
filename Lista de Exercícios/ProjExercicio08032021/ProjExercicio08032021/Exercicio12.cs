using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio12
    {
        static void Main(string[] args)
        {
            int i;
            double n, soma = 0;

            for (i = 1; i <= 10; i++)
            {
                Console.Write("Digite o " + i + "º número: ");
                n = double.Parse(Console.ReadLine());

                soma += n;
            }

            Console.WriteLine("\nA soma total dos números informados é " + soma);

            Console.ReadKey();
        }
    }
}
