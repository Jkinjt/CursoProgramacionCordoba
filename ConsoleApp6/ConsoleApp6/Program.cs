using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduce un numero: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 > 0)
            {
                Console.Write(num1 + " es un número positivo ");
                Console.ReadLine();
            }
            else if (num1 < 0)
            {
                Console.Write(num1 + " es un número negativo ");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Tu numero es como un cuchillo sin mango al que le han quitado el filo ");
                Console.ReadLine();
            }
        }
    }
}   
