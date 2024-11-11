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

            int[,] arr = { 

                { 1, 2, 3 }, 
                { 4,5,6 } 

            };


            Console.WriteLine(arr[4, 5]);

            Console.ReadLine();
        }
    }
}




/// NEW ADD #1

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

            int[,] arr = { 

                { 1, 2, 3 }, 
                { 4,5,6 } 

            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("\nIndex: " + i + " Length element: " + (arr.GetLength(0) + 1));
                Console.Write("Значения первого элемента: ");

                Console.Write(arr[0, i]);

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
            }

            Console.ReadLine();
        }
    }
}
