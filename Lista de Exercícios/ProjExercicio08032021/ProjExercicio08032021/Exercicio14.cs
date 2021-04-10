using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio14
    {
        static void Main(string[] args)
        {
            int i, cont = 0;
            double media, soma = 0;

            for (i = 15; i <= 100; i++)
            {
                soma += i;
                cont += 1;
            }

            media = soma / cont;

            Console.WriteLine("A média aritmética dos números entre 15 e 100 é " + media);

            Console.ReadKey();
        }
    }
}

/*14. Faça um algoritmo que calcule e escreva a média aritmética dos números inteiros entre 15
(inclusive) e 100 (inclusive).*/