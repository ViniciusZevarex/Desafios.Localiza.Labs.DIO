using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosTeste = int.Parse(Console.ReadLine());
            
            
            for (int x = 0; x < casosTeste; x++)
            {
              int numero = int.Parse(Console.ReadLine());
              int numero_esferas = 0;
              
              for (int i = 1; i <= numero; i++)
              {
                if( (ContaDivisores(i) % 2) == 0) numero_esferas++;
              }
              
              
              Console.WriteLine(numero_esferas);
            }
        }

        public static int ContaDivisores(int num)
        {
          
          int c = 0;
            for(int i = 1; i <= num;i++)
            {
                if(num % i == 0){
                    c++;
                }
            }
          
          return c;
        }
    }
}
