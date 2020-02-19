using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {// numeros para sumar
            Console.Write("vamos a aprender a sumar, meteme un número: ");
            int numeroA = int.Parse(Console.ReadLine());
            Console.Write("meteme el numero a sumar: ");
            int numeroB = int.Parse(Console.ReadLine());
            //respuesta a la suma
            Console.Write("tu nivel de satisfacción es " + (numeroA + numeroB));
            //resta
            Console.Write("ahora toca restar, meteme un numero: ");
            int numeroC = int.Parse(Console.ReadLine());
            Console.Write("meteme el otro número: ");
            int numeroD = int.Parse(Console.ReadLine());
            //Resultado de la resta
            Console.Write("te quedan: " + (numeroC - numeroD));





            Console.ReadLine();
        }
    }
}
