using System;

namespace ejercicios7_p4
{
    class Program
    {
        static void Main(string[] args)
        {
//Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
//- Número de Artículo (1 a 15)
//- Cantidad Vendida 
          int Cantidad, art, Max=0, macs=0;
          int[]Varticulo = new int [15];
          Console.WriteLine("ingresa el numero de articulo (1-15)");
          art = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese la cantidad a comprar");
          Cantidad = int.Parse(Console.ReadLine());
          while (art != 0 && art < 16 && art > -1)
          {
          Varticulo [art-1] += Cantidad;
          Console.WriteLine("ingresa el numero de articulo (1-15)");
          art = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese la cantidad a comprar");
          Cantidad = int.Parse(Console.ReadLine());
          }
//a) El número de artículo que más se vendió en total.
         for (int x = 0; x < 15; x++)
         {
            if (x == 0){
                macs = Varticulo[x];
                Max = x+1;
            } else if (Varticulo[x] > macs){
                Max = x+1;
                macs = Varticulo[x];
            }
         }
         Console.WriteLine("el articulo mas vendido es: " + Max + ".");
//b) Los números de artículos que no registraron ventas.
         for (int x = 0; x < 15; x++)
         {
            if(Varticulo[x] == 0){
              Console.WriteLine("el articulo numero " + (x+1) + " no ha registrado ventas");
            }
         }
//c) Cuantas unidades se vendieron del número de artículo 10.
          Console.WriteLine("El articulo 10 tuvo " + Varticulo[9] + " ventas.");
        }
    }
}
