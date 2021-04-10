using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio9
    {
        static void Main(string[] args)
        {
            double preco, codigo, soma = 0, maior = 0, media;
            int i;

            for (i = 0; i < 15; i++)
            {
                Console.Write("Digite o código do produto: ");
                codigo = double.Parse(Console.ReadLine());

                Console.Write("Digite o preço do produto: ");
                preco = double.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                soma += preco;

                if (i == 0)
                {
                    maior = preco;
                }
                else
                {
                    if (preco > maior)
                    {
                        maior = preco;
                    }
                }
            }

            media = soma / i;

            Console.WriteLine("\nO Maior preço informado foi: " + maior);
            Console.WriteLine("\nA média aritmética dos preços informados é " + media);

            Console.ReadKey();
        }
    }
}
