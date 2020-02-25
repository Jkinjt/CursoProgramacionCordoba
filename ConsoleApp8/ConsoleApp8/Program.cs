using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduce tu tamaño: ");
            int num1 = int.Parse(Console.ReadLine());
            for (int contador = num1; contador >= 0; contador--)
            {
                Console.WriteLine("la bomba va a explotar en " + contador);
                
            }
            Console.ReadLine();
        }
    }
}
