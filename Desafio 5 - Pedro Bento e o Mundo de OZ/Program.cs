using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> joias = new List<string>();

            var joia = Console.ReadLine();
            while(!string.IsNullOrEmpty(joia))
            {
                joias.Add(joia);
                joia = Console.ReadLine();
            }

            int numeroJoias = joias.Distinct().Count();
            System.Console.WriteLine($"{numeroJoias}");
        }
    }
}
