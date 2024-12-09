using System;

namespace ejercicios4_p4
{
    class Program
    {
        static void Main(string[] args)
        {
          int n1, n2,n3,R1,R2;
            Console.WriteLine("ingresa un numero");
          n1 = int.Parse(Console.ReadLine());
          Console.WriteLine("ingresa otro numero");
          n2 = int.Parse(Console.ReadLine());
          Console.WriteLine("ingresa otro numero mas");
          n3 = int.Parse(Console.ReadLine());
          R1 = n1 + n2;
          R2 = n2 * n3;
          if (R1 > R2){
            Console.WriteLine("la suma de los dos primeros es mayor al producto del segundo con el tercero");
          } else {
            Console.WriteLine("puto el que lee");
          }
        }
    }
}
