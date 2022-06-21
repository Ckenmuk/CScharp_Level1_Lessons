using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    internal class Ex02
    {

        /*
Михаил Долгов

Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет индекса массы тела");

            Console.Write("Вес в килограммах: ");
            double m = double.Parse(Console.ReadLine()); // вводим строку, преобразуем строку в число с точкой

            Console.Write("Рост в сантиметрах: ");
            double h = double.Parse(Console.ReadLine()); // вводим строку, преобразуем строку в число с точкой

            double i = m / (h / 100 * h / 100); // расчет ИМТ с учетом ввода роста в сантиметрах (для удобства пользователя)

            Console.WriteLine("Индекс массы тела = " + i);
        }
    }
}
