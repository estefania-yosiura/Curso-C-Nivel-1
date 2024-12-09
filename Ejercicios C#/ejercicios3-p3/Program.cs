using System;

namespace ejercicios3_p3
{
    class Program
    {
        static void Main(string[] args)
        {
          float IV, F;
            Console.WriteLine("ingrese su importe");
           IV = float.Parse (Console.ReadLine ());
         if (IV >= 5000) {
           F = IV - IV*18/100;
         } else if (IV>=1000) {
         F = IV - IV*10/100;
         } else {
            F = IV;
         }
         Console.WriteLine ("El importe final es: " + F);
        }
    }
}
