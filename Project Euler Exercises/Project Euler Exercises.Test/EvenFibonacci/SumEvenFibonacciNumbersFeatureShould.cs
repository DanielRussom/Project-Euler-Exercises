using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;

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

            var fibonacciGenerator = new FibonacciNumberGenerator();

            var numberEngine = new SumEvenFibonacciNumbersEngine(fibonacciGenerator);

            var result = numberEngine.SumToLimit(limit);

            Assert.AreEqual(expected, result);
        }
    }
}
