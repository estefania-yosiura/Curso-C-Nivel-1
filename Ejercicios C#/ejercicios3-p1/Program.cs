using System;

namespace ejercicios3_p1
{
    class Program
    {
        static void Main(string[] args)
        {
           int N;
            Console.WriteLine("ingrese un numero");
            N = int.Parse (Console.ReadLine ());
            if (N>10)
                Console.WriteLine ("es mayor a 10");
             else
                Console.WriteLine ("no es mayor 10");
        }
    }
}
