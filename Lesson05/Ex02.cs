using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson05
{
    public static class Message
    {
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-" };

        public static void PrintWords(string text, int n)
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= n)
                {
                    Console.WriteLine(words[i]);
                }
            }

        }

        public static void DeleteWords(string text, string symbol)
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if ((words[i][words[i].Length - 1]).ToString() == symbol)
                {
                    words[i] = "";
                }
                Console.Write(words[i].ToString() + " ");
            }

        }

        public static void TheLongestWord(string text)
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length) { longestWord = words[i]; }
            }

            Console.WriteLine($"Самое длинное слово: {longestWord}");
        }

        public static void SBofLongestWords(string text)
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder(1000);
            
            string longestWord = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length) { longestWord = words[i]; }
            }

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length == longestWord.Length) { sb.Append(words[i] + " "); }
            }

            Console.WriteLine(sb.ToString());
        }



    }

    internal class Ex02
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(5, 2);

            Console.WriteLine(@"Разработать статический класс Message, содержащий следующие статические методы для
обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
");
            string text;

            Console.WriteLine("Введите текст");
            text = Console.ReadLine();
            Console.WriteLine("n = ");
            int n = 0;
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
            {
                n = x;
            }
            else
            {
                n = 0;
            }
            Message.PrintWords(text, n);

            Console.WriteLine(@"

б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
");
            Console.WriteLine("Введите текст");
            text = Console.ReadLine();
            Console.Write("Запрещенный символ: ");
            string symbol = Console.ReadLine();


            Message.DeleteWords(text, symbol);


            Console.WriteLine(@"

в) Найти самое длинное слово сообщения.
");
            Console.WriteLine("Введите текст");
            text = Console.ReadLine();
            Message.TheLongestWord(text);


            Console.WriteLine(@"

г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
");
            Console.WriteLine("Введите текст");
            text = Console.ReadLine();
            Message.SBofLongestWords(text);


        }
    }
}
