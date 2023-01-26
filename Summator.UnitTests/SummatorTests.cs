using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {   
        //Tests sum numbers
        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);
            var expected = -100;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumOneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumZero()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumBigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);
            var expected = 6000000000;

            Assert.AreEqual(expected, actual);
        }

        //Tests average number
        [Test]
        public void Test_Summator_AveragePositiveNumbers()
        {
            var b = new int[] { 10, 22, 30, 45 };
            var actual = Summator.Average(b);
            var expected = 26;    

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_Summator_AverageNegativeNumbers()
        {
            var b = new int[] {-5, -17, -28, -30};
            var actual = Summator.Average(b);
            var expected = -20;

            Assert.AreEqual(actual, expected);
        }

        /*[Test]
        public void Test_Summator_AverageLongNumbers()
        {
            var b = new long[] { 1000000000, 2000000000, 5000000000, 3000000000 };
            var actual = Summator.Average(b);
            var expected = 8500000000;

            Assert.AreEqual(actual, expected);
        }*/
    }
}
