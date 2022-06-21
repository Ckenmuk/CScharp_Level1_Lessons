using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ckenmuk.Test.Library;
namespace Lesson2
{
    internal class Sample01
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(2, 1);
            Console.ReadLine();

            Console.WriteLine("Решение квадратного уравнения");
            Console.WriteLine("=============================");

            Console.Write(" a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write(" b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write(" c = ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            double x1;
            double x2;

            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней");

            }

            else if (discriminant == 0)
            {


                x1 = -b / 2 * a;
                x2 = x1;
                Console.WriteLine($"Корни квадратного уравнения: x1 = {x1}; x2 = {x2}");
            }

            else
            {

                x1 = (-b + Math.Sqrt(discriminant)) / 2;
                x2 = (-b - Math.Sqrt(discriminant)) / 2;
                Console.WriteLine($"Корни квадратного уравнения: x1 = {x1}; x2 = {x2}");
            }




        }
    }
}
