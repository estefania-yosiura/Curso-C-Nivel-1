using System;

namespace ejercicios2_p3
{
    class Program
    {
        static void Main(string[] args)
        {
         int KM, vph, H;
         Console.WriteLine ("ingrese los kilometros");
         KM = int.Parse (Console.ReadLine ());
        Console.WriteLine ("INGRESA LA VELOCIDAD PROMEDIO DE UN VEHI CULO");
         vph = int.Parse (Console.ReadLine ());
         H = KM/vph;
        Console.WriteLine ("el tiempo aprox. es " + H + " hs.");
        }
    }
}
