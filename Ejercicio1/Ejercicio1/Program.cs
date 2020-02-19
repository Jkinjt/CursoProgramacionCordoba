using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables de tipo integer llamada numeroEntero
            int numeroEntero;
            //inicialización de variable llamada "x"
            //con el valor 4
            numeroEntero = 4;
            //declaración e inicialización
            int y = 3; 
            //declaración e inicialización de tipo floating point
            float numeroDecimal = 3.14f;
            // declaración e inicialización de tipo double
            double numeroGrande = 3.52d;
            //declaración e inicialización de character
            char letra = 'A';
            // declaración e inicialización string
            string frase = "hola que tal";
            // declaración e inicialización verdadero o falso
            bool booleanoFalso = false;
            bool booleanoVerdadero = true;
       
            

            Console.WriteLine("hello World)");
            Console.WriteLine(numeroEntero);
            Console.WriteLine(y);
            Console.WriteLine(numeroDecimal);
            Console.WriteLine(numeroGrande);
            Console.WriteLine(letra);
            Console.WriteLine(frase);
            Console.WriteLine(booleanoFalso);
            Console.WriteLine(booleanoVerdadero);
            Console.WriteLine("integrer" + numeroEntero + "bool" + booleanoFalso);
            Console.ReadLine();
        }
    }
}
