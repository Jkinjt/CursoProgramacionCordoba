using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            EstructuraEmpleado[] empleados = new EstructuraEmpleado[1];
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.Write("escriba el nombre del empleado: " );
                string nombre = Console.ReadLine();
                Console.Write("escriba el dia de nacimiento del empleado: ");
                int dia = int.Parse(Console.ReadLine());
                Console.Write("escriba el mes de nacimiento del empleado: ");
                int mes = int.Parse(Console.ReadLine());
                Console.Write("escriba el nombre del empleado: ");
                int anno = int.Parse(Console.ReadLine());
                Fecha fechaNacimiento = new Fecha(dia, mes, anno);
                empleados[i] = new EstructuraEmpleado(nombre,fechaNacimiento);

            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < empleados.Length; i++)
            {
                empleados[i].MostrarDatos();
            }
        }
    }
}
