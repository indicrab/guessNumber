using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            int maxCount = 10;

            int count = 0;
            Random rnd = new Random();
            int guessNumber = rnd.Next(min, max);
            Console.WriteLine("Компьютер загадал число от {0} до {1}. Попробуйте угадать его за {2} попыток", min, max, maxCount);
            int n;
            do
            {
                count++;
                Console.Write("{0} попытка. Введите число:", count);
                while (!Int32.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Введи число");
                }
                if (n > guessNumber) Console.WriteLine("Перелет!");
                if (n < guessNumber) Console.WriteLine("Недолет!");
            }
            while (count < maxCount && n != guessNumber);
            if (n == guessNumber) Console.WriteLine("Поздравляю! Вы угадали число за {0} попыток", count);
            else Console.WriteLine("Неудача. Попробуйте еще раз");
            Console.ReadKey();

        }
    }
}
