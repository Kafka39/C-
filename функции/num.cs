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


            Console.WriteLine(Sum(34, 6) +2);
            Console.ReadLine();
        }

        static int Sum(int X, int Y)
        {   

            return X + Y;
        }
    }
}
