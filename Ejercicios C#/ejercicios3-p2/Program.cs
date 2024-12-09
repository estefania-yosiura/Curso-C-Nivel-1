using System;

namespace ejercicios3_p2
{
    class Program
    {
        static void Main(string[] args)
        {
         int num;
            Console.WriteLine("ingrese un numero");
         num = int.Parse (Console.ReadLine ());
         if (num > 0) 
             Console.WriteLine("el numero es positivo");
          else if (num == 0) 
            Console.WriteLine("el numero es cero");
            else
            Console.WriteLine("el numero es negativo");
         }
        }
    }
