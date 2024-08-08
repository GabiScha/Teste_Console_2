using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolezin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Escreva o nome correspondente a " + i + ":");
                nomes[i] = Console.ReadLine();
            }
            Array.Sort(nomes);

            Console.WriteLine("Ordem crescente:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Array.Reverse(nomes);

            Console.WriteLine(" decrescente:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.ReadKey();

        }
    }
}
