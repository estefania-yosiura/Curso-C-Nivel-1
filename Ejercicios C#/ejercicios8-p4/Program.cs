using System;

namespace ejercicios8_p4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2=0;
         Console.WriteLine("ingresa un nro");
         n = int.Parse(Console.ReadLine());
         PositivoNegativoCero(n, ref n2);
         Console.WriteLine("el estado del valor " + n + " es " + n2);
        }
        static void PositivoNegativoCero(int n1, ref int n2){
            if (n1 == 0)
                n2 = 0;
              else if (n1 > 0)
                n2 = 1;
               else 
               n2 = -1;
        }
    }
}
