using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;
using System.Globalization;


namespace Lesson05
{
    internal class Ex01
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(5, 1);

            Console.WriteLine(@"Создать программу, которая будет проверять корректность ввода логина. Корректным логином
будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
при этом цифра не может быть первой.

");
            Console.WriteLine("Введите логин");

            bool isCorrect = false;
            string login;

            while (isCorrect == false)
            {
                login = new string(Console.ReadLine());
                if (login.Length < 2 || login.Length > 10)
                {
                    Console.WriteLine("Логин должен содержать от 2 до 10 символов");
                }
                else
                {
                    UnicodeCategory category = char.GetUnicodeCategory(login[0]);

                    switch (category)
                    {
                        case UnicodeCategory.DecimalDigitNumber:
                            Console.WriteLine("Логин не может начинаться с цифры");
                            break;
                        default:
                            for (int i = 0; i < login.Length; i++)
                            {
                                if (!(login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z' || login[i] >= '0' && login[i] <= '9'))
                                {
                                    Console.WriteLine("Логин должен содержать только латинские буквы или цифры");
                                    isCorrect = false;
                                    break;
                                }
                                else isCorrect = true;
                                Console.WriteLine($"Логин {login} зарегистрирован");
                                break;
                            }
                            break;
                    }

                }
            }











        }

    }
}
