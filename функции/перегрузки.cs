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
            int[,] array = { { 1, 3, 4 }, { 2, 4, 5 } };

            arr = Resize(arr, 5);
            array = Resize(array, 10, 10);

            Console.WriteLine(arr.Length);
            Console.WriteLine(array.Length);
            Console.ReadLine();
        }

        static int[] Resize(int[] arr, int size)
        {
            int[] tempArr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                tempArr[i] = arr[i];
            }
            arr = tempArr;
            return arr;
        }

        static int[,] Resize(int[,] arr, int x, int y)
        {
            int[,] tempArr = new int[5, 5];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) ; j++)
                {
                    tempArr[i, j] = arr[i, j];
                }
            }

            arr = tempArr;
            return arr;      
        }
    }
}
