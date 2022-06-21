using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    public static class Message
    {
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-" };

        public static void PrintWords(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 3 && words[i][0] == words[i][words[i].Length - 1])
                {
                    Console.WriteLine(words[i]);
                }
            }

        }


    }


    internal class Sample03
    {
        static void main(string[] args)
        {
            string message = "За окном потоп, а я ем торт.";
            Message.PrintWords(message);

            Console.WriteLine(message);

        }
    }
}
