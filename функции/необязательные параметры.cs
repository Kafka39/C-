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
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            Console.WriteLine("Привет");
            Console.WriteLine("Как дела ?");
            WriteError("Отсутствует подключения к интернету!", symbol: '#');
            Console.WriteLine("Алло!");
            WriteError("Интернет не оплачен.", ConsoleColor.Cyan);
            Console.ReadLine();
        }

        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!')
        {
            ConsoleColor defautColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(symbol + text);
            Console.ForegroundColor = defautColor;
        }
    }
}
