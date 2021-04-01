using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio08032021
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            double salario, comissao, vendas, totalvendas, salariofinal;

            Console.Write("Digite o salário fixo: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite a comissão de cada carro: ");
            comissao = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o número de carros vendidos: ");
            vendas = double.Parse(Console.ReadLine());

            Console.Write("Valor total de vendas: " );
            totalvendas = double.Parse(Console.ReadLine());
            
            salariofinal = salario + (comissao * vendas) + (totalvendas * 0.05);

            Console.WriteLine("O salário final: " + salariofinal);

            Console.ReadKey();
        }
    }
}

/*Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por
mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das
vendas por ele efetuadas. Escrever um algoritmo que leia o número de carros por ele
vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro
vendido. Calcule e escreva o salário final do vendedor.*/