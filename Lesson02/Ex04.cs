using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson02
{
    internal class Ex04
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(2, 4);
            Console.WriteLine(@"Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password:
GeekBrains).Используя метод проверки логина и пароля, написать программу: пользователь
вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
цикла do while ограничить ввод пароля тремя попытками.");
            Console.WriteLine(@"=================================
");

            Console.WriteLine("Введите логин и пароль");
            int i = 2;
            do
            {
                if (isPassCorrect(Console.ReadLine(), Console.ReadLine()))
                {
                    Console.WriteLine("Добро пожаловать!");
                }
                else Console.WriteLine($"Некорректный логин/пароль. Осталось попыток: {i}");

                i--;

            } while (i >= 0);
        }

        static bool isPassCorrect(string login, string password)
        {
            if (login == "root" && password == "GeekBrains") return true; else return false;

        }
    }
}
