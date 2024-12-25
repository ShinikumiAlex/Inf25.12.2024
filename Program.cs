using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf25._12._2024___9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число N: ");
            if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
            {
                int sum = CalculateSum(N);
                Console.WriteLine($"Сумма всех чисел от 1 до {N} равна {sum}");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите положительное целое число.");
            }
            Console.ReadKey();
        }
        static int CalculateSum(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
