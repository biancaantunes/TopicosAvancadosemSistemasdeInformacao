using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifIMC
{
    class VerifIMC
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu peso em KG: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "\nABAIXO DO PESO!");
            }
            else if ((valorIMC >= 20) && (valorIMC <= 24))
            {
                Console.WriteLine("\nIMC = " + valorIMC + "\nPESO NORMAL!");
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine("\nIMC = " + valorIMC + "\nACIMA DO PESO!");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine("\nIMC = " + valorIMC + "\nOBESO!");
            }
            else
            {
                Console.WriteLine("\nIMC = " + valorIMC + "\nMUITO OBESO!");
            }

            Console.ReadKey();
        }
    }
}
