namespace Project_Euler_Exercises.EvenFibonacci
{
    public class FibonacciNumberGenerator : IFibonacciNumberGenerator
    {
        private int previousNumber;
        private int currentNumber;

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

            return GenerateFibonacciNumbers(limit);
        }

        private List<int> GenerateFibonacciNumbers(int limit)
        {
            ResetCurrentNumbers();
            var fibonacciNumbers = new List<int> { previousNumber, currentNumber };

            for (var index = 3; index <= limit; index++)
            {
                UpdateToNextFibonacciNumber();
                fibonacciNumbers.Add(currentNumber);
            }

            return fibonacciNumbers;
        }

        private void ResetCurrentNumbers()
        {
            previousNumber = 1;
            currentNumber = 1;
        }

        private void UpdateToNextFibonacciNumber()
        {
            var temporaryPreviousNumber = currentNumber;
            currentNumber += previousNumber;
            previousNumber = temporaryPreviousNumber;
        }
    }
}