using Ckenmuk.Test.Library;

namespace Ex02
{
    public static class StaticClass
    {
        public static int Calculations(int[] a)
        {
            int sum = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if ((a[i] % 3 == 0 && a[i + 1] % 3 == 0) || a[i] % 3 != 0 && a[i + 1] % 3 != 0)
                {

                }
                else sum++;
            }
            return sum;
        }

        public static int[] LoadArrayFromFile(string fileName)
        {
            #region в)**Добавьте обработку ситуации отсутствия файла на диске.

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Файл не найден, программа завершает работу");
                //                throw new FileNotFoundException();
                int[] array = { 0 };
                return array;
            }
            else
            {
                int[] buf = new int[1024];

                StreamReader streamReader = new StreamReader(fileName);


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

        }

    }


    internal class Ex02
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintDemo(4, 2);

            Console.WriteLine(@"Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает
задачу 1;
");

            int[] a = new int[20];

            Random rand = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-10000, 10000);
                Console.Write($"{a[i]} ");
            }
            Lesson04.MyClass.PrintArr(a);
            Console.WriteLine();

            Console.WriteLine(StaticClass.Calculations(a));


            Console.WriteLine(@"б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен
возвращать массив целых чисел;
");

            int[] b;
            string fileName = "ArrayList.txt";

            Lesson04.MyClass.PrintArr(StaticClass.LoadArrayFromFile(fileName));


        }




    }
}