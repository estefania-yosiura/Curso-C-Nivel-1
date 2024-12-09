using System;

namespace cubo
{
    class Program
    {
        static void Main(string[] args)
        {
        int N1, R;
        Console.WriteLine ("ingrese un numero");
        N1 = int.Parse (Console.ReadLine ());
        R = N1 * N1 * N1;
        Console.WriteLine ("el resultao e " + R);
        }
    }
}
