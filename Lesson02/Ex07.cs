using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson02
{
    internal class Ex07
    {
        static void Main(string[] args)
        {

            OutputHelpers.PrintDemo(2, 7);
            Console.WriteLine("a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
            Console.WriteLine(@"=================================
");
            Console.WriteLine(OutputNumbers(1, 4));

            Console.WriteLine(@"=================================
");


            Console.WriteLine("б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.");
            Console.WriteLine(@"=================================
");
            Console.WriteLine(OutputNumbers1(1, 4, 0));
        }
        static string OutputNumbers(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine(a);
                a++;
                return OutputNumbers(a, b);

            }
            else return "Готово!";
        }

        static int OutputNumbers1(int a, int b, int sum)
        {

            if (a < b)
            {
                sum += a;
                a++;
                return OutputNumbers1(a, b, sum);

            }
            else return sum;
        }
    }
}
