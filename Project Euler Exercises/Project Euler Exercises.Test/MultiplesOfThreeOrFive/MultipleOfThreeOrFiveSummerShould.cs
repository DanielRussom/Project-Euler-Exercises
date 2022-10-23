using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.MultiplesOfThreeOrFive;

namespace Project_Euler_Exercises.Test.MultiplesOfThreeOrFive
{
    [TestClass]
    public class MultipleOfThreeOrFiveSummerShould
    {
        [TestMethod]
        public void Calculate_0()
        {
            var underTest = new MultipleOfThreeOrFiveSummer();

            var result = underTest.SumTo(1);

            Assert.AreEqual(0, result);
        }
    }
}