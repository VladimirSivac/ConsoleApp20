using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Консольное приложение для выявления счастливого билета
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Главный метод программы
        /// </summary>
        static void Main(string[] args)
        {
            int ticketNumber = InputTicketNumber();
            bool isLucky = IsLuckyTicket(ticketNumber);
            PrintResult(isLucky);
        }
        
        /// <summary>
        /// Ввод номера билета с проверкой корректности
        /// </summary>
        /// <returns>Корректный шестизначный номер</returns>
        public static int InputTicketNumber()
        {
            while (true)
            {
                Console.Write("Введите шестизначный номер билета: ");
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out int number);
                if (!isNumber)
                {
                    Console.WriteLine("Ошибка! Введите целое число");
                    continue;
                }

                if (number >= 100000 && number <= 999999)
                    return number;

                Console.WriteLine("Ошибка! Число должно быть шестизначным");
            }
        }

        /// <summary>
        /// Проверяет, является ли билет счастливым
        /// </summary>
        /// <param name="number">Номер билета для проверки</param>
        /// <returns>True, если билет счастливый или False, если билет несчастливый</returns>
        public static bool IsLuckyTicket(int number)
        {
            int sumFirstHalf = (number / 100000) + (number / 10000 % 10) + (number / 1000 % 10);
            int sumSecondHalf = (number / 100 % 10) + (number / 10 % 10) + (number % 10);
            return sumFirstHalf == sumSecondHalf;
        }

        /// <summary>
        /// Выводит результат
        /// </summary>
        /// <param name="isLucky">Результат проверки билета</param>
        public static void PrintResult(bool isLucky)
        {
            Console.ForegroundColor = isLucky ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(isLucky 
                ? "Ура, у Вас счастливый билет!" 
                : "У Вас обычный билет");
            Console.ResetColor();
        }
    }
}