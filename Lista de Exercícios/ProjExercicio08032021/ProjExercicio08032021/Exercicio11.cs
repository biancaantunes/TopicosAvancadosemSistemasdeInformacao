using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio11
    {
        static void Main(string[] args)
        {
            double[] temperatura = new double[5];
            double maior = 0, menor = 0, media, soma = 0;
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite a temperatura: ");
                temperatura[i] = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maior = temperatura[i];
                    menor = temperatura[i];
                }
                else
                {
                    if (temperatura[i] > maior)
                    {
                        maior = temperatura[i];
                    }
                    if (temperatura[i] < menor)
                    {
                        menor = temperatura[i];
                    }
                }
                soma += temperatura[i];
            }

            media = soma / 5;

            Console.WriteLine("A menor temperatura informada foi: " + menor + "°C");
            Console.WriteLine("A maior temperatura informada foi: " + maior + "°C");
            Console.WriteLine("A temperatura média foi: " + media + "°C");
            
            Console.ReadKey();
        }
    }
}
