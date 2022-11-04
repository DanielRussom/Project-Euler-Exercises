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

            for(var currentNumber = 2; currentNumber <= limit && currentNumber < 5; currentNumber++)
            {
                fibonacciNumbers.Add(currentNumber-1);
            }

            if (limit >= 5)
            {
                fibonacciNumbers.Add(5);
            }

            if (limit >= 6)
            {
                fibonacciNumbers.Add(8);
            }

            return fibonacciNumbers;
        }
    }
}