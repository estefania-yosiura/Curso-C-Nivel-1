using System;

namespace ejercicios5_p2
{
    class Program
    {
        static void Main(string[] args)
        {
           int M=0, N=0;
            for (int x = 0; x < 10; x++)
         {
                Console.WriteLine("ingresa un nro");
             N = int.Parse(Console.ReadLine ());
             if (x==0){
             M = N;
             } else if (N > M) {
             M = N;
             }
        }
            Console.WriteLine("El mayor numero ingresado fue: " + M);
    }
}
}