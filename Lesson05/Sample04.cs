using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    internal class Sample04
    {
        static void main(string[] args)
        {
            PrintString();

            Stopwatch sw = new Stopwatch();
            sw.Restart();

            string str = "";
            for (int i = 0; i < 30000; i++)
            {
                str += Guid.NewGuid();
            }

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);


            sw.Restart();
            StringBuilder sb = new StringBuilder(1000);
            for (int i = 0; i < 30000; i++)
            {
                sb.Append(Guid.NewGuid());
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        static void PrintString()
        {
            string str = "Hello!";

            str = str + "Hello, GeekBrains!";

            str = str + "Hello, World!";

            Console.WriteLine(str);
        }
    }
}
