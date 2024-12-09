using System;

namespace ejercicios2_p4
{
    class Program
    {
        static void Main(string[] args)
        {
         int TF, ST;
            Console.WriteLine ("Ingrese el total facturado");
         TF = int.Parse (Console.ReadLine ());
         ST = TF*15/100+15000;
            Console.WriteLine ("El sueldo total es " + ST);
        }
    }
}
