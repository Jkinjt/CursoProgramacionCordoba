using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros; //variable que sirve para introducir numeros
            int[] lista1 = new int[3]; //se crea primera lista
            
            int[] lista2 = new int[3]; //se crea segunda lista
            
            for (int i = 0; i < 3; i++) //bucle para que el usuario intruduzca numeros
            {
                Console.WriteLine("escribe un número: ");
                numeros = int.Parse(Console.ReadLine());
                lista1[i] = numeros; //al hueco se le asigna un número
            }
            for (int i = 0; i < 3; i++)//segundo bucle para copiar la lista del otro
            {
                lista2[i] = lista1[i];
            }
            Console.WriteLine("la lista de numeros es " + lista2[0] + "," + lista2[1] + " y " + lista2[2]);//representación gráfica

        }
    }
}
