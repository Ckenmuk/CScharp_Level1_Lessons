using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Lesson05
{
    internal class Sample01
    {
        private static void main(string[] args)
        {
            char[] chars = new[]
            {
                'j',
                '\u006A',
                (char)106
            };

            Console.WriteLine(string.Join(" ", chars));

            char b = 'B';

            Console.WriteLine($"{b} {char.ToLower(b)} {char.ToUpper(b)}");

            char[] symbols = new char[] { '1', 's', '+', 'M', '$' };

            for (int i = 0; i < symbols.Length; i++)
            {

                UnicodeCategory category = char.GetUnicodeCategory(symbols[i]);

                switch (category)
                {
                    case UnicodeCategory.UppercaseLetter:
                        Console.WriteLine($"{symbols[i]} - буква в верхнем регистре");
                        break;
                    case UnicodeCategory.LowercaseLetter:
                        Console.WriteLine($"{symbols[i]} - буква в нижнем регистре");
                        break;
                    case UnicodeCategory.DecimalDigitNumber:
                        Console.WriteLine($"{symbols[i]} - число");
                        break;
                    case UnicodeCategory.MathSymbol:
                        Console.WriteLine($"{symbols[i]} - математический символ");
                        break;
                    default:
                        Console.WriteLine($"{symbols[i]} - другая категория");
                        break;
                }
            }
        }
    }
}
