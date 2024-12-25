using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf25._12._2024___5
{
    internal class Program
    {

        static void Main()
        {
            RandomNumbers(15, -20, 30);
        }

        static void RandomNumbers(int count, int min, int max)
        {
            Random random = new Random();
            int positiveCount = 0;

            Console.WriteLine("Сгенерированные числа:");

            for (int i = 0; i < count; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                Console.Write(randomNumber + " ");

                if (randomNumber > 0)
                {
                    positiveCount++;
                }
            }

            Console.WriteLine($"\nКоличество положительных чисел: {positiveCount}");
            Console.ReadKey();
        }
    }
}

