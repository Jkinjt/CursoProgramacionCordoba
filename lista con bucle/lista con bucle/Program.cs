using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_con_bucle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();// se crea la lista
            //se añaden los numeros a la lista
            numeros.Add(3);
            numeros.Add(1);
            numeros.Add(2);

            //creamos  
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("es par");

                }
                else
                {
                    Console.WriteLine("es impar");
                }

            }

        }
    }
}
