using System;

namespace ejercicios7_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            int[] nums = new int[10]; //M= Maximo
            bool ekis = false;
            int M = 0, pos = 1;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("digite un numero");
               nums[x] = int.Parse(Console.ReadLine());
            }
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            for (int x = 0; x < 10; x++)
            {
                if (ekis == false){
                    M = nums[x];
                    ekis = true;
                } else if (nums[x]> M){
                 M = nums[x];
                 pos = x + 1;
                }
            }
             Console.WriteLine("el valor maximo es " + M + ", su posicion es " + pos + ".");
        }
    }
}
