using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{

    partial class MySample
    {
        public int A { get; set; }
    }


    internal class Sample01
    {

        static void Main(string[] args)
        {
            MySample sample = new MySample();
            sample.A = 1;
            sample.B = 2;

        }
    }
}
