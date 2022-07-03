using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    internal class Sample04
    {

        static bool isEvenNumber(int number)
        {
            return number % 2 == 0;
        }
        static void main(string[] args)
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 3, 9, -1, -4, 19, 8 });
            List<int> evenList = new List<int>();

            foreach (int number in list)
            {
                if (isEvenNumber(number))
                    evenList.Add(number);
            }

            foreach (int number in evenList)
            {
                Console.Write($"{number}\t");
            }

            Console.WriteLine();

            Predicate<int> predicate = isEvenNumber;

            List<int> evenList02 = list.FindAll(isEvenNumber);

            foreach (int number in evenList02)
            {
                Console.Write($"{number}\t");
            }

            Console.WriteLine();

            List<int> evenList03 = list.FindAll(delegate (int number)
            {
                return number % 2 == 0;
            });
            foreach (int number in evenList03)
            {
                Console.Write($"{number}\t");
            }

            Console.WriteLine();

            // лямбда-выражения
            List<int> evenList04 = list.FindAll(number => number % 2 == 0);
            foreach (int number in evenList04)
            {
                Console.Write($"{number}\t");
            }

            Console.WriteLine();
        }
    }
}
