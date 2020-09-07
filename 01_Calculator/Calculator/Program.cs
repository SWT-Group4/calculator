using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var calc = new Calc();
            double a = 12;
            double b = 44;
            double exp = 2;

            Console.WriteLine(calc.Add(a, b));
            Console.WriteLine(calc.Subtract(a, b));
            Console.WriteLine(calc.Multiply(a, b));
            Console.WriteLine(calc.Power(a, exp));


        }
    }
}
