namespace Project_Euler_Exercises.EvenFibonacci
{
    public class FibonacciNumberGenerator : IFibonacciNumberGenerator
    {
        public List<int> GenerateToLimit(int limit)
        {
            var fibonacciNumbers = new List<int>();

            var previousNumber = 1;
            var currentNumber = 1;

            if (limit > 0)
            {
                fibonacciNumbers.Add(currentNumber);
            }

            if (limit > 1)
            {
                fibonacciNumbers.Add(currentNumber);
            }

            for (var index = 3; index <= limit; index++)
            {
                var oldCurrentNumber = currentNumber;
                currentNumber += previousNumber;
                previousNumber = oldCurrentNumber;

                fibonacciNumbers.Add(currentNumber);
            }

            return fibonacciNumbers;
        }
    }
}