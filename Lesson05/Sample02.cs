using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    internal class Sample02
    {
        string str1;

        static void main(string[] args)
        {

            string str2 = new String(new char[] { 'H', 'e', 'l', 'l', 'o' });
            string str3 = "Hello, GeekBrains!";

            //str3.Length;

            Console.WriteLine(str3.Length);

            string str4 = "Hello, World!";

            string str5 = "Hello, World!";

            Console.WriteLine($"str4 == str5 => {str4 == str5}");
            Console.WriteLine($"str4 Equals str5 => {str4.Equals(str5)}");



            MyString str6 = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            MyString str7 = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });

            Console.WriteLine($"str6 == str7 => {str6 == str7}");
            Console.WriteLine($"str6 Equals str7 => {str6.Equals(str7)}");


            string str8 = "hello";
            string str9 = "Hello";
            int compare = str9.CompareTo(str8);
            Console.WriteLine(compare);


        }
    }

    class MyString
    {
        private char[] arr;

        public int Length
        {
            get { return arr.Length; }
        }

        public MyString(char[] arr)
        {
            this.arr = arr;
        }


        public static bool operator ==(MyString a, MyString b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(MyString a, MyString b)
        {
            return !a.Equals(b);
        }


        public override bool Equals(object obj)
        {
            if (obj is MyString)
            {
                return Length == ((MyString)obj).Length;
            }
            return false;
        }

    }
}
