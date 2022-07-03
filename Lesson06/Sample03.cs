using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    delegate double DoOperation(double x, double y);

    internal class Sample03
    {

        public static double Minus(double a, double b)
        {
            Console.Write($"{a} - {b}");
            return a - b;
        }

        public static double Plus (double a, double b)
        {
            Console.Write($"{a} + {b}");
            return a + b;
        }

        public static void Process(DoOperation operation, double a, double b)
        {
            double res = operation(a, b);
            Console.WriteLine($" = {res}");
        }

        static void main(string[] args)
        {
            int i = 1;
            string str = "Hello";
            DoOperation operation = Plus;

            Process(operation, 34, 5);

            Process(Minus, 34, 5);


            DoOperation multiOperation = delegate (double x, double y)
            {
                Console.Write($"{x} * {y}");
                return x * y;
            };

            Process(multiOperation, 3, 5);

            Process(delegate (double x, double y)
            {
                Console.Write($"{x} / {y}");
                return x / y;
            }, 10, 5);

        }

    }
}
