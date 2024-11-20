using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            int[] arr = { 3, 5, 6 };
            arr = editArr(arr, 0, 5);
            Console.WriteLine(arr[0]);

            Console.ReadLine();
        }

        static int[] editArr(int[] arr, int index, int value)
        {
            arr = new int[6];
            arr[index] = value;

            return arr;
        }
    }
}
