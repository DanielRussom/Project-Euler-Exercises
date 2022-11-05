using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Project_Euler_Exercises.EvenFibonacci;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class SumEvenFibonacciNumbersEngineShould
    {
        private readonly SumEvenFibonacciNumbersEngine UnderTest;
        private readonly Mock<IFibonacciNumberGenerator> generator;
        private readonly Mock<INumberSummer> summer;

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
            var expectedFibonacciResult = new Mock<INumberList>(); 
            generator.Setup(x => x.GenerateNumbersToLimit(limit)).Returns(expectedFibonacciResult.Object);
            expectedFibonacciResult.Setup(x => x.SumEven()).Returns(expectedResult);

            var result = UnderTest.SumToLimit(limit);

            generator.Verify(x => x.GenerateNumbersToLimit(limit), Times.Once());
            Assert.AreEqual(expectedResult, result);
        }
    }
}
