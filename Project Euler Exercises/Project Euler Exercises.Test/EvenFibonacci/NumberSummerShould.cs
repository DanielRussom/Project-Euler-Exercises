using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections.Generic;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class NumberSummerShould
    {
        [TestMethod]
        public void Calculate_0_from_empty_list()
        {
            var underTest = new NumberSummer();
            var expected = 0;
            var input = new List<int>();

            var result = underTest.SumEven(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_2_for_list_containing_only_2()
        {
            var underTest = new NumberSummer();
            var expected = 2;
            var input = new List<int> { 2 };

            var result = underTest.SumEven(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_4_for_list_containing_2_twice()
        {
            var underTest = new NumberSummer();
            var expected = 4;
            var input = new List<int> { 2, 2 };

            var result = underTest.SumEven(input);

            Assert.AreEqual(expected, result);
        }
    }
}
