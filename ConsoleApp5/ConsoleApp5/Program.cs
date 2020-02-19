using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduce un numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("introduce otro numero: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine(num1 + " es multiplo de " + num2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(num1 + " no es multiplo del " + num2);
                Console.ReadLine();
            }
        }
    }
}
