using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson02
{
    internal class Ex05
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(2, 5);
            Console.WriteLine(@"а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.");
            Console.WriteLine(@"=================================
");

            Console.Write("Введите Ваш вес в кг: ");
            double weigth = double.Parse(Console.ReadLine());

            Console.Write("Введите Ваш рост в см: ");
            double heigth = double.Parse(Console.ReadLine());

            double imt = Math.Round(weigth / Math.Pow(2, heigth / 100), 2);

            if (imt >= 18.5 && imt <= 24.9) Console.WriteLine($"Вес в норме, ИМТ = {imt}.");

            else if (imt < 18.5) Console.WriteLine($"Вам нужно набрать вес, ИМТ = {imt}, норма: от 18.5 до 24.9.");

            else Console.WriteLine($"Вам нужно похудеть, ИМТ = {imt}, норма от 18.5 до 24.9.");

            Console.ReadLine();

            Console.WriteLine("б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
            Console.WriteLine(@"=================================
");

            if (imt >= 18.5 && imt <= 24.9) Console.WriteLine($"Поздравляем, у Вас идеальное телосложение!");

            else if (imt < 18.5)
            {
                imt = 18.5;
                Console.WriteLine($"Вам нужно набрать {Math.Round(imt * Math.Pow(2, heigth / 100) - weigth)} кг для нормализации веса.");
            }

            else
            {
                imt = 24.9;
                Console.WriteLine($"Вам нужно сбросить {Math.Round(weigth - imt * Math.Pow(2, heigth / 100))} кг для нормализации веса.");
            }
        }

    }
}
