using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson02
{
    internal class Ex06
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(2, 6);
            Console.WriteLine(@"*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать
подсчёт времени выполнения программы, используя структуру DateTime.");
            Console.WriteLine(@"=================================
");

            DateTime start = DateTime.Now;

            int sum = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (i % CrossMethods.SumNumbers(i) == 0) sum++;

            }
            Console.WriteLine($"Количество хороших чисел в диапазоне: {sum}");

            DateTime finish = DateTime.Now;
            Console.WriteLine($"Время работы программы: {finish - start}");
        }
    }
}
