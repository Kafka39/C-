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

            int sum = 12, x = 5, y = 6;
            Add(out sum, x, y);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        static void Add(out int sum, int x, int y)
        {
            sum = x + y;
        }
    }
}
