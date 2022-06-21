using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson02
{
    internal class Ex02
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(2, 2);

            Console.WriteLine("Написать метод подсчета количества цифр числа.");
            Console.WriteLine(@"=================================
");
            Console.Write("Введите целое число: ");

            Console.WriteLine("Количество цифр в числе: " + SumNumbers(long.Parse(Console.ReadLine())));

        }

        static long SumNumbers(long a)
        {

            long sum = 0;
            while (a > 0)
            {
                sum++;
                a /= 10;
            }
            return sum;
        }


    }
}
