using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ckenmuk.Test.Library
{
    public class OutputHelpers
    {
        public static void PrintDemo(int homeworkNumber, int exerciseNumber)
        {
            Console.WriteLine($"Студент: Долгов Михаил Владимирович");
            Console.WriteLine($"Домашняя работа. Урок {homeworkNumber}");
            Console.WriteLine($"Упражнение {exerciseNumber}");
            Console.WriteLine(@"=======================
");

        }
    }

    public class CrossMethods
    {
        public static long SumNumbers(int a)
        {

            int sum = 0;
            while (a > 0)
            {
                sum++;
                a /= 10;
            }
            return sum;
        }
    }
}