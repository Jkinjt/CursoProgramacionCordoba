using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    public struct alumno
    {
        public string nombre;
        public float nota;

        public alumno(string nombre, float nota)
        {
            this.nombre = nombre;
            this.nota = nota;


        }

        public void MostrarDatos()
        {
            Console.WriteLine("El nombre del alumno es: " + nombre);
            Console.WriteLine("La nota del alumno es: " + nota);
        }

    }
}
