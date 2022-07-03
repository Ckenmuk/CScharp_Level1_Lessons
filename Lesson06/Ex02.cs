using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;
using System.IO;

namespace Lesson06
{
    internal class Ex02
    {
        public static double F1(double x, double[] pars)
        {
            return pars[0] * x * x + pars[1] * x + pars[2];
        }
        public static double F2(double x, double[] pars)
        {
            return pars[0] * Math.Exp(x) + pars[1];
        }
        public static double F3(double x, double[] pars)
        {
            return pars[0] * Math.Tan(x) + pars[1];
        }
        public static void SaveFunc1(string fileName, double a, double b, double h, double[] pars)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F1(x, pars));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static void SaveFunc2(string fileName, double a, double b, double h, double[] pars)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F2(x, pars));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static void SaveFunc3(string fileName, double a, double b, double h, double[] pars)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F3(x, pars));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

            static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(6, 2);

            Console.WriteLine(@"Модифицировать программу нахождения минимума функции так, чтобы можно было
передавать функцию в виде делегата.
а) Сделать меню с различными функциями и представить пользователю выбор, для какой
функции и на каком отрезке находить минимум.

");

            Console.WriteLine(@"Выберите функцию: 
1 - f(x) = a * x^2 + b * x + c;
2 - f(x) = a * e^x + b;
3 - f(x) = a * log(x) + b;
");
            double choice;
            double o;
            if (double.TryParse(Console.ReadLine(), out o))
            {
                choice = o;
            }
            else
            {
                choice = 0;
            }

            Console.WriteLine(@"Выберите отрезок, на котором необходимо найти минимум функции.

Начало: ");
            double startRange;
            if (double.TryParse(Console.ReadLine(), out o))
            {
                startRange = o;
            }
            else
            {
                startRange = 0;
            }
            Console.WriteLine(@"Конец: ");
            double finishRange;
            if (double.TryParse(Console.ReadLine(), out o))
            {
                finishRange = o;
            }
            else
            {
                finishRange = 0;
            }
            double a;
            double b;
            double c;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите последовательно константы a, b, c:");

                    if (double.TryParse(Console.ReadLine(), out o))
                    {
                        a = o;
                    }
                    else
                    {
                        a = 0;
                    }
                    if (double.TryParse(Console.ReadLine(), out o))
                    {
                        b = o;
                    }
                    else
                    {
                        b = 0;
                    }
                    if (double.TryParse(Console.ReadLine(), out o))
                    {
                        c = o;
                    }
                    else
                    {
                        c = 0;
                    }

                    double[] pars1 = { a, b, c };

                    SaveFunc1("data.bin", -100, 100, 0.5, pars1);
                    Console.WriteLine("Минимум функции: " + Load("data.bin"));
                    break;
                case 2:
                    Console.WriteLine("Введите последовательно константы a, b");

                    if (double.TryParse(Console.ReadLine(), out o))
                    {
                        a = o;
                    }
                    else
                    {
                        a = 0;
                    }
                    if (double.TryParse(Console.ReadLine(), out o))
                    {
                        b = o;
                    }
                    else
                    {
                        b = 0;
                    }


                    double[] pars2 = { a, b };

                    SaveFunc2("data.bin", -100, 100, 0.5, pars2);
                    Console.WriteLine("Минимум функции: " + Load("data.bin"));
                    break;
                case 3:
                    Console.WriteLine("Введите последовательно константы a, b");

                    if (double.TryParse(Console.ReadLine(), out o))
                    {
                        a = o;
                    }
                    else
                    {
                        a = 0;
                    }
                    if (double.TryParse(Console.ReadLine(), out o))
                    {
                        b = o;
                    }
                    else
                    {
                        b = 0;
                    }


                    double[] pars3 = { a, b };

                    SaveFunc3("data.bin", -100, 100, 0.5, pars3);
                    Console.WriteLine("Минимум функции: " + Load("data.bin"));
                    break;
                    default:
                    Console.WriteLine(@"Ошибка ввода.

Выберите функцию: 
1 - f(x) = a * x^2 + b * x + c;
2 - f(x) = a * e^x + b;
3 - f(x) = a * tan(x) + b;");

                    break;
            
            }




        }
    }
}
