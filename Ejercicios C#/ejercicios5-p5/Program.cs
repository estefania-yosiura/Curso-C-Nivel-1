using System;

namespace ejercicios5_p5
{
    class Program
    {
        static void Main(string[] args)
        {
           int N=0, MP=0, mi=0;
           for (int x = 0; x < 20; x++)
           {
            Console.WriteLine("ingrese un numero");
            N = int.Parse(Console.ReadLine());
            if (N%2==0){
                if (x == 0){
                    MP = N;
                } else if (N > MP) {
                    MP = N;
                }
            } else if (x == 0) {
                mi = N;
            } else if (N < mi){
                mi = N;
            }
           }
           Console.WriteLine("el mayor numero par es: " + MP);
           Console.WriteLine("el menor numero impar es: " + mi);
        }
    }
}
