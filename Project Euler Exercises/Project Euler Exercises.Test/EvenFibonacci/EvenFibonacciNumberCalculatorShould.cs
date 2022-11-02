using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class EvenFibonacciNumberCalculatorShould
    {
        [TestMethod ("Calculate expected sum under given limit")]
        [DataRow(1, 0)]
        [DataRow(2, 2)]
        [DataRow(3, 2)]
        [DataRow(4, 6)]
        public void Calculate_expected_result(int limit, int expected)
        {
            var underTest = new EvenFibonacciNumberCalculator();

            var result = underTest.SumEvenNumbersTo(limit);

            Assert.AreEqual(expected, result);
        }
    }
}
