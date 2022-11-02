using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class SumEvenFibonacciNumbersFeatureShould
    {
        [TestMethod]
        public void Calculate_sum_of_even_fibonacci_numbers_below_100()
        {
            var expected = 44;
            var limit = 100;

            var numberEngine = new SumEvenFibonacciNumbersEngine();

            var result = numberEngine.SumToLimit(limit);

            Assert.AreEqual(expected, result);
        }
    }
}
