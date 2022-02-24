using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Int32.Parse(Console.ReadLine());
        
        
            for (int i = 0; i < limit; i++) 
            {
                string resposta = Console.ReadLine();
                if(string.IsNullOrEmpty(resposta)){
                Console.WriteLine("divisao impossivel");
                continue;
                }
                
                string[] line = resposta.Split(' ');
                
                if(line.Length == 1){
                Console.WriteLine("divisao impossivel");
                continue;
                }
                

                
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                
                if (Y == 0) {
                    Console.WriteLine("divisao impossivel");
                } else {
                    double divisao = X / Y; // Digite aqui o calculo da divisao
                    Console.WriteLine(divisao.ToString("F1"));
                }
            }
        }
    }
}
