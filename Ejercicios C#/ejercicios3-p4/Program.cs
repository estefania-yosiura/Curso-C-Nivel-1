using System;

namespace ejercicios3_p4
{
    class Program
    {
        static void Main(string[] args)
        {
           int N1, N2, N3, N4, m;
            Console.WriteLine("ingresa un numero");
         N1 = int.Parse (Console.ReadLine ());
          Console.WriteLine("ingresa otro numero");
         N2 = int.Parse (Console.ReadLine ());
           Console.WriteLine("ingresa otro numero");
         N3 = int.Parse (Console.ReadLine ());
           Console.WriteLine("ingresa otro numero");
         N4 = int.Parse (Console.ReadLine ());
          if (N1<N2 && N1<N2 && N1<N3 && N1<N4) {
         m = N1;
         if (m > N3) {
         m = N3;
         if (m > N4) {
         m = N4;
         }
         }
         } else {
            m = N2;
            if (m > N3) {
            m = N3;
            }
            if (m > N4) {
            m = N4;
            }
            }
            Console.WriteLine ("el numero mas chiquito es: " + m);
        }
     }    
}