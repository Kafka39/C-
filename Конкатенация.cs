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

            int x = 10;
            int y = 3;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(y + x +" Так-с, это у нас C#. Конкатенация:" + (x + y));

            Console.ReadLine();
        }
    }
}
