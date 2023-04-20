using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputS = "";
            int input = 0;
            string[] namn = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Skriv namn: ");
                namn[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Namn {i + 1}: " + namn[i]);
            }
            while (true)
            {
                Console.Write("skriv in vilket index du vill ändra: ");
                inputS = Console.ReadLine();
                if (!(inputS == "q"))
                {
                    if (int.TryParse(inputS, out input))
                    {
                        Console.Write("Skriv in vad du vill ändra till: ");
                        namn[input - 1] = Console.ReadLine();
                    }
                    else
                    {

                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Namn {i + 1}: " + namn[i]);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
