using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    class EstructuraEmpleado
    {
        public string nombre;
        public Fecha fechaNacimiento;

        public EstructuraEmpleado(string nombre, Fecha fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;

        }

        public void MostrarDatos()
        {
            Console.WriteLine("El nombre del empleado es: " + nombre);
            Console.WriteLine("fecha de nacimiento: " + fechaNacimiento.ConvertirString());
        }


    }
}
