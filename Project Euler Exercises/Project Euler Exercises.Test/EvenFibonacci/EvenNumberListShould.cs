using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections;
using System.Collections.Generic;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class EvenNumberListShould
    {
        [TestMethod]
        [DataRow (0, new int[]{ })]
        [DataRow(2, new int[] { 2 })]
        [DataRow(4, new int[] { 2, 2 })]
        [DataRow(10, new int[] { 8, 2 })]
        public void Sum_all_even_numbers_in_list(int expected, int[] input)
        {
            var underTest = new EvenNumberList(new List<int>(input));

            var result = underTest.Sum();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new int[] { }, new int[] { 1 })]
        [DataRow(new int[] { 2 }, new int[] { 2, 5 })]
        public void Get_all_even_numbers_in_list(int[] expected, int[] input)
        {
            var underTest = new EvenNumberList(new List<int>(input));

            var result = underTest.GetNumbers();

            CollectionAssert.AreEquivalent(expected, (ICollection)result);
        }
    }
}
