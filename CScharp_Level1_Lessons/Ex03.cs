using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    internal class Ex03
    {
        /*
Михаил Долгов

а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
метода.
*/

        static void Main(string[] args)
        {
            Console.WriteLine("Расчет расстояния между двумя точками.");

            Console.WriteLine("Введите координаты начальной точки: ");
            Console.Write("Х1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y1 = ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты конечной точки: ");
            Console.Write("Х2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y2 = ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", r(x1, x2, y1, y2));

        }

        static double r(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

    }
}
