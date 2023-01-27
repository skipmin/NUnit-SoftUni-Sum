using System.Reflection.Emit;
using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {   
        //Tests sum numbers
        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            //Arrange
            var nums = new int[] { 1, 2 };
            var expected = 3;

            //Act
            var actual = Summator.Sum(nums);

            //Assert
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


        [Test]
        public void Test_Summator_SumPositiveNumbers()
        {
            //Arrange
            var nums = new int[] { 1, 2, 88 };
            var expected = 91;

            //Act
            var actual = Summator.Sum(nums);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
            Assert.That(actual, Is.EqualTo(91));
            Assert.That(9, Is.Not.EqualTo(8));

            Assert.False(9 == 8);
        }


        //Tests average number
        [Test]
        public void Test_Summator_AveragePositiveNumbers()
        {
            var b = new int[] { 10, 22, 30, 45 };
            var actual = Summator.Average(b);
            var expected = 26.75;    

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
            var b = new int[] { 1000000000, 2000000000, 5000000000, 3000000000 };
            var actual = Summator.Average(b);
            var expected = 2750000000;

            Assert.AreEqual(actual, expected);
        }*/
    }
}
