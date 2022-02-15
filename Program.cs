using System;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            for (a = 1; a < 101; a++)
            {
                if(a%3==0)
                {
                    Console.WriteLine("Ordico");
                }
                if(a%5==0)
                {
                    Console.WriteLine("OrdicoN");
                }
                if (a % 5 == 0 && a % 3 == 0)
                {
                    Console.WriteLine("OrdicoX");
                }
                else{ 
                Console.WriteLine(a);
                }
            }
        }
    }
}