using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {/// esta mal revisar

        static void Main(string[] args)
        {
            Console.Write("cuantos numeros quieres sumar: ");
            int sumatorio = 0;
            int cantidad = int.Parse(Console.ReadLine());
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("introduce tu número a sumar: ");
                int x = int.Parse(Console.ReadLine());
                cantidad[i] = x;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                sumatorio <= cantidad; 
            }
            

        }
    }
}
