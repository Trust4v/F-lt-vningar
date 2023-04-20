using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Skriv namn: ");
                namn[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Namn {i+1}: " + namn[i]);
            }
        }
    }
}
