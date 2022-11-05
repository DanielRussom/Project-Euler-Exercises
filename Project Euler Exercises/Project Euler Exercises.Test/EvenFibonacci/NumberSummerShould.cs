﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections.Generic;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class NumberSummerShould
    {
        [TestMethod]
        [DataRow (0, new int[]{ })]
        [DataRow(2, new int[] { 2 })]
        [DataRow(4, new int[] { 2, 2 })]
        [DataRow(10, new int[] { 8, 2 })]
        public void Sum_all_numbers_in_list(int expected, int[] input)
        {
            var underTest = new NumberSummer();

            var result = underTest.SumEven(new List<int>(input));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, new int[] { 1 })]
        [DataRow(2, new int[] { 2, 5 })]
        public void Not_include_odd_numbers_in_sum(int expected, int[] input)
        {
            var underTest = new NumberSummer();

            var result = underTest.SumEven(new List<int>(input));

            Assert.AreEqual(expected, result);
        }
    }
}
