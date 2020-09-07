using System;
using NUnit.Framework;

namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorUnitTests
    {

        [TestCase(12,44, 56)]
        [TestCase(1, 2, 3)]
        [TestCase(-12, -44, -56)]
        [TestCase(2.23, 6.54, 8.77)]
        public void Add_TwoNums_CorrectResult(double a, double b, double res)
        {
            //Arrange
            var uut = new Calc();

            //Act
            double res1 = uut.Add(a, b);

            //Assert
            Assert.That(res1, Is.EqualTo(res));
        }

        [TestCase(12, 44, -32)]
        [TestCase(-12, -44, 32)]
        [TestCase(2.23, 6.54, -4.31)]
        public void Subtract_TwoNums_CorrectResult(double a, double b, double res)
        {
            //Arrange
            var uut = new Calc();

            //Act
            double res1 = uut.Subtract(a, b);

            //Assert
            Assert.That(res1, Is.EqualTo(res).Within(0.005));
        }

        [TestCase(12, 44, 528)]
        [TestCase(-12, -44, 528)]
        [TestCase(12, -44, -528)]
        [TestCase(2.23, 6.54, 14.5842)]
        public void Multiply_TwoNums_CorrectResult(double a, double b, double res)
        {
            //Arrange
            var uut = new Calc();

            //Act
            double res1 = uut.Multiply(a, b);

            //Assert
            Assert.That(res1, Is.EqualTo(res).Within(0.005));
        }


        [TestCase(10, 6, 1000000)]
        [TestCase(-2, 3, -8)]
        public void Power_TwoNums_CorrectResult(double a, double b, double res)
        {
            //Arrange
            var uut = new Calc();

            //Act
            double res1 = uut.Power(a, b);

            //Assert
            Assert.That(res1, Is.EqualTo(res).Within(0.005));
        }

    }
}
