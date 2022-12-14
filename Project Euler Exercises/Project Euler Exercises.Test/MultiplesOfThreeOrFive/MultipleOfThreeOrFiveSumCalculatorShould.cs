using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler_Exercises.MultiplesOfThreeOrFive;

namespace Project_Euler_Exercises.Test.MultiplesOfThreeOrFive
{
    [TestClass]
    public class MultipleOfThreeOrFiveSumCalculatorShould
    {
        [TestMethod ("Use input to calculate expected output")]
        [DataRow (1, 0)]
        [DataRow(2, 0)]
        [DataRow(3, 3)]
        [DataRow(4, 3)]
        [DataRow(5, 8)]
        [DataRow(6, 14)]
        [DataRow(9, 23)]
        [DataRow(10, 33)]
        [DataRow(12, 45)]
        [DataRow(15, 60)]
        [DataRow(18, 78)]
        [DataRow(20, 98)]
        //[DataRow(1000, 234168)]
        public void Calculate_expected_output(int input, int expected)
        {
            var underTest = new MultipleOfThreeOrFiveSumCalculator();

            var result = underTest.SumTo(input);

            Assert.AreEqual(expected, result);
        }
    }
}