using Ckenmuk.Test.Library;

namespace Lesson03
{
    internal class Ex02
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(3, 2);

            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine(@"=================================
");
            Console.WriteLine("Вводите числа последовательно. 0 = завершение");
            double x;
            double a;
            if (double.TryParse(Console.ReadLine(), out x))
            {
                a = x;
            }
            else
            {
                a = 0;

            }



            double sum = 0;
            while (a != 0)
            {

                if (a > 0 && a % 2 != 0)
                {
                    sum += a;
                }
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    a = x;
                }
                else
                {
                    a = 0;

                }
            }
            Console.WriteLine("Сумма нечетных положительных чисел: " + sum);
        }
    }
}