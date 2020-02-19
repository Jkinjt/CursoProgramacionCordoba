using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduce tu tamaño: ");
            float num1 = float.Parse(Console.ReadLine());

            if (num1 <= 5)
            {
                Console.Write("tu lo que tienes es un clitoris");
                Console.ReadLine();
            }
            else
            {
                if (num1 >= 5 && num1 <=200)
                {
                    Console.Write("Pito chico");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("Valla pollón");
                    Console.ReadLine();
                }

            }
            
        }
    }
}
