using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduce un numero del 1 al 3: ");
            int num1 = int.Parse(Console.ReadLine());

            switch (num1)
            {
                case 1:
                    Console.Write("No por mucho madrugar amanece mas temprano");
                    Console.ReadLine();
                    break;

                               case 2:
                    Console.Write("Pápa porque los niños me echan queso. No lo se Nacho ");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Write("tenias que poner un 3 cabrón");
                    Console.ReadLine();
                    break;

                default:
                    Console.Write("te he dicho del 1 al 3");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
