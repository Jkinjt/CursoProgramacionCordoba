using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración e inicialización
            Console.WriteLine("introduce tu nota");
            int nota = int.Parse(Console.ReadLine());

                Console.WriteLine(nota);
            //calificación de notas
            switch (nota)
            {
                case 10:
                    Console.WriteLine("ostia puta");
                    Console.ReadLine();
                    break;
                case 9:
                case 7:
                    Console.WriteLine("sigue asi");
                    Console.ReadLine();
                    break;
                case 8:
                    Console.WriteLine("pichi picha");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("menos da una piedra");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("por los pelos");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("necesita mejorar");
                    break;
            }
            
            
            
        
        }
        
    }
}
