using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf25._12._2024___7
{
    internal class Program
    {
        static void Main()
        {
            AnalyzeNumbers(8, -30, 30);
        }


        static void AnalyzeNumbers(int count, int min, int max)
        {
            Random random = new Random();

            Console.WriteLine("Сгенерированные числа и их характеристики:");

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(min, max + 1);
                string sign = number > 0 ? "Положительное" : number < 0 ? "Отрицательное" : "Ноль";
                string parity = number % 2 == 0 ? "Четное" : "Нечетное";

                Console.WriteLine($"{number} — {sign}, {parity}");
            }
            Console.ReadKey();
        }
    }
}