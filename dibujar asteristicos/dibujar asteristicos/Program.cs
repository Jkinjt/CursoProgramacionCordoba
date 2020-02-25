using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dibujar_asteristicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());// se introduce la variable de veces que se va escribir la linea

            for (int i = 0; i < row; i++)// bucle que se repite el numeo de veces indicadas, al final hace el salto de linea 
            {
                for (int j = 0; j < i + 1; j++) //bucle que se repite una vez mas que el numero de linea 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
