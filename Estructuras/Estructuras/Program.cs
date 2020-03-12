using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            alumno[] alumnos = new alumno[3];
            float media = 0;
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.Write("introduzca su nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Introduzca su nota: ");
                float nota = float.Parse(Console.ReadLine());
                alumnos[i] = new alumno(nombre, nota);
                media += nota;

            }
            Console.WriteLine();
            Console.WriteLine();


            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i].MostrarDatos();
                Console.WriteLine("La nota media de la clase es: " + media/alumnos.Length);
            }

            
            //alumno alumno1 = new alumno(nombre, nota);
            //alumno alumno2 = new alumno("Nacho", 5f);
            //alumno alumno3 = new alumno("Juan", 10f);
            //alumno alumno4 = new alumno("Pepe", 7.5f);
            //alumno1.MostrarDatos();
            //alumno2.MostrarDatos();
            //alumno3.MostrarDatos();
            //alumno4.MostrarDatos();


        }
    }
}
