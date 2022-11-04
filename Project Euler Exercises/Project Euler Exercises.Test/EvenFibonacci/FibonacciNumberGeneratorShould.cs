using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class FibonacciNumberGeneratorShould
    {
        [TestMethod]
        public void Generate_empty_list()
        {
            var limit = 0;
            var underTest = new FibonacciNumberGenerator();

            var result = underTest.GenerateToLimit(limit);

            Assert.IsTrue(result.Count == 0);
        }
    }
}
