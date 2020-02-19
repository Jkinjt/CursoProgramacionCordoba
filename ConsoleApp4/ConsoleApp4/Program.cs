using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduce un numero: ");
            int num1 = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.Write(num1 + " es un numero par");
                Console.ReadLine();
            }
            else //en else no hace falta poner la condición siempre se considera a alternativa
            {
                Console.Write(num1 + " es un numero impar");
                Console.ReadLine();
            }
        }
    }
}
