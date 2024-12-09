using System;

namespace ejercicios6_p1
{
    class Program
    {
        static void Main(string[] args)
        {
           int con = 0, A = 0, n;
           for (int x = 0; x < 10; x++)
           {
            Console.WriteLine("ingresa un numero");
            n = int.Parse(Console.ReadLine());
              A = 0;
            for (int y = 1; y < n+1; y++)
            {
                if (n % y == 0){
                A++;
                }
            }
             if (A == 2){
                con++;
            }
           }
           Console.WriteLine("num de primos: " + con);
        }
    }
}
