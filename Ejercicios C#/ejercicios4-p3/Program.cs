using System;

namespace ejercicios4_p3
{
    class Program
    {
        static void Main(string[] args)
        {
         sbyte P,M,D;
         int PF;
         PF = 0;
         D = 0;
            Console.WriteLine("opcion de procesador");
         P = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("opcion de memoria RAM");
         M = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("opcion de disco");
         D = sbyte.Parse(Console.ReadLine());
         switch (P){
            case 1:
            switch (M){
                case 1:
             PF = 800;
             break;
                case 2:
             PF = 900;
             break;
                 case 3:
             PF = 1000;
             break;
             default:
              Console.WriteLine (M +" no es una opcion valida");
              break;
            }
            break;
            case 2:
             switch (M){
                case 1:
                PF = 900;
                break;
                case 2:
                PF = 1000;
                break;
                case 3:
                PF = 1100;
                break;
                default:
                Console.WriteLine(M +" no es una opcion valida");
                break;
             }
             break;
             case 3:
              switch (M){
                case 1:
                PF = 1200;
                break;
                case 2:
                PF = 1400;
                break;
                case 3:
                PF = 2000;
                break;
                default:
                Console.WriteLine(M +" esa opcion no es valida");
                break;
              }
              break;
            }
             if (D==1){
                PF+=300;
            }
          Console.WriteLine("el total a pagar es: " + PF);
        }
    }
}
