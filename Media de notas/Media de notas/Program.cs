using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {// variables de nota
            Console.Write("introduce tus notas: ");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());
            //variable para la media
            float media = (num1 + num2 + num3) / 3;

            

            Console.WriteLine("Tu media es: " + media.ToString("0.00"));
            Console.ReadLine();

        }
    }
}
