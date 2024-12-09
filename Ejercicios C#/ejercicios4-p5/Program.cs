using System;

namespace ejercicios4_p5
{
    class Program
    {
        static void Main(string[] args)
        {
           int NUM1, NUM2, NUM3, NUM4;
            Console.WriteLine("ingrese un numero");
            NUM1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un nro");
            NUM2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            NUM3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            NUM4 = int.Parse(Console.ReadLine());
            if (NUM1 > NUM2 && NUM2 > NUM3 && NUM3 > NUM4){
                Console.WriteLine("los numeros se encuentran ordenados de forma decreciente");
            } else {
                Console.WriteLine("los numeros NO se encuentran ordenados de forma decreciente");
            }
        }
    }
}
