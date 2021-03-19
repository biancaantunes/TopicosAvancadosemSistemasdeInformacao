using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTriangulo
{
    class VeriTriangulo
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o lado A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.Write("\nFormam um triângulo!");

                if ((a == b) && (b == c))
                {
                    Console.Write("\n\nTriângulo Equilátero");
                }
                else if ((a == b) || (b == c) || (a == c))
                {
                    Console.Write("\n\nTriângulo Isósceles");
                }
                else
                {
                    Console.Write("\n\nTriângulo Escaleno");
                }
            }
            else
            {
                Console.Write("\nOs valores não formam um triângulo!");
            }
            System.Console.ReadKey();
        }
    }
}
