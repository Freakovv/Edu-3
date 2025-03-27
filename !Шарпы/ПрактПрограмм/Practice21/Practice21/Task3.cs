using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice21
{
    internal class Task3
    {
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        // Метод для проверки, что все цифры в числе одинаковы
        public static bool HasAllDigitsSame(int number)
        {
            if (number < 1000 || number > 9999) return false;

            int lastDigit = number % 10;
            number /= 10;

            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit != lastDigit)
                    return false;
                number /= 10;
            }
            return true;
        }

        // Метод для вывода списка билетов
        public static void PrintTickets(List<int> tickets)
        {
            foreach (var ticket in tickets)
            {
                Console.Write($"{ticket} (сумма: {SumOfDigits(ticket)}) ");
            }
            Console.WriteLine();
        }
    }
}
