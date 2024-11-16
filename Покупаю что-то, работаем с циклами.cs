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

            int[] arr = { 6, 12, 18 };

            while (true)
            {

                Console.SetCursorPosition(0, 10);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Класс: {i + 1}. Мест: {arr[i]}");
                }


                Console.SetCursorPosition(0, 0);
                Console.Write("Выберите операцию: 1 - Выбрать класс. 2 - Завершить процесс. : ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:

                        Console.WriteLine("Выберите класс: ");
                        int userSector = Convert.ToInt32(Console.ReadLine()) -1;
                        if (arr.Length <= userSector || userSector < 0 || userSector > arr.Length)
                        {
                            Console.WriteLine("Нет такого класса!");
                            break;
                        }
                        Console.WriteLine("Сколько мест вы ходите купить: ");
                        int userPlace = Convert.ToInt32(Console.ReadLine());

                        if (arr[userSector] < userPlace || userPlace < 0 || userPlace > arr[userSector])
                        {
                            Console.WriteLine("Нет такого места!");
                            break;
                        }

                        arr[userSector] -= userPlace;
                        break;
                    case 2:
                        
                        break;
                }  
            }
        }
    }
}

// UPD 2:


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
                        Console.Write($"{games[i, j]} | ");
                    }
                    Console.WriteLine();
                }
                

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Опции массива: ");
                Console.WriteLine("1 - выбрать значение массива");
                Console.WriteLine("2 - завершить программа");

                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Выберите столбец в двумерном массива: ");
                        int userColumn = Convert.ToInt32(Console.ReadLine()) - 1;

                        if(games.Length <= userColumn || userColumn < 0)
                        {
                            Console.WriteLine("Нет такого столбца в массиве");
                            break;
                        }
                        Console.WriteLine("Выберите значения столбца: ");
                        int columnValue = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.WriteLine(games[userColumn, columnValue]);
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
