using NUnit.Framework;
/*
 *  File: 01_CalculatorUnitTests.cs
 *  Author: Daniel K. Vinther Wolf
 *  Created: 2020-09-03
 *  Last Modified: -
 *  Version: 0.1.0
 */

/*
 * Method: Boundary Value Analysis (bs) or Eq. Classes (eq)
 *  ID  | Function          | Valid and Invalid classes
 * -----------------------------------------------------------------------
 *  01  | Add (a + b)       | V: real numbers / I: non-numbers
 *      <<--- Test Cases --->>      |   Testdata            | Expected
 *  eq  01.1  CanAddNegWithPos:         a=(-1.0), b=1.0       0.00
 *  bs  01.2  WillNotRound_2:           a=1.25, b=1.24        2.49
 *  bs  01.3  WillNotRound_3:           a=1.26, b=1.24        2.50
 *  bs  01.4  WillNotRound_4:           a=1.27, b=1.24        2.51
 * -----------------------------------------------------------------------
 *  02  | Subtract (a - b)  | V: real numbers / I: non-numbers
 *      <<--- Test Cases --->>      |   Testdata            | Expected
 *  eq  02.1 CanSubtractNegFromPos:     a=(-1.0), b=1.0       -2
 *  eq  02.2 CanSubtractFromZero:       a=0, b=1              -1
 *  eq  02.3 CanSubtractPosFromNeg      a=1.0, b=(-1.0)        2
 * ----------------------------------------------------------------------- 
 *  03  | Multiply (a * b)  | V: real numbers / I: non-numbers
 *      <<--- Test Cases --->>      |   Testdata            | Expected
 *  eq  03.1 CanMultiplyNegWithPos:     a=(-1.0), b=2.0       -2.0
 *  eq  03.2 CanMultiplyNegWithNeg:     a=(-1.0), b=(-2.0)     2.0
 * -----------------------------------------------------------------------
 *  04  | Power (e ^ a)     | V: real numbers / I: non-numbers
 *      <<--- Test Cases --->>      |   Testdata            | Expected
 *  eq  04.1 ExpPowerToZero:            a=0                    1
 *  eq  04.2 ExpPowerToPos:             a=1.0987               3.00026314554
 *  eq  04.3 ExpPowerToNeg:             a=(-2.32)              0.0982735856
 * -----------------------------------------------------------------------
 */

namespace _01_Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            // Common Arrangements
            _uut = new Calculator();

        }
        // 01.1 to 01.4 
        [TestCase(-1.0, 1.0, 0.00)]
        [TestCase(1.25, 1.24, 2.49)]
        [TestCase(1.26, 1.24, 2.50)]
        [TestCase(1.27, 1.24, 2.51)]
        public void test_Add(double a, double b, double res)
        {
           // Special Arrangements

           // Act

           // Assert
           Assert.That(_uut.Add(a, b), Is.EqualTo(res));
        }

        // 02.1 to 02.3
        [TestCase(-1.0, 1.0, -2.0)]
        [TestCase(0, 1, -1)]
        [TestCase(1, -1, 2)]
        public void test_Subtract(double a, double b, double res)
        {
            // Special Arrangements

            // Act

            // Assert
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(res));
        }

        // 03.1 to 03.2
        [TestCase(-1.0, 2.0, -2.0)]
        [TestCase(-1.0, -2.0, 2.0)]
        public void test_Multiply(double a, double b, double res)
        {
            // Special Arrangements

            // Act

            // Assert
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(res));
        }

        // 04.1 to 04.3
        [TestCase(0,  1)]
        [TestCase(1.0987, 3.00026314554)]
        [TestCase(-2.32, 0.0982735856)]
        public void test_Power(double a, double res)
        {
            // Special Arrangements

            // Act

            // Assert
            Assert.That(_uut.Power(a), Is.EqualTo(res).Within(0.0000000001));
        }
    }
}