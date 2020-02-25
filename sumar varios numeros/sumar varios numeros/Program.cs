using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumar_varios_numeros
{
    class Program
    {
        static void Main(string[] args)
        {//necesitamos 4 variables, , otra para los numeros introducidos por el usuario
            int repeticion;  //una para el número de numeros que quiere introducir
            Console.Write("¿cuantos numeros quieres introducir: ");
            repeticion = int.Parse(Console.ReadLine());
            int num;//numeros que introduce
            int sumatotal = 0; // variable que guarda la suma de los numeros
            for (int contador = 0; contador < repeticion; contador++)// bucle para permitir repetir la introducción de números el número de veces indicado 
            {
                
                Console.Write("introduce el numero a sumar: ");
                num = int.Parse(Console.ReadLine());// variable que guarda los numeros introducidos por el usuario a sumar
                sumatotal = num + sumatotal;
            }
            Console.WriteLine("el resultado es: " + sumatotal);
            Console.ReadLine();


        }
    }
}
