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

                for (int i = 0; i <= games.GetLength(0); i++) 
                {
                    Console.WriteLine($"Значения в массиве: {games[0, i]}");
                
                }
            }
        }
    }
}


// UPD:

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
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Значения в массивов:");
                for (int i = 0; i < games.GetLength(0); i++) 
                {
                    for (int j = 0; j < games.GetLength(1); j++)
                    {
                        Console.WriteLine(games[i, j]);
                    }
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Опции массива: ");
                Console.WriteLine("1 - выбрать значение массива");
                Console.WriteLine("2 - завершить программа");

                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Выберите столбец в двумерном массива: ");
                        Console.WriteLine("1 - первый столбец");
                        Console.WriteLine("2 - второй столбец");

                        switch (Convert.ToInt32(Console.ReadLine())) {
                            case 1:
                                Console.WriteLine("Значения первого столбца: ");
                                for(int i = 0; i <= games.GetLength(0); i++)
                                {
                                    Console.WriteLine(games[0, i]);
                                }
                                break;
                            case 2:
                                Console.WriteLine("Значения второго столбца: ");
                                for (int i = 0; i <= games.GetLength(0); i++)
                                {
                                    Console.WriteLine(games[1, i]);
                                }
                                break;
                        };
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
