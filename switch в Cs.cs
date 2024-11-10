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

            string aad = Console.ReadLine();
            switch(aad)
            {
                case "1":
                case "3":
                case "4":
                    {
                        Console.WriteLine("Вы выбрали 1");
                    }

                    break;

                case "2":
                    {
                        Console.WriteLine("Вы выбрали 2");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("what?");
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
