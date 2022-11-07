using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections;
using System.Collections.ObjectModel;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class FibonacciNumberGeneratorShould
    {
        [TestMethod]
        [DataRow(0, new int[] { })]
        [DataRow(1, new int[] { 1, 1 })]
        [DataRow(2, new int[] { 1, 1, 2 })]
        [DataRow(3, new int[] { 1, 1, 2, 3 })]
        [DataRow(4, new int[] { 1, 1, 2, 3 })]
        [DataRow(5, new int[] { 1, 1, 2, 3, 5 })]
        [DataRow(8, new int[] { 1, 1, 2, 3, 5, 8 })]
        public void Generate_expected_number_list(int limit, int[] expectedResult)
        {
            var underTest = new FibonacciNumberGenerator();

            var result = underTest.GenerateNumbersToLimit(limit);

            CollectionAssert.AreEqual(expectedResult, (ICollection)result.GetNumbers());
        }
    }
}
