using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf25._12._2024___4
{

    class Program
    {
        static void Main()
        {
            RandomNumbers(10, -40, 40);
        }

        static void RandomNumbers(int count, int min, int max)
        {
            Random random = new Random();
            Console.WriteLine("Сгенерированные числа:");

            for (int i = 0; i < count; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                Console.Write(randomNumber + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
