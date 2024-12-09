using System;

namespace ejercicios7_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector.
             int[] nums = new int[10];
             int prom, MayorAlProm, suma=0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("digite un numero");
               nums[x] = int.Parse(Console.ReadLine());
            }
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            for (int x = 0; x < 10; x++)
            {
                suma += nums[x];
            }
            prom = suma/10;
            for (int x = 0; x < 10; x++)
            {
                if (nums[x] > prom)
                {
                    MayorAlProm = nums[x];
                   Console.WriteLine("este numero: " + nums[x] + ", es mayor al promedio, que es " + prom + ".");
                }
            }
        }
    }
}
