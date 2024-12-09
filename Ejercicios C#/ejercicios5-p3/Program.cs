using System;

namespace ejercicios5_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            int E, SUMA=0, pr;
          for (int x = 0; x < 20; x++)
          {
            Console.WriteLine("Ingrese su edad");
           E = int.Parse(Console.ReadLine ());
            if (E > 18)
              SUMA+= E;
          }
          pr = SUMA/20;
          Console.WriteLine("el promedio de edades es: " + pr);
        }
    }
}
