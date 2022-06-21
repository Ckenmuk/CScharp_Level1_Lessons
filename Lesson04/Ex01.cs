using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ckenmuk.Test.Library;

namespace Lesson04
{
    public class MyClass
    {
        #region Private Fields

        private int[] array;


        #endregion

        #region Constructors


        public int[] MyArray(int[] array)
        {
            this.array = array;
            return array;
        }

        public int[] MyArray(int count)
        {
            array = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(-10000, 10001);
            }
            return array;
        }

        public int[] MyArray(string fileName)
        {
            array = LoadArrayFromFile(fileName);

            return array;
        }

        #endregion

        #region Private Methods

        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            int[] buf = new int[1024];

            StreamReader streamReader = new StreamReader(fileName);

            //            streamReader.ReadLine();
            //            streamReader.EndOfStream

            int counter = 0;
            while (!streamReader.EndOfStream)
            {
                buf[counter] = int.Parse(streamReader.ReadLine());
                counter++;
            }


            int[] arr = new int[counter];
            Array.Copy(buf, arr, counter);


            streamReader.Close();

            return arr;
        }

        #endregion

        public static void PrintArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

    }
    internal class Ex01
    {

        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(4, 1);

            Console.WriteLine(@"Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать
программу, позволяющую найти и вывести количество пар элементов массива, в которых только
одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
");

            int[] a = new int[20];

            Random rand = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-10000, 10001);
            }
            MyClass.PrintArr(a);
            Console.WriteLine();

            int sum = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if ((a[i] % 3 == 0 && a[i + 1] % 3 == 0) || a[i] % 3 != 0 && a[i + 1] % 3 != 0)
                {

                }
                else sum++;
            }
            Console.WriteLine(sum);
        }


    }

}
