using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio6
    {
        static void Main(string[] args)
        {
            double salario, vendas, total;

            Console.Write("Informe o salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor das vendas: ");
            vendas = double.Parse(Console.ReadLine());

            if (vendas <= 1500)
                total = salario + vendas * 0.03;
            else
                total = salario + 1500 * 0.03 + (vendas - 1500) * 0.05;

            Console.Write("Salario total: " + total);

            Console.ReadKey();
        }
    }
}
