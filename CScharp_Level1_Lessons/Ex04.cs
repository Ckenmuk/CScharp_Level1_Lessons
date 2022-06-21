using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    internal class Ex04
    {
        /*
Михаил Долгов

Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) *без использования третьей переменной.

 */

        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            // a)
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a + ", " + b);
            // б)
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a + ", " + b);
        }
    }
}
