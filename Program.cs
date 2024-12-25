using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf25._12._2024___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 20.4;
            for (int i = 2; i <= 20; i++)
            {
                Console.WriteLine($"{i} шт. = {price*i} руб.")
            }
            Console.ReadKey();
        }
    }
}
