using System;

namespace ejercicios2_p5
{
    class Program
    {
        static void Main(string[] args)
        {
        int no1, no2, no3, pr, suma;
           Console.WriteLine ("Ingresa la primera nota");
            no1 = int.Parse (Console.ReadLine ());
           Console.WriteLine ("Ingresa la segunda nota");
           no2 = int.Parse (Console.ReadLine ());
           Console.WriteLine ("Ingresa la tercera nota");
           no3 = int.Parse (Console.ReadLine ());
           suma = no1 + no2 + no3;
           pr = suma/3;
           Console.WriteLine ("Su promedio es " + pr);
        }
    }
}
