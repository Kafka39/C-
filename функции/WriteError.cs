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
            WriteError("Отсутствует подключения к интернету!");
            Console.WriteLine("Алло!");
            WriteError("Интернет не оплачен.");
            Console.ReadLine();
        }

        static void WriteError(string text)
        {
            ConsoleColor defautColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = defautColor;
        }
    }
}
