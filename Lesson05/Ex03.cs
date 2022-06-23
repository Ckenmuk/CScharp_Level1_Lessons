using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson05
{
    internal class Ex03
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(5, 3);

            Console.WriteLine(@"Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например:
badc являются перестановкой abcd.
");
            string text1;

            string text2;

            Console.WriteLine("Введите строку №1");
            text1 = Console.ReadLine();

            Console.WriteLine("Введите строку №2");
            text2 = Console.ReadLine();

            int counter = 0;
            
            for (int i = 0; i < text1.Length; i++)
            {
                for (int j = 0; j < text2.Length; j++)
                {
                    if ((text1[i].Equals(text2[j])))
                    {
                        counter++;
                    }
                }
            }

            if (counter == text1.Length)  Console.WriteLine($"Строка {text1} является перестановкой строки {text2}"); 
            else Console.WriteLine($"Строка {text1} не является перестановкой строки {text2}");

            // не работает, если символы в строке повторяются, например абвга и агваб. Не понимаю, как этого избежать...
        }
    }
}
