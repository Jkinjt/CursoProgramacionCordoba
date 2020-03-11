using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = -1;
            do
            {
                Console.WriteLine("1. ejercicio 1");
                Console.WriteLine("2. ejercicio 2");
                Console.WriteLine("3. ejercicio 3");
                Console.WriteLine("4. ejercicio 4");
                inicio = int.Parse(Console.ReadLine());

                switch (inicio)
                {
                    case 1:

                        //primero se crea la lista y se le añaden los valores
                        List<int> n = new List<int>();
                        n.Add(3);
                        n.Add(3);
                        n.Add(3);
                        n.Add(1);
                        n.Add(2);
                        n.Add(2);
                        //Creo dos arrays para que almacene por un lado los números y por otro las repeticiones
                        int[] numeros = new int[3];
                        int[] repeticiones = new int[3];



                        for (int i = 0; i < n.Count;)
                        {
                            for (int j = 0; j < numeros.Length; j++)
                            {

                            }
                        }
                        break;
                    case 2:
                        //decirle al usuario cuantos numeros parares hay y cuantes impares, se crea una lis
                        int[] n2 = new int[] { 3, 2, 1 };
                        int par = 0;
                        int impar = 0;

                        for (int i = 0; i < n2.Length; i++)
                        {
                            if (n2[i] % 2 == 0)
                            {
                                par++;
                                Console.WriteLine(n2[i] + " es un numero par");
                                par++;
                            }
                            else
                            {
                                impar++;
                                Console.WriteLine(n2[i] + " es un número impar");

                            }
                        }
                        break;

                    case 3:
                        //ejercico 3 EL usuario introduce una serie de numeros y almacenamos los números en dos lista una impar y otra e impar
                        Console.WriteLine("Cuantos números quieres introducir: ");
                        int nUser = int.Parse(Console.ReadLine()); //número de veces que el usuario quiere introducir números
                        int temp; //variable que almacenara los numeros introducidos temportalmente para dividirlos entre 0 e introducirlo en la lista correspondiente
                        List<int> impar2 = new List<int>();
                        List<int> par2 = new List<int>();

                        for (int i = 0; i < nUser; i++)
                        {
                            Console.WriteLine("introduce un número: ");
                            temp = int.Parse(Console.ReadLine());
                            if (temp % 2 == 0)
                            {
                                par2.Add(temp);
                            }
                            else
                            {
                                impar2.Add(temp);
                            }
                        }
                        Console.WriteLine("Números pares");
                        for (int i = 0; i < par2.Count; i++) //bucle que escribira los números dentro del array pares
                        {
                            Console.WriteLine(par2[i]);


                        }
                        Console.WriteLine("numeros impares: ");
                        for (int i = 0; i < impar2.Count; i++) //bucle que escribe los numeros dentro del array impar
                        {
                            Console.WriteLine(impar2[i]);


                        }
                        break;
                    case 4:
                        //el usuario intruduce un numero y le mostramos la tabla de multiplicar de dicho número
                        Console.Write("Que tabla de multiplicar quieres ver: ");
                        int multiplicar = int.Parse(Console.ReadLine());
                        int[] Tabla = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        for (int i = 0; i < Tabla.Length; i++)
                        {
                            Console.WriteLine(multiplicar + "x" + Tabla[i] + "= " + multiplicar * Tabla[i]);
                        }

                        break;
                    default:
                        break;


                }
            } while (inicio != 0);
        }
    }
}
