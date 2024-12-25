using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf25._12._2024___8
{
    class Program
    {
        static void Main()
        {
            PositiveNumbers(10, -20, 20);
        }

        static void PositiveNumbers(int count, int min, int max)
        {
            Random random = new Random();

            Console.WriteLine("Положительные числа и их характеристики:");

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(min, max + 1);

                if (number > 0)
                {
                    string parity = number % 2 == 0 ? "Четное" : "Нечетное";
                    Console.WriteLine($"{number} — {parity}");
                }
            }
        Console.ReadKey();
        }
    }
}
