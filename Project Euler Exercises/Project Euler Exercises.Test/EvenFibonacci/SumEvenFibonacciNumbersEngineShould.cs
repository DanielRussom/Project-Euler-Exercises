using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections.Generic;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class SumEvenFibonacciNumbersEngineShould
    {
        [TestMethod]
        public void Output_expected_result()
        {
            var expected = 2;
            var limit = 2;

            var generator = new Mock<IFibonacciNumberGenerator>();
            var engine = new SumEvenFibonacciNumbersEngine(generator.Object);

            var result = engine.SumToLimit(limit);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Trigger_fibonacci_number_generator()
        {
            var limit = 2;
            var generator = new Mock<IFibonacciNumberGenerator>();
            generator.Setup(x => x.GenerateToLimit(limit)).Returns(new List<int>());
            var engine = new SumEvenFibonacciNumbersEngine(generator.Object);

            var result = engine.SumToLimit(limit);

            generator.Verify(x => x.GenerateToLimit(limit), Times.Once());
        }
    }
}
