using System;

namespace ejercicios8_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contador = 0;
            for (int x = 0; x < 20; x++)
            {
              Console.WriteLine("ingrese un numero");
              n = int.Parse(Console.ReadLine());
              n = par (n);
              if (n == 1){
                contador++;
              }
            }
        Console.WriteLine("hay " + contador + " numeros pares.");
        }
        static int par(int n){
         if (n%2 == 0)
         {
            return 1;
         } else
         {
            return 0;
         }
        }
    }
}
