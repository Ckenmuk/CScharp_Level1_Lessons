using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson06
{
    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double Fun(double x, double a);
    internal class Ex01
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            double a = 2;
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        } // Создаем метод для передачи его в качестве параметра в Table
        
        public static double MyFunc1(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }
        public static double MyFunc2(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void main(string[] args)
        {

            OutputHelpers.PrintDemo(6, 1);

            Console.WriteLine(@"Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и
функцией a*sin(x).

");


            Console.WriteLine("a*x^2: ");
            Table(new Fun(MyFunc1), -2, 2);
            Console.WriteLine("a*sin(x): ");
            Table(MyFunc2, -2, 2);


        }
    }
}
