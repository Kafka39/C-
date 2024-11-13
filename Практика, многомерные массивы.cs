using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            bool isOpen = true;

            string[,] games =
            {
                { "Need for Speed Most Wanted", "GTA San Andreas - Grand Theft Auto", "Fallout 4"},
                { "EA SPORTS FIFA 23", "eFootball 2025", "FIFA Online 2" }
            };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 10);

                for (int i = 0; i < games.GetLength(0); i++) 
                {
                    Console.WriteLine($"Значения в массиве: {games[0, i]}");
                
                }
            }
        }
    }
}
