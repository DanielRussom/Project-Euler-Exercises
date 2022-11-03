using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections.Generic;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class SumEvenFibonacciNumbersEngineShould
    {
        private SumEvenFibonacciNumbersEngine UnderTest;
        private Mock<IFibonacciNumberGenerator> generator;
        private Mock<INumberSummer> summer;

        public SumEvenFibonacciNumbersEngineShould()
        {
            generator = new Mock<IFibonacciNumberGenerator>();
            summer = new Mock<INumberSummer>();
            UnderTest = new SumEvenFibonacciNumbersEngine(generator.Object, summer.Object);
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(6)]
        [DataRow(17)]
        public void Sum_even_numbers_from_generated_fibonacci_list(int expectedResult)
        {
            var limit = 2;
            var expectedFibonacciResult = new List<int> { 1, 2, 6 };
            generator.Setup(x => x.GenerateToLimit(limit)).Returns(expectedFibonacciResult);
            summer.Setup(x => x.SumEven(expectedFibonacciResult)).Returns(expectedResult);

            var result = UnderTest.SumToLimit(limit);

            generator.Verify(x => x.GenerateToLimit(limit), Times.Once());
            summer.Verify(x => x.SumEven(expectedFibonacciResult), Times.Once());
            Assert.AreEqual(expectedResult, result);
        }
    }
}
