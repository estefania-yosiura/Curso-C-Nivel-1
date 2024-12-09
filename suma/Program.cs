using System;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, r;
        Console.WriteLine ("ingrese un numero");
        numero1 = int.Parse (Console.ReadLine ());
        Console.WriteLine ("ingrese otro numero");
         numero2 = int.Parse (Console.ReadLine ());
        r = numero1 + numero2;
        Console.WriteLine ("el resultado es " + r);
        }
    }
}
