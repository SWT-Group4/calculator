﻿/*
 *  File: 01_Calculator.cs
 *  Author: Daniel K. Vinther Wolf
 *  Created: 2020-08-23
 *  Last Modified: 2020-09-02
 *  Version: 0.2.0
 */

using System;
using System.Net.Http.Headers;

namespace _01_Calculator
{
    class Program
    {

        /// <remarks>
        /// This class writes to std out
        /// </remarks>
        /// <returns>
        /// Writes to std out
        /// </returns>
        /// <value> No value is created </value>
        
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator for SWT!\n");
            Calculator calc = new Calculator();

            double res = calc.Divide(5, 0);
            Console.WriteLine(res);
            Console.WriteLine(4.0 / 0);

            /*
            var a = 3.0;
            var b = 1.2;
            var result = 0.0;

            result = calc.Add(a, b);
            Console.WriteLine("{1} + {2} = {0}", result, a, b);

            result = calc.Subtract(a, b);
            Console.WriteLine("{1} - {2} = {0}", result, a, b);

            result = calc.Multiply(a, b);
            Console.WriteLine("{1} * {2} = {0}", result, a, b);

            result = calc.Power(a);
            Console.WriteLine("exp ^ {1} = {0}", result, a);
            */
        }
    }

    public class Calculator
    {
        /// <summary>
        /// This Calculator can perform arithmetic operations on two numbers
        /// Add, Subtract, Multiply and Raise a number to the exp Power
        /// </summary>
        /// <returns>
        /// Add(a+b), Subtract(a-b), Multiply(a*b) or Power(a^exp)
        /// </returns>
        public double Add(double a, double b)
        {
            // Evaluate (a + b)
            return a + b;
        }

        public double Subtract(double a, double b)

        {
            // Evaluate (a - b)
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            // Evaluate (a * b)
            return a * b;
        }

        public double Divide(double dividend, double divisor)
        {
            // Evaluate (a / b)

            if (divisor == 0)
                throw new DivideByZeroException();
            else
                return dividend / divisor;
        }

        public double Power(double a)
        {
            // Evaluate (e ^ a)
            return Math.Exp(a);
        }


        public double Root(double a)
        {
            if(a < 0)
                throw new DivideByZeroException();
            else
                return Math.Sqrt(a);
        }

        public double Log10(double a)
        {
            if (a < 0)
                throw new DivideByZeroException();
            else
                return Math.Log10(a);
        }
    }
}
