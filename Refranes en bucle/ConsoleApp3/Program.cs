using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            do
            {

                Console.WriteLine("introduce un número: ");
                numero = int.Parse(Console.ReadLine());
                switch (numero)
            {
                case 1:

                    Console.WriteLine("donde tengas la olla no metas la polla");
                    break;

                case 2:
                    Console.WriteLine("pa pa ");
                    break;
                case 3:
                    Console.WriteLine("me cago en tus muertos");
                    break;
                case 4:
                    Console.WriteLine("salir");
                    break;
                default:

                    break;
            }
            } while (numero != 4);
            Console.ReadLine();
        }
    }
}
