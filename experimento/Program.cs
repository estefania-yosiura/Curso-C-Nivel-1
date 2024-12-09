using System;

namespace experimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, r1, r2, r3, r4;
            Console.WriteLine ("ingresa un numero");
            num1 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("ingresa otro numerito");
            num2 = int.Parse (Console.ReadLine ());
        Console.WriteLine("ingresa otro numero mas");
            num3 = int.Parse (Console.ReadLine ());
            r1 = num1 + num2;
            r2 = num3 - num2;
            r3 = num1 * num1 * num1;
            r4= (num1 + num3) * num2;
            Console.WriteLine ("El resultado de la suma entre el primer y segundo numero es: " + r1);
            Console.WriteLine ("El resultado de la resta entre el tercer y segundo numero: " + r2);
            Console.WriteLine ("el primer numero elevado al cubo: " + r3);
            Console.WriteLine ("la suma del primer y tercer numero multiplicado por el segundo numero: " + r4);
        }
    }
}
