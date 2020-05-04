using NUnit.Framework;
using Homework1_Upd_Library;

namespace Homework1_LibraryTests
{
    public class Homework1_LibraryTests
    {
        private Homework1_Library  _homework1_Library;
        [SetUp]
        public void Setup()
        {
            _homework1_Library = new Homework1_Library();
        }

        [Test]
        [TestCase( 1, 1, 1, -3)]
        [TestCase(1, 1, 0, 1)]
        [TestCase(0, 1, 0, 1)]
        [TestCase(3, 3, 3, -27)]
        [TestCase(-3.5, -3.5, -3.5, -36.75)]

        public void TestDiscriminant(double a, double b, double c, double expected)
        {
            var disc = _homework1_Library.DiscriminantCalc(a, b, c);

            Assert.AreEqual(expected, disc.d);
        }

        [Test]
        [TestCase(1, 0, 0, 0)]
        [TestCase(1, 1, 0, 0)]
        [TestCase(2, -2.5, -2, 1.8)]
        [TestCase(2, -2.5, 0, 1.25)]

        public void TestSquareRoute_X1(double a, double b, double c, double expected)
        {
            var disc = _homework1_Library.DiscriminantCalc(a, b, c);
            const double delta = 00.1;

            Assert.AreEqual(expected, disc.x1, delta);
        }

        [Test]
        [TestCase(1, 0, 0, 0)]
        [TestCase(1, 1, 0, -1)]
        [TestCase(2, -2.5, -2, -0.55)]
        [TestCase(2, -2.5, 0, 0)]

        public void TestSquareRoute_X2(double a, double b, double c, double expected)
        {
            var disc = _homework1_Library.DiscriminantCalc(a, b, c);
            const double delta = 00.1;

            Assert.AreEqual(expected, disc.x2, delta);
        }

        [Test]
        [TestCase("1",true)]
        [TestCase("-23", true)]
        [TestCase("Rock", false)]
        [TestCase("!", false)]
        [TestCase(" ", false)]
        public void TestInputValidation(string a, bool expected)
        {
            bool inputVal = _homework1_Library.InputValidation(a);

            Assert.AreEqual(inputVal, expected);
        }
    }
}