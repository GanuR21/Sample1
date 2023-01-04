using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreaOfSquare(4));
        }

        public static double AreaOfSquare(float a)
        {
            double result = a * a;
            return result;
        }
    }
}
