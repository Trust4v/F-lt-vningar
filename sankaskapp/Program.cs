using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sankaskapp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur stor ska ditt fält vara (1-9)");
            int size = int.Parse(Console.ReadLine());
            int[,] spelbräde = new int[size, size];
            int[,] target = new int[size, size];
            int siffra = 0;
            int siffra2 = 0;
            int försök = 0;
            Console.Clear();
            Random rnd = new Random();
            int storlek;
            for (int i = 0; i < size / 2; i++)
            {
                if (size <= 4)
                {
                    storlek = rnd.Next(1, size - 1);
                }
                storlek = rnd.Next(1, 5);
                int håll = rnd.Next(0, 2);
                int startx = rnd.Next(0, size + 1 - storlek);
                int starty = rnd.Next(0, size + 1 - storlek);
                if (håll == 0)
                {
                    if (target[startx,starty] != 1)
                    {
                        for (int u = 0; u < storlek; u++)
                        {
                            if (target[startx  + u, starty] != 1)
                            {
                                target[startx + u, starty] = 1;
                                siffra++;
                            }
                        } 
                    }
                }
                else if (håll == 1)
                {
                    if (target[startx, starty] != 1)
                    {
                        for (int u = 0; u < storlek; u++)
                        {
                            if (target[startx, starty + u] != 1)
                            {
                                target[startx, starty + u] = 1;
                                siffra++;
                            }
                        }
                    }
                }  
            }
            while (true)
            {
                for (int i = 0; i < size + 1; i++)
                {
                    Console.Write(i + "|");
                }
                Console.Write("\n");
                for (int y = 0; y < size; y++)
                {
                    Console.Write((y + 1) + "|");

                    for (int x = 0; x < size; x++)
                    {
                        if (target[x, y] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(target[x, y]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(target[x, y]);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("|");
                    }

                    Console.Write("\n");
                }
                Console.WriteLine(siffra.ToString());
                Console.ReadLine();
                
                break;
            }
            while (true)
            {
                // skriver ut första raden med nummer
                for (int i = 0; i < size + 1; i++)
                {
                    Console.Write(i + "|");
                }
                Console.Write("\n");
                siffra2 = 0;
                försök = 0;
                // Skriver ut spelbrädet med träffar missar etc
                for (int y = 0; y < size; y++)
                {
                    Console.Write((y + 1) + "|");

                    for (int x = 0; x < size; x++)
                    {
                        if (spelbräde[x, y] == target[x, y] && target[x, y] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(spelbräde[x, y]);
                            siffra2++;
                        }
                        else if (spelbräde[x, y] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(spelbräde[x, y]);
                            försök++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(spelbräde[x, y]);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("|");
                    }

                    Console.Write("\n");
                }
                // hanterar om man vinner
                if (siffra == siffra2)
                {
                    break;
                }
                // hanterar var man skjuter
                Console.Write("Mata in X-kordinat : ");
                int xvärde = int.Parse(Console.ReadLine());
                Console.Write("Mata in Y-kordinat : ");
                int yvärde = int.Parse(Console.ReadLine());
                spelbräde[xvärde - 1, yvärde - 1] = 1;
                Console.Clear();
            }
            Console.WriteLine("Du klarade det och du missade " + försök + " gånger!");
            Console.ReadLine();
        }

    }
}