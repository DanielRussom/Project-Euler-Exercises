using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections;
using System.Collections.Generic;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class NumberListShould
    {
        [TestMethod]
        [DataRow (0, new int[]{ })]
        [DataRow(2, new int[] { 2 })]
        [DataRow(3, new int[] { 1, 2 })]
        [DataRow(10, new int[] { 8, 2 })]
        public void Sum_all_numbers_in_list(int expected, int[] input)
        {
            var underTest = new NumberList(new List<int>(input));

            var result = underTest.Sum();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new int[] { 1 })]
        [DataRow(new int[] { 2, 5 })]
        public void Get_all_numbers_in_list(int[] input)
        {
            var underTest = new NumberList(new List<int>(input));

            var result = underTest.GetNumbers();

            CollectionAssert.AreEquivalent(input, (ICollection)result);
        }
    }
}
