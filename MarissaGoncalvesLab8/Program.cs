using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarissaGoncalvesLab8
{
    class Program
    {

        public delegate int MyDelegate(int a, int b);

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //Without Using Neither Delegates Nor Lamba Expression
            int a = 25, b = 37;

            Console.WriteLine("Sum of a and b is: {0}", Sum(a, b));
            Console.WriteLine();

            //Using Delegate(Initialization with a Named Method)
            MyDelegate del = new MyDelegate(Sum);
            Console.WriteLine("Calling the Sum method with the use of a delegate:");
            Console.WriteLine("Sum of a and b is: {0}", del(a, b));
            Console.WriteLine();

            //Using Anonymous Method (C# 2.0 Onwards)
            MyDelegate del2 = delegate(int x, int y) { return a + b; };
            Console.WriteLine("Calling the Sum method with the use of an anonymous method:");
            Console.WriteLine("Sum of a and b is {0}", del2(a, b));
            Console.WriteLine();

            //Using Lamda Expression (C# 3.0 Onwards)
            MyDelegate sumofTwoIntegers = (x, y) => { return x + y; };
            Console.WriteLine("Calling the Sum method with the use of a lamba expression:");
            Console.WriteLine("Sum of a and b is: {0}", sumofTwoIntegers(a, b));
            Console.WriteLine();

            Console.ReadKey();
        }

    }

}
