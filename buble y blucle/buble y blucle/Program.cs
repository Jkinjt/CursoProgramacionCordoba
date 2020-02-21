using System;

namespace buble_y_blucle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int casas = 0;
                        int aldeanos = 0;
            Console.WriteLine(casas);
            do
            {
               casas = casas+1;
               Console.WriteLine("casas: " + casas);
                for (;  aldeanos < casas;)
                {
                    aldeanos = aldeanos + 1;
                    Console.WriteLine("aldeanos: " + aldeanos);
                    

                    Console.WriteLine(aldeanos + "/" + casas);
                }

            } while (aldeanos <= 50);
            Console.WriteLine(casas);
        }
    }
}
