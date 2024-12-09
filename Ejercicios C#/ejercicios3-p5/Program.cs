using System;

namespace ejercicios3_p5
{
    class Program
    {
        static void Main(string[] args)
        {
           int N1, N2, N3, N4;Console.WriteLine("Ingresa un numero");
          N1 = int.Parse(Console.ReadLine ());
            Console.WriteLine("Ingresa otro numero");
          N2 = int.Parse(Console.ReadLine ());
            Console.WriteLine("Ingresa otro numero mas");
          N3 = int.Parse(Console.ReadLine ());
            Console.WriteLine("Ingresa un numerito ma");
          N4 = int.Parse(Console.ReadLine ());
         if (N1>100){
            Console.WriteLine("el primer numero es mayor a 100");
         }
         if (N2>100){
            Console.WriteLine("el segundo numero es mayor a 100");
         }
         if (N3>100){
            Console.WriteLine("el tercer numero es mayor a 100");
         }
          if (N4>100){
            Console.WriteLine("el cuarto numero es mayor a 100");
         }
          }
        }
    }
