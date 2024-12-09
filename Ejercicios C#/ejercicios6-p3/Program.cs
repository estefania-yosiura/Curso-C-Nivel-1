using System;

namespace ejercicios6_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            int n = 1, con=0;
             do
            {
                 Console.WriteLine("ingrese un numero");
                n = int.Parse(Console.ReadLine());
                con = 0;
                while (n>0)
                {
                    con++;
                    Console.WriteLine("ingresa otro numero");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("esta lista tiene " + con + " numeros.");
            } while (n >= 0);
        }
    }
}
