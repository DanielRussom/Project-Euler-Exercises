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
        public void Sum_all_numbers_from_list_with_only_even_numbers()
        {
            var underTest = new NumberSummer();
            var expected = 2;
            var input = new List<int> { 2 };

            var result = underTest.SumEven(input);

            Assert.AreEqual(expected, result);
        }
    }
}
