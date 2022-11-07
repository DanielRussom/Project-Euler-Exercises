using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class SumEvenFibonacciNumbersEngineShould
    {
        private readonly SumEvenFibonacciNumbersEngine UnderTest;
        private readonly Mock<IFibonacciNumberGenerator> generator;

        public SumEvenFibonacciNumbersEngineShould()
        {
            generator = new Mock<IFibonacciNumberGenerator>();
            UnderTest = new SumEvenFibonacciNumbersEngine(generator.Object);
        }

        [TestMethod]
        [DataRow(2, new int[] { 2 })]
        [DataRow(6, new int[] { 2, 4 })]
        [DataRow(18, new int[] { 8, 8, 2 })]
        public void Sum_even_numbers_from_generated_fibonacci_list(int expectedResult, int[] numberList)
        {

            var limit = 2;
            generator.Setup(x => x.GenerateNumbersToLimit(limit)).Returns(new NumberList(numberList.ToList()));

            var result = UnderTest.SumToLimit(limit);

            generator.Verify(x => x.GenerateNumbersToLimit(limit), Times.Once());
            Assert.AreEqual(expectedResult, result);
        }
    }
}
