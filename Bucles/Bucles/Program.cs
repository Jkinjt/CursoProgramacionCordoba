using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("intruduce un número: ");
            float num = float.Parse(Console.ReadLine());
            int contador = 0;

            //do
            //{
            //    Console.WriteLine(contador);
            //    contador += 1;
            //    Console.ReadLine();

            //} while (num > contador);

            //Console.ReadLine();

             while (contador < 11)
            {
                Console.WriteLine(contador);
                Console.WriteLine(num + "x" + contador + "=" + num * contador);
                contador += 1;
                Console.ReadLine();
            }

            //    for (int i = 0; i < 11; i++)
            //    {
            //        Console.WriteLine(num * i);
            //    }
            //    Console.ReadLine();
            }
        }
}
