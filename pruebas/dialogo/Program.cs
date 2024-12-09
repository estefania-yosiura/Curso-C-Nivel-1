using System;

namespace dialogo
{
    class Program
    {
        static void Main(string[] args)
        {
            char Letra;
            Console.WriteLine("hola");
            Letra = char.Parse(Console.ReadLine());
            dialogo(Letra);
            
            }
            static void dialogo(char letra)
           {
               switch (letra)
            {
                case 'f':
                Console.WriteLine("como estas?");
                break;
                case ' ':
                Console.WriteLine("como estas?");
                break;
           }
        }
    }
}
