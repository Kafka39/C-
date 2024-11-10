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
