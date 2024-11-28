using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.CursorVisible = false;
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);



            char[,] map = ReadMap("map.txt");


            Task.Run(() =>
            {
                while (true)
                {
                    pressedKey = Console.ReadKey();
                }
            });

            int pacmanX = 1;
            int pacmanY = 1;
            int score = 0;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                DrawMap(map);
                
                Console.SetCursorPosition(pacmanX,pacmanY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(35, 0);
                Console.Write($"Score: {score}");

                HandleInput(pressedKey, ref pacmanX, ref pacmanY, map, ref score);

                Thread.Sleep(1000);
            }
        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");

            char[,] map = new char[GetMapLengthOfLine(file), file.Length];


            for (int x = 0; x < map.GetLength(0); x++)
                for (int y = 0; y < map.GetLength(1); y++)
                    map[x, y] = file[y][x];

            return map;
        }

        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
                
            {
                for (int x = 0; x < map.GetLength(0); x++)
                    Console.Write(map[x, y]);
                Console.WriteLine();
            }
        }

        private static int GetMapLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach (var line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }

            return maxLength;
        }

        private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map, ref int score)
        {
            int[] direction = GetDirection(pressedKey);

            int nextPacmanPositionX = pacmanX + direction[0];
            int nextPacmanPositionY = pacmanY + direction[1];


            char nextCell = map[nextPacmanPositionX, nextPacmanPositionY];

            if (nextCell == ' ' || nextCell == '.')
            {
                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;

                if (nextCell == '.')
                {
                    score++;
                    map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
                }
            }
        }

        private static int[] GetDirection(ConsoleKeyInfo pressedKey)
        {
            int[] direction = { 0, 0 };

            if (pressedKey.Key == ConsoleKey.W)
            {
                direction[1] = -1;
            }
            if (pressedKey.Key == ConsoleKey.S)
            {
                direction[1] = +1;
            }
            if (pressedKey.Key == ConsoleKey.A)
            {
                direction[0] = -1;
            }
            if (pressedKey.Key == ConsoleKey.D)
            {
                direction[0] = +1;
            }

            return direction;
        }
    }
}
