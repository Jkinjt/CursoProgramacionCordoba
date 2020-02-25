using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[] { 3, 1, 3 }; // se crea la lista 
            bool repetir = false; // variable creada para activarse cuando se encuentra un número repetido
            for (int i = 0; i < lista.Length && !repetir; i++)
            {
                for (int j = 0; j < i + 1 && !repetir; j++)
                {
                    if (lista[j] == lista[i])
                    {
                        Console.WriteLine("estos numeros son iguales");
                        repetir = true;
                    }
                }
            }
            if (!repetir)
            {
                Console.WriteLine("no hay duplicado");
            }
        }  

    }
}
