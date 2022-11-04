namespace Project_Euler_Exercises.EvenFibonacci
{
    public class FibonacciNumberGenerator : IFibonacciNumberGenerator
    {
        public List<int> GenerateToLimit(int limit)
        {
            var fibonacciNumbers = new List<int>();

            if (limit > 0)
            {
                fibonacciNumbers.Add(1);
            }

            if (limit > 1)
            {
                fibonacciNumbers.Add(1);
            }

            if (limit > 2)
            {
                fibonacciNumbers.Add(2);
            }

            return fibonacciNumbers;
        }
    }
}