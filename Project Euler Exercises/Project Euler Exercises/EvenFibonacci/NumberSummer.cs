namespace Project_Euler_Exercises.EvenFibonacci
{
    public class NumberSummer : INumberSummer
    {
        public int SumEven(List<int> expectedFibonacciResult)
        {
            if (expectedFibonacciResult.Any())
            {
                return expectedFibonacciResult.First();
            }

            return 0;
        }
    }
}