using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;

namespace Lesson03
{

    struct Complex
    {
        public double im;
        public double re;


        public Complex Plus(Complex complex)
        {
            Complex res;
            res.re = re + complex.re;
            res.im = im + complex.im;
            return res;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

        public Complex Minus(Complex complex)
        {
            Complex res;
            res.re = re - complex.re;
            res.im = im - complex.im;
            return res;
        }

        public Complex Multiplication(Complex complex)
        {
            Complex res;
            res.re = re * complex.re + im * complex.im;
            res.im = im * complex.re + re * complex.im;
            return res;
        }

    }



    internal class Ex01
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(3, 1);
            Console.WriteLine(@"а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.
");
            Console.WriteLine(@"=================================
");

            Complex complex01;
            complex01.re = 2;
            complex01.im = 3;

            Complex complex02;
            complex02.re = -1;
            complex02.im = -2;


            Console.WriteLine($@"Операции с комплексными числами.

С1 = {complex01}
C2 = {complex02}

Выберите операцию:
1 - сложение ( + )
2 - вычитание ( - )
3 - умножение ( * )
");
            int caseSwitch = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Complex complexSum = complex01.Plus(complex02);

                    Console.WriteLine($"({complex01}) + ({complex02}) = {complexSum}");
                    break;
                case 2:
                    Complex complexDif = complex01.Minus(complex02);

                    Console.WriteLine($"({complex01}) - ({complex02}) = {complexDif}");
                    break;
                case 3:
                    Complex complexMult = complex01.Multiplication(complex02);

                    Console.WriteLine($"({complex01}) * ({complex02}) = {complexMult}");
                    break;
                default:
                    Console.WriteLine("Вы ввели некорректную команду");
                    break;
            }






        }
    }
}
