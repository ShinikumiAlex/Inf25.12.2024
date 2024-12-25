using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf25._12._2024___6
{
    internal class Program
    {
        static void Main()
        {
            RandomNumbers(12, -50, 50);
        }


        static void RandomNumbers(int count, int min, int max)
        {
            Random random = new Random();

            Console.WriteLine("Сгенерированные числа и их классификация:");

            for (int i = 0; i < count; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                string classification = randomNumber > 0 ? "Положительное" : randomNumber < 0 ? "Отрицательное" : "Ноль";
                Console.WriteLine($"{randomNumber} — {classification}");
            }
            Console.ReadKey();
        }
    }
}