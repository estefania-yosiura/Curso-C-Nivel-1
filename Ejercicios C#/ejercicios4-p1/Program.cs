using System;

namespace ejercicios4_p1
{
    class Program
    {
        static void Main(string[] args)
        {
          int n1, n2, R;
            Console.WriteLine("ingresa un numero");
            n1 = int.Parse(Console.ReadLine ());
            Console.WriteLine ("ingrese otro numero");
            n2 = int.Parse(Console.ReadLine ());
            if (n1 > n2) {
             R = n1 - n2;
            } else if (n2==n1){
             R = n1 + n2;
            } else {
             R = n1 * n2;
            }
            Console.WriteLine ("el resultado es: " + R);
        }
    }
}
