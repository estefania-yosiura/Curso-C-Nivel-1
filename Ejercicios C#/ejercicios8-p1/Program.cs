using System;

namespace ejercicios8_p1
{
    class Program
    {
        static void Main(string[] args)
        {
           int precio, cantidad, total;
            Console.WriteLine("ingrese el precio");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad a vender");
            cantidad = int.Parse(Console.ReadLine());
            total = producto(precio, cantidad);
            Console.WriteLine("el total es: " + total + ".");
        }
        static int producto (int n1, int n2){
           int r;
            r = n1 * n2;
            return r;
        }
    }
}
