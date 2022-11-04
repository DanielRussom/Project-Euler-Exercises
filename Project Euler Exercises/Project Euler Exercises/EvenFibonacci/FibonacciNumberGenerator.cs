namespace Project_Euler_Exercises.EvenFibonacci
{
    public class FibonacciNumberGenerator : IFibonacciNumberGenerator
    {
        public List<int> GenerateToLimit(int limit)
        {
            if (limit == 0)
            {
                return new List<int>();
            }

            if (limit == 1)
            {
                return new List<int> { 1 };
            }

            var previousNumber = 1;
            var currentNumber = 1;

            var fibonacciNumbers = new List<int> { previousNumber, currentNumber };

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