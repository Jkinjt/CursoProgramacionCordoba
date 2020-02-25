using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenación_de_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 1, -1, }; //se Crea la lista de numeros
            

           Console.WriteLine(numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
            for (int i = 0; i < numbers.Length; i++) // primer bucle que sirve para fijar un número que vamos a comparar posteriormente
            {
                for (int j = i + 1; j < numbers.Length; j++) // segundo bucle que compara el numero fijado antes con los otros números
                {
                    if (numbers[j] < numbers[i]) //condicional que se activa si el segundo numero es menor, y sustituyendo los numeros
                    {
                        int aux = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = aux;
                    }
                    Console.WriteLine(numbers[i]);
                }
                Console.WriteLine(numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
            }

        }
    }
}
