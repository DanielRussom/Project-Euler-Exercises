using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.EvenFibonacci;
using System.Collections.Generic;

namespace Project_Euler_Exercises.Test.EvenFibonacci
{
    [TestClass]
    public class NumberSummerShould
    {
        [TestMethod]
        public void Calculate_0()
        {
            var underTest = new NumberSummer();
            var expected = 0;
            var input = new List<int>();

            var result = underTest.SumEven(input);

            Assert.AreEqual(expected, result);
        }
    }
}
