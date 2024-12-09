using System;

namespace ejercicios4_p2
{
    class Program
    {
        static void Main(string[] args)
        {
          int L, I;
            Console.WriteLine("Cuantos litros se van a comprar?");
            L = int.Parse(Console.ReadLine());
            Console.WriteLine ("Ingrese el importe total de la venta");
            I = int.Parse(Console.ReadLine());
           if (L>500){
            I = I-I*25/100;
           } else if (L>300){
            I = I-I*15/100;
           } else if (L>100){
            I = I-I*10/100;
           }
           Console.WriteLine ("El importe final es: " + I);
        }
    }
}
