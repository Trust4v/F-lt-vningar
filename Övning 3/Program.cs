using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in antal mätningar : ");
            int antal = int.Parse(Console.ReadLine());
            string[] tal = new string[antal];
            double medel = 0;
            for (int i = 0; i < antal; i++)
            {
                Console.Write($"Skriv mätning {i+1}: ");
                tal[i] = Console.ReadLine();
                medel += double.Parse(tal[i]);
            }
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine($"Mätning {i + 1}: " + tal[i]);
                
            }
            Console.WriteLine("Medelvärde: " + medel / antal);

        }
    }
}
