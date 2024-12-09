using System;

namespace ejercicios7_p3
{
    class Program
    {
        static void Main(string[] args)
        {
          //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
          char c1, c2, letra;
          int con=0;
          char[] cadena = new char[21];
            Console.WriteLine("ingresa una frase letra por letra, esta termina con un punto");
          letra = char.Parse(Console.ReadLine());
          while (letra != '.' && con <= 20)
          {
            cadena[con] = letra;
          Console.WriteLine("ingresa una frase letra por letra, esta termina con un punto");
          letra = char.Parse(Console.ReadLine());
          con++;
          }
          cadena[con] = '\0';
          Console.WriteLine("ingresa la letra que queres reemplazar");
          c1 = char.Parse(Console.ReadLine());
          Console.WriteLine("ingresa la letra para reemplazar");
          c2 = char.Parse(Console.ReadLine());
          con = 0;
          while (cadena[con] != '\0')
          {
            if (cadena[con] == c1)
               cadena[con] = c2;
               con++;
          }
          con=0;
          while (cadena[con] != '\0')
          {
            Console.Write(cadena[con]);
            con++;
          }
        
        }
    }
}
