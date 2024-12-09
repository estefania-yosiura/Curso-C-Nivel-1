using System;

namespace ejercicios8_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con=0, acu=0, promedio;
            Console.WriteLine("ingresa un numero");
            n = int.Parse(Console.ReadLine());
            while (n !=0)
            {
               if (primo(n))
               {
                con++;
                 acu+=n;
               }
                Console.WriteLine("ingresa un nro");
                n = int.Parse(Console.ReadLine());
            }
            promedio = acu/con;
            Console.WriteLine("el promedio de numeros primos es: " + promedio + ".");
        }
         static bool primo(int N){
            int A= 0;
            for (int x = 1; x < N+1; x++)
            {
                if (N%x == 0)
                {
                    A++;
                }
            }
            if (A == 2)
                {
                    return true;
                }else
                {
                    return false;
                }
        }
    }
}
