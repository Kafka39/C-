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

            float rublesInWallet;
            float dollarsInWallet;

            int rubToUsd = 54, usdToRub = 55;

            float exchangeCurrencCount;

            string desiredOperation;

            Console.Write("Введите балас в рублях: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Введите балас в долларах: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите операцию. Доступные операции: \"1 -  обменять рубли на доллары\" \"2 - Обменять доллары на рубли\": ");
            desiredOperation = Console.ReadLine();

            switch(desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обменник рублей на доллары");

                    Console.Write("Сколько рублей вы ходите обменять на доллары ?: ");
                    exchangeCurrencCount = Convert.ToSingle(Console.ReadLine());

                    if(rublesInWallet >= exchangeCurrencCount)
                    {
                        rublesInWallet = rublesInWallet - exchangeCurrencCount;
                        dollarsInWallet = dollarsInWallet + exchangeCurrencCount / rubToUsd;

                        Console.Write($"Остаток баланса в рублях: {rublesInWallet}. Баланс на долларовом счету: {dollarsInWallet}");
                    } else
                    {
                        Console.WriteLine("У вас недостаточно денег для обмена");
                    }
                    break;

                case "2":

                    Console.WriteLine("Обменник долларов на рубли");

                    Console.Write("Сколько доллары вы ходите обменять на рубли ?: ");
                    exchangeCurrencCount = Convert.ToSingle(Console.ReadLine());

                    if(dollarsInWallet >= exchangeCurrencCount)
                    {
                        dollarsInWallet = dollarsInWallet - exchangeCurrencCount;
                        rublesInWallet = rublesInWallet + exchangeCurrencCount * usdToRub;

                        Console.Write($"Остаток баланса в долларах: {dollarsInWallet}. Баланс на рублевом счету: {rublesInWallet}");
                    } else
                    {

                    }
                    break;
                
                default:
                    Console.WriteLine("Не можем обменять такую валюту."); 
                    break;
            }
            Console.ReadLine();
        }
    }
}
