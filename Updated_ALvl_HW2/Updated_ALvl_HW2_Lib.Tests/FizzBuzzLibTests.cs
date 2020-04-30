using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Updated_ALvl_HW2_Lib;

namespace Updated_ALvl_HW2_Lib.Tests
{
    [TestClass]
    public class FizzBuzzLibTests
    {

        [TestInitialize]
        public void BeforeAll()
        {
            var fizzBuzzLib = new FizzBuzzLib();
        }

        [TestMethod]
        public void IsPrimeNumberChecker_3asPrimeNumber_True()
        {
            string input = "3";

            var result = FizzBuzzLib.IsPrimeNumberChecker(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPrimeNumberChecker_MMMasPrimeNumber_False()
        {
            string input = "MMM";

            var result = FizzBuzzLib.IsPrimeNumberChecker(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPrimeNumberChecker_WhiteSpaceasPrimeNumber_False()
        {
            string input = " ";

            var result = FizzBuzzLib.IsPrimeNumberChecker(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NumberValidation_5asInput_True()
        {
            string input = "5";

            FizzBuzzLib.Value = 5;

            var result = FizzBuzzLib.NumberValidation(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NumberValidation_MMMasInput_False()
        {
            string input = "MMM";

            var result = FizzBuzzLib.NumberValidation(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NumberValidation_WhiteSpaceasInput_False()
        {
            string input = " ";

            var result = FizzBuzzLib.NumberValidation(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NotNullValidation_WhiteSpaceasInput_False()
        {
            string input = " ";

            var result = FizzBuzzLib.NotNullValidation(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NotNullValidation_NullInput_False()
        {
            string input = null;

            var result = FizzBuzzLib.NotNullValidation(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPositiveNumber_5asInput_True()
        {
            int input = 5;

            var result = FizzBuzzLib.IsPositiveNumber(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPositiveNumber_Minus5asInput_False()
        {
            int input = -5;

            var result = FizzBuzzLib.IsPositiveNumber(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ParseToDouble_5asInput_5()
        {
            string input = "5";

            double expected = 5;

            var result = FizzBuzzLib.ParseToDouble(input);

            Assert.AreEqual(expected, actual: result);
        }

        [TestMethod]
        public void StartLastNumberChecker_1asStartNumber100asLastNumber_StartNumber1()
        {
            double startNumber = 1;

            double finalNumber = 100;

            double expectedStart = 1;

            double expectedFinal = 100;

            FizzBuzzLib.StartLastNumberChecker(ref startNumber, ref finalNumber);

            Assert.AreEqual(startNumber, expectedStart);
            Assert.AreEqual(finalNumber, expectedFinal);
        }

        [TestMethod]
        public void StartLastNumberChecker_100asStartNumber1asLastNumber_StartNumber1LastNumber100()
        {
            double startNumber = 100;

            double finalNumber = 1;

            double expectedStart = 1;

            double expectedFinal = 100;

            FizzBuzzLib.StartLastNumberChecker(ref startNumber, ref finalNumber);

            Assert.AreEqual(startNumber, expectedStart);
            Assert.AreEqual(finalNumber, expectedFinal);
        }
    }
}
