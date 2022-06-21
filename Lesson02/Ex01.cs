using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson02
{
    internal class Ex01
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(2, 1);

            Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine(@"=================================
");
            Console.WriteLine("Введите три числа: ");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Минимальное число: {MinNumber(a, b, c)}");
        }

        static double MinNumber(double a, double b, double c)
        {
            double min = a;

            if (min < b)
            {
                if (min > c)
                {
                    min = c;
                }
            }
            else if (min > b)
            {
                min = b;
                if (min > c)
                {
                    min = c;
                }
            }
            else
            {
                if (min > c)
                {
                    min = c;
                }
            }

            return min;
        }

    }
}