using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections.Generic;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class FibonacciNumberGeneratorShould
    {
        [TestMethod]
        [DataRow (0, new int[] { })]
        [DataRow(1, new int[] { 1 })]
        [DataRow(2, new int[] { 1, 1 })]
        public void Generate_empty_list(int limit, int[] expectedResult)
        {
            var underTest = new FibonacciNumberGenerator();

            var result = underTest.GenerateToLimit(limit);

            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
