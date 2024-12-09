using System;

namespace ejercicios6_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
             // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
              //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
          int n, ct=0, con=0, p, pm=0, gm=0, min = 0, c=0;
          bool b=true;
          for (int x = 0; x < 5; x++)
          {
            Console.WriteLine("ingrese un nro");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                ct++;
                if (n%2!=0){
                  con++;
                }
                if (x==0){
                    min = n;
                } else if (min > n){
                 min = n;
                } else {
                    b = false;
                }
                   Console.WriteLine("ingresa un numero");
                  n = int.Parse(Console.ReadLine());
            }
            p = con*100/ct;
            if (x==0){
                gm = 1;
                pm = p;
            } else if (p>pm){
                gm = x+1;
                pm = p;
            }
            if (b){
                c++;
            }
          }
          Console.WriteLine("el grupo con mayor porcentaje de nums impares es el grupo " + gm + ".");
          if (c == 0) {
          Console.WriteLine("no hay grupos ordenados en la lista.");
          } else if (c == 1) {
           Console.WriteLine("hay un solo grupo ordenado en la lista");
          } else {
            Console.WriteLine("hay " + c + " grupos ordenados en la lista");
          }
        }
    }
}
