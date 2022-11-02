using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class EvenFibonacciNumberCalculatorShould
    {
        [TestMethod]
        public void Calculate_0()
        {
            var underTest = new EvenFibonacciNumberCalculator();
            var limit = 1;

            var result = underTest.SumEvenNumbersTo(limit);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calculate_2()
        {
            var underTest = new EvenFibonacciNumberCalculator();
            var limit = 2;

            var result = underTest.SumEvenNumbersTo(limit);

            Assert.AreEqual(2, result);
        }
    }
}
