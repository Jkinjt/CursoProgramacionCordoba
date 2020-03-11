using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucles2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int contador = 0;
            //Console.WriteLine("Bucle en while");
            //while (contador < 10)
            //{
            //    Console.WriteLine(numeros[contador]);
            //    contador++;
            //}
            //contador = 0;
            //Console.WriteLine("Bucle do while");
            //do
            //{
            //    Console.WriteLine(numeros[contador]);
            //    contador++;
            //}

            //while (contador < 10);
            //contador = 0;

            //Console.WriteLine("Bucle for");
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}
            //// Ejercicio 2 sumar los numeros consecutivamente con los bucles

            //int total = 0;
            //while (contador < numeros.Length)
            //{
            //    Console.WriteLine(numeros[contador] + total);
            //    contador++;
            //}
            //contador = 0;

            ////ejercico 3 El usuario introduce un número donde el usuario elige que números quiere sumar
            //Console.WriteLine("Cuantos números quieres sumar: ");
            //int total = int.Parse(Console.ReadLine());
            //int contador = 0;
            //int sumatoria = 0; //las variables van fuera del bucle para que no se inicialicen cada vez que comienza el bucle
            //while (contador < total)
            //{

            //    Console.WriteLine("cuales son los números que quieres sumar: ");
            //    int nUser = int.Parse(Console.ReadLine());
            //    Console.WriteLine(nUser+sumatoria);
            //    sumatoria += nUser;
            //    contador++;
            //}

            // Ejercico 4 El usuario introduce 10 números por pantalla y le mostramos la suma de todos ellos


            //int total = 10;
            //int contador = 0;
            //int sumatoria = 0; //las variables van fuera del bucle para que no se inicialicen cada vez que comienza el bucle
            //                   //while (contador < total)
            //                   //{

            //    Console.WriteLine("cuales son los números que quieres sumar: ");
            //    int nUser = int.Parse(Console.ReadLine());

            //    sumatoria += nUser;
            //    contador++;
            //}
            //Console.WriteLine(sumatoria);
            //sumatoria = 0;
            //contador = 0;
            //Console.WriteLine("Bucle en do while");
            //do
            //{
            //    Console.WriteLine("cuales son los números que quieres sumar: ");
            //    int nUser = int.Parse(Console.ReadLine());

            //    sumatoria += nUser;
            //    contador++;
            //}
            //while (contador < total);
            //Console.WriteLine(sumatoria);
            //sumatoria = 0;

            //Console.WriteLine("Bucle en for");
            //for (int i = 0; i < total; i++)
            //{
            //    Console.WriteLine("cuales son los números que quieres sumar: ");
            //    int nUser = int.Parse(Console.ReadLine());

            //    sumatoria += nUser;

            //}
            //Console.WriteLine(sumatoria);

            //Console.WriteLine("A la sumatoria se le suma el número del usuario");// no es necesario crear una variable que almacene los números del usuario y los sume directamente en la variable sumatoria
            //sumatoria = 0;
            //contador = 0;

            //while (contador < total)
            //{

            //    Console.WriteLine("cuales son los números que quieres sumar: ");
            //    sumatoria += int.Parse(Console.ReadLine());

            //    contador++;
            //}
            //Console.WriteLine(sumatoria);

            //Ejercicio 5 el usuario introduce un número y nosotros le mostramos el cubo de los números que van desde el 1 hasta el número introducido por el usuario

            //Console.WriteLine("cual es el número que quieres introducir");
            //int x = int.Parse(Console.ReadLine());
            //int contador = 1; // el contador se inicia en 1 porque es la variable que vamos a utilizar para pintar todos los numeros hasta que llegue al del usuario
            //int cubox = 0;
            //while (contador <= x)// en este caso ponemos >= porque no se inicia en 0 el contador ya que lo vamos a usar como multiplicador

            //{
            //    cubox = (contador * contador * contador);
            //    contador++;
            //    Console.WriteLine(cubox);
            //}

            ////ejercico 6 El usuario introducirad un número y nosotros le ponemos la tabla de multiplicar

            //Console.WriteLine("Que tabla quieres que te muestre");
            //int multiplicador = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(multiplicador + "x" + i + "=" + multiplicador * i);
            //}

            // Ejercicio 7 El usuario introduce un número y le mostramos los sean pares

            //Console.Write("Hasta que número quieres que te enseñe los pares: ");
            //int total = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= total; i++)
            //{
            //    if (i % 2 == 0) 
            //    {
            //        Console.WriteLine(i + " es par");
            //    }
            //}
            //// si le sumamos en vez de +1 +2 va a ir saltando de 2 en 2 por que son solo los pares
            //Console.Write("Hasta que número quieres que te enseñe los pares: ");
            //int total = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= total; i += 2)
            //{

            //   Console.WriteLine(i + " es par");

            //}

            //Ejercico 8 escribir asteriscos, numeros consecutivos y numeros iguales en triangulo

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //numeros en misma columna

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            //numeros consecutivos en cada columna

            for (int i = 1; i <= 4; i++)
            {
                int variable = 1;
                for (int j = 0; j < i; j++)
                {
                    
                    Console.Write(variable);
                    variable++;

                }
                Console.WriteLine();
            }
            // numeros sumatorios
            int variable2 = 1;
            for (int i = 1; i <= 4; i++)
            {
                
                for (int j = 0; j < i; j++, variable2++ )
                {
                    
                    Console.Write(variable2);
                    

                }
                Console.WriteLine();
            }












        }
    }
}
