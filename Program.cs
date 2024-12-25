using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf25._12._2024___3
{
    internal class Program
    {
        static void Main()
        {
            DigitNumbers();
        }
        static void DigitNumbers()
        {
            int count = 0;

            Console.WriteLine("Четные двузначные числа:");
            for (int i = 10; i <= 99; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }

            Console.WriteLine($"\nКоличество четных двузначных чисел: {count}");
            Console.ReadKey();
        }
    }
}

