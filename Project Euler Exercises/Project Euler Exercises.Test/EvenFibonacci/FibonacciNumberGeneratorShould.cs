using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections.Generic;

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

        [TestMethod]
        public void Generate_1()
        {
            var limit = 1;
            var expectedResult = new List<int> { 1 };
            var underTest = new FibonacciNumberGenerator();

            var result = underTest.GenerateToLimit(limit);

            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
