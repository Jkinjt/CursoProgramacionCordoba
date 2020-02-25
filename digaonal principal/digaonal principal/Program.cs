using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digaonal_principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe la dimensión de la matriz: ");
            int fyc = int.Parse(Console.ReadLine());
            int[,] cuadrado = new int[fyc, fyc]; // crea el cuadrado

            for (int i = 0; i < cuadrado.GetLength(0); i++)//bucle que recorre las filas
            {
                for (int j = 0; j < cuadrado.GetLength(1); j++)//bucle que recorre las columnas
                {
                    if (i == j) //cuando el número de la fila y de la columna coincidan se activa el condicional
                    {
                        cuadrado[i, j] = 1;// da valos de 1 a cada vez que coincidan filia y columna
                    }
                    Console.Write(cuadrado[i, j] + " ");

                }
                Console.WriteLine();

            }
            
        }   
    }
}
