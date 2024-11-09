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

            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPlay;

            Console.WriteLine("Доброе пожаловать в магази! Сегодня еда у нас по " + foodUnitPrice + " монет.");
            Console.Write("Сколько у вас монет ?");
            money = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Сколько еды вам нужно ?");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPlay = money >= food * foodUnitPrice;
            food = food * Convert.ToInt32(isAbleToPlay);

            money = money - foodUnitPrice * food;
            Console.WriteLine($"Вы купили {food} еды. У вас осталось {money} монет.");

            Console.ReadLine();
        }
    }
}
