using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        //cración de fumcioncios para suma, resta, multiplicación y división
       static void suma()
            {
            Console.Write("primer número de la ecuación: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("segundo número de la ecuación: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(""+(x+y));
            }
        static int resta()
        {
            Console.Write("primer número de la ecuación: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("segundo número de la ecuación: ");
            int y = int.Parse(Console.ReadLine());
            return x - y;
         }
        static int multiplicacion(int x, int y)
            {
            Console.Write("primer número de la ecuación: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("segundo número de la ecuación: ");
            y = int.Parse(Console.ReadLine());
            return x * y;
            }
        static int division(int x, int y)
            {
            Console.Write("primer número de la ecuación: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("segundo número de la ecuación: ");
            y = int.Parse(Console.ReadLine());
            return x / y;
            }
        static void Main(string[] args)
        {
            ////ejercicio 1 crear dos arrays y e introducirle los datos enprimer lugar directamente y posteriormente mediante bucle
            //int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //int[] array2 = new int[10];
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    array2[i] = i+1;
            //    Console.WriteLine(array2[i]);
            //}

            ////ejercicio 2 el usuario nos intruduce 3 numeros y los introducimos dentro de un array y estos deben mostrarse por consola en orden inverso
            //int[] array = new int[3];


            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        Console.WriteLine("introduce los números: ");
            //        array[j] = int.Parse(Console.ReadLine());

            //    }
            //for (int i = array.Length-1; i >= 0; i--)//bucle que recorre el array a la inversa para ello se inicia la variable i en el numero de huecos de array menos una,  ya que la primera posición equivale a 0
            //{
            //    Console.WriteLine(array[i]);

            //}
            ////ejercicio 3.el usuario mete los valores en un arrya y le mostramos la suma de todos los elementos

            //Console.Write("cuantos números quieres sumar: ");
            //int cantidad = int.Parse(Console.ReadLine());
            //int[] array = new int[cantidad];
            //for (int j = 0; j < array.Length; j++)
            //{
            //    Console.WriteLine("introduce los números: ");
            //    array[j] = int.Parse(Console.ReadLine());

            //}
            //int sumatoria = 0;

            //for (int i = 0; i < array.Length; i++)
            //{

            //    sumatoria += array[i];

            //}
            //Console.WriteLine(sumatoria);

            ////Ejercicio 4 el usuario nos rellena un array de numeros y el usuario lo rellena y posteriormente copiamos elemento a elemento en otro array
            //Console.Write("cuantos números quieres introducir: ");
            //int cantidad = int.Parse(Console.ReadLine());
            //int[] array = new int[cantidad];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("que números quieres introducir: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //int[] array2 = new int[cantidad];
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    array2[i] = array[i];
            //    Console.WriteLine("elemento {0} de la lista es {1}", i + 1, array2[i]);

            //}
            //el usuario introduce los números y rellenamos el array y nostros le mostramos cuantos números estan duplicados

            //Console.Write("cuantos números quieres introducir: ");
            //int cantidad = int.Parse(Console.ReadLine());
            //int[] array = new int[cantidad];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("que números quieres introducir: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //bool duplicado = false; //se crea un un booleano que para salir de los bucles al encontrar el duplicado
            //for (int i = 0; i < array.Length && !duplicado; i++)// negamos el booleano convirtiendolo en verdadero porque ambas condiciones deben cumplirse
            //{
            //    for (int j = i+1; j < array.Length && !duplicado; j++) //en el segundo bucle le damos el valor de i+1 para que compare vaya comparando la posición anteior con la siguiente
            //    {
            //        if (array[i] == array[j])
            //        {
            //            Console.WriteLine(array[j] + " esta duplicado");
            //            duplicado = true;// transformamos el booleano en verdadero para que al negarse en los bucles se convierta en falso y no se cumpla la condición
            //        }

            //    }
            //}

            ////Ejercicio 5 ordenar de menor a mayor los números de un array
            //Console.Write("cuantos números quieres introducir: ");
            //int cantidad = int.Parse(Console.ReadLine());
            //int[] array = new int[cantidad];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("que números quieres introducir: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i+1; j < array.Length; j++)
            //    {
            //        int x = 0; //variable que guarda el numero para efectuar el cambio
            //        if (array[i]>array[j])// si la posición anterior es mayor que la anterior
            //        {
            //            x = array[j];// guardamos el valor de la caja para que al igualar ambas cajas no se pierda el valor
            //            array[j] = array[i]; //igualamos valores de ambas cajas
            //            array[i] = x; // la variable guardada anteriormente se introduce en la otra caja
            //        }
            //    }
            //    Console.WriteLine(array[i]);
            //}
            ////ejercicio 6 rellenar los 10 primerosnumeros naturales en una lista
            //List<int> lista = new List<int>();
            //for (int i = 0; i < 10; i++)// en el caso de la lista si no posee ningún elemento debemos poner los elementos que queremos añadir para que se inicie el bucle y metas los valores 
            //{
            //    lista.Add(i+1);
            //    Console.WriteLine(lista[i]);
            //}
            ////ejercico 7 el usuario introduce 3 numeros y se le muestra en orden inverso
            //List<int> lista = new List<int>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Que números quieres introducir: ");
            //    lista.Add(int.Parse(Console.ReadLine()));
            //    Console.WriteLine(lista[i]);

            //}
            //for (int i = lista.Count-1; i >=0 ; i--)
            //{
            //    Console.WriteLine(lista[i]);
            //}

            ////ejercicio 8 ordenar de menor a mayor

            //List<int> lista = new List<int>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Que números quieres introducir: ");
            //    lista.Add(int.Parse(Console.ReadLine()));
            //    Console.WriteLine(lista[i]);

            //}
            //for (int k = 0; k < lista.Count; k++)
            //{
            //    for (int j = k + 1; j < lista.Count; j++)
            //    {
            //        int x = 0;
            //        if (lista[k] < lista[j])
            //        {
            //            x = lista[k];
            //            lista[k] = lista[j];
            //            lista[j] = x;

            //        }

            //    }
            //    Console.WriteLine(lista[k]);//recuerda que para que te pinte la lista se debe poner en el final del primer bucle para que te pinte el cambio final
            //}
            ////ejercico 8 crear calculadora introduciendo 1 suma 2 resta 3 multiplicación 4 división 5 salir, se tiene que corregir
            //int x;
            //int y;
            //int z;
            //int sumatoria;
            //do
            //{
            //    Console.WriteLine("1.sumar \n2.restar \n3.multiplicar \n4.dividir \n5.salir");

            //    Console.Write("operacón: ");
            //    z = int.Parse(Console.ReadLine());


            //    switch (z)
            //    {
            //        case (1):
            //            Console.Write("primer número de la ecuación: ");
            //            x = int.Parse(Console.ReadLine());
            //            Console.Write("segundo número de la ecuación: ");
            //            y = int.Parse(Console.ReadLine());
            //            sumatoria = x + y;
            //            Console.WriteLine("{0}+{1}={2}",x,y,sumatoria);
            //            break;
            //        case (2):
            //            Console.Write("primer número de la ecuación: ");
            //            x = int.Parse(Console.ReadLine());
            //            Console.Write("segundo número de la ecuación: ");
            //            y = int.Parse(Console.ReadLine());
            //            sumatoria = x - y;
            //            Console.WriteLine("{0}-{1}={2}", x, y, sumatoria);
            //            break;
            //        case (3):
            //            Console.Write("primer número de la ecuación: ");
            //            x = int.Parse(Console.ReadLine());
            //            Console.Write("segundo número de la ecuación: ");
            //            y = int.Parse(Console.ReadLine());
            //            sumatoria = x * y;
            //            Console.WriteLine("{0}x{1}={2}", x, y, sumatoria);
            //            break;
            //        case (4):
            //            Console.Write("primer número de la ecuación: ");
            //            x = int.Parse(Console.ReadLine());
            //            Console.Write("segundo número de la ecuación: ");
            //            y = int.Parse(Console.ReadLine());
            //            sumatoria = x / y;
            //            Console.WriteLine("{0}/{1}={2}", x, y, sumatoria);
            //            break;
            //        default:
            //            break;
            //    }

            //}
            //while (z != 5);

            //Ejercicio 9
            int z;
            do
            {
                Console.WriteLine("1.sumar \n2.restar \n3.multiplicar \n4.dividir \n5.salir");
                Console.Write("operacón: ");
                z = int.Parse(Console.ReadLine());
                switch(z)
                {
                    case 1:

                        suma();
                        break;
                    case 2:
                        int resultado = resta();
                        Console.WriteLine(""+resta());
                        break;
                    default:
                        break;
                }

            }
            while (z != 5);



        }
    }
}
