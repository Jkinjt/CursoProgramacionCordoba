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
        {//introducción de numeros en la consola
            Console.Write("escribe un número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("escribe otro número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("el primer numero es " + numero1 +  " el segundo número es "  +  numero2);
            Console.ReadLine();
            //comprueba que los numeros introducidos son iguales o cual es mayor
            if (numero1 == numero2)
            {
                Console.WriteLine(numero1 + " es igual a " + numero2);
                Console.ReadLine();
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("el " + numero1 + " es menor al " + numero2);
                Console.ReadLine();
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("el " + numero1 + " es mayor al " + numero2);
                Console.ReadLine();
            }
        }   
    }
}
