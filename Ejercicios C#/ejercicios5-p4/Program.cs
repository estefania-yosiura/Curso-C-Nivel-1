using System;

namespace ejercicios5_p4
{
    class Program
    {
        static void Main(string[] args)
        {
         int n, c=0;
            Console.WriteLine("ingresa un numero");
           n = int.Parse(Console.ReadLine());
             for (int x = 1; x < n+1; x++)
            {
                if (n%x == 0){
                 c++;
                }
            }
               if (c == 2){
                    Console.WriteLine("el numero es primo");
                } else {
                    Console.WriteLine("el nro no es primo");
                }
        }
    }
}
