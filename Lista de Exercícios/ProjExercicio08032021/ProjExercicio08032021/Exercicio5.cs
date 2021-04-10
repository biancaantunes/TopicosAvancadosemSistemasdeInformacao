using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            double altura, pesoideal;
            string nome, sexo;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            
            Console.Write("Digite a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite o seu sexo (F/M): ");
                sexo = Console.ReadLine();
                if (sexo != "m" && sexo != "M" && sexo != "f" && sexo != "F")
                {
                    Console.WriteLine("Informação inválida, informe novamente!");
                }
            } while (sexo != "m" && sexo != "M" && sexo != "f" && sexo != "F");

            if (sexo == "m" || sexo == "M")
            {
                pesoideal = (72.7 * altura) - 58;
            }
            else
            {
                pesoideal = (62.1 * altura) - 44.7;
            }

            Console.WriteLine(nome + ", seu peso ideal: " + pesoideal);

            Console.ReadKey();
        }
    }
}
