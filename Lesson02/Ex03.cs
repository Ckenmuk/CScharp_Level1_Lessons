using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson02
{
    internal class Ex03
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(2, 3);

            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine(@"=================================
");
            Console.WriteLine("Вводите числа последовательно. 0 = завершение");
            double a = double.Parse(Console.ReadLine());
            double sum = 0;
            while (a != 0)
            {

                if (a > 0 && a % 2 != 0)
                {
                    sum += a;
                }
                a = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма нечетных положительных чисел: " + sum);

        }
    }
}
