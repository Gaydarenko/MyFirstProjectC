namespace MyFirstProjectC.Test
{
    public class LinearEquationTests
    {
        [TestCase(2, 3, 5, 1)]
        [TestCase(2, 3, 3, 0)]
        [TestCase(2, 3, 1, -1)]
        [TestCase(2, 4, 0, -2)]
        [TestCase(1, 3, 5, 2)]
        [TestCase(2, 0, 6, 3)]
        public void FindXTest(int a, int b, int c, int expect)
        {
            int actual = LinearEquation.FindX(a, b, c);
            Assert.AreEqual(expect, actual);
        }
        [TestCase(0, 0, 0)]
        [TestCase(0, 2, 2)]
        [TestCase(1, 3, 4)]
        [TestCase(-1, 3, 2)]
        [TestCase(-2, -4, -6)]
        public void FindSumTest(int a, int b, int expect)
        {
            int actual = LinearEquation.FindSum(a, b);
            Assert.AreEqual(expect, actual);
        }
        [TestCase(0, 0, 0)]
        [TestCase(0, 2, 0)]
        [TestCase(1, 3, 3)]
        [TestCase(-1, 3, -3)]
        [TestCase(-2, -4, 8)]
        public void FindMultTest(int a, int b, int expect)
        {
            int actual = LinearEquation.FindMult(a, b);
            Assert.AreEqual(expect, actual);
        }
        [TestCase(0, 0, 0)]
        [TestCase(0, 2, -2)]
        [TestCase(1, 3, -2)]
        [TestCase(-1, 3, -4)]
        [TestCase(-2, -4, 2)]
        public void FindDifTest(int a, int b, int expect)
        {
            int actual = LinearEquation.FindDif(a, b);
            Assert.AreEqual(expect, actual);
        }
        [TestCase(99, "Девяносто девять")]
        [TestCase(10, " Десять")]
        [TestCase(22, "Двадцать два")]
        [TestCase(15, " Пятнадцать")]
        [TestCase(77, "Семьдесят семь")]
        public static void ConvertTwoDigitNumberToStringTest(int num, string expect)
        {
            string actual = LinearEquation.ConvertTwoDigitNumberToString(num);
            Assert.That(actual, Is.EqualTo(expect));
        }
        [TestCase(0, 7, 7)]
        [TestCase(0, 0, 0)]
        [TestCase(5, 6, 0)]
        [TestCase(9, 22, 35)]
        public static void FindFibonachiNum(int a, int b, int expect)
        {
            int actual = LinearEquation.FindRangesSum(a, b);
            Assert.AreEqual(expect, actual);
        }
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        public static void FindFibonachiNumTest(int num, int expect)
        {
            int actual = LinearEquation.FindFibonachiNum(num);
            Assert.AreEqual(expect, actual);
        }
        [TestCase(1, 1)]
        [TestCase(42648472, 1)]
        [TestCase(687413, 3)]
        [TestCase(4, 0)]
        [TestCase(648248642, 0)]
        public static void CountOddTest(int num, int expect)
        {
            int actual = LinearEquation.CountOdd(num);
            Assert.AreEqual(expect, actual);
        }
        [TestCase(1, "1")]
        [TestCase(42648472, "27484624")]
        [TestCase(687413, "314786")]
        public static void MirrorNumberTest(int num, string expect)
        {
            string actual = LinearEquation.MirrorNumber(num);
            Assert.That(actual, Is.EqualTo(expect));
        }
        [TestCase(3450, 67897, false)]
        [TestCase(5, 5, true)]
        [TestCase(5, 6, false)]
        [TestCase(9245, 24452, true)]
        public static void CompareTest(int a, int b, bool expect)
        {
            bool actual = LinearEquation.Compare(a, b);
            Assert.That(actual, Is.EqualTo(expect));
        }

    }
}