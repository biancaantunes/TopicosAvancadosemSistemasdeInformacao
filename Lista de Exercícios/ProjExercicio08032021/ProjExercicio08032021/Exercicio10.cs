using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio10
    {
        static void Main(string[] args)
        {
            double salario, maior = 0, mediasalario, mediafilhos, filhos, somasalario = 0, somafilhos = 0, persalario, cont = 0;
            int i;

            for (i = 1; i <= 4; i++)
            {
                do
                {
                    Console.Write("Digite o seu salário: ");
                    salario = double.Parse(Console.ReadLine());
                    if (salario < 0)
                        Console.WriteLine("Informe um salário válido!");
                } while (salario < 0);

                do
                {
                    Console.Write("Digite o número de filhos: ");
                    filhos = int.Parse(Console.ReadLine());
                    if (filhos < 0)
                        Console.WriteLine("Informe um número de filhos válido!");
                } while (filhos < 0);

                Console.WriteLine("\n");

                somafilhos += filhos;

                somasalario += salario;

                if (i == 0)
                {
                    maior = salario;
                }
                else
                {
                    if (salario > maior)
                    {
                        maior = salario;
                    }
                }

                if (salario <= 150)
                {
                    cont += 1;
                }
            }

            mediafilhos = somafilhos / 4;

            mediasalario = somasalario / 4;

            persalario = (cont / 4) * 100;

            Console.WriteLine("A média de salário da população é: " + mediasalario);
            Console.WriteLine("A média de número de filhos é: " + mediafilhos);
            Console.WriteLine("O maior salário informado é: " + maior);
            Console.WriteLine("O percentual de pessoas com o salário menor do que R$ 150,00 é: " + persalario + "%");

            Console.ReadKey();
        }
    }
}
