using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            //se establecen 3 variables, 
            
            Console.Write("introduce un número: ");
            float num1 = float.Parse(Console.ReadLine());//el numero introducido por el usuario, que indica el numero que queremos obtener su sumatoria
            int totalsum = 0; //la suma total que queremos obtener 
            for (int contador = 0; contador <= num1; contador++)// variable auxialiar que sirve para obtener el sigiente numero a sumar
            {
                totalsum = totalsum + contador;// 
            }
            
            Console.WriteLine(contador);
            Console.ReadLine();
        }
    }
}
