namespace Project_Euler_Exercises.EvenFibonacci
{
    public class FibonacciNumberGenerator : IFibonacciNumberGenerator
    {
        private int previousNumber;
        private int currentNumber;

        public INumberList GenerateNumbersToLimit(int limit)
        {
            if (limit == 0)
            {
                return new NumberList(new List<int>());
            }

            return new NumberList(GenerateFibonacciNumbers(limit));
        }

        private List<int> GenerateFibonacciNumbers(int limit)
        {
            ResetCurrentNumbers();
            var fibonacciNumbers = new List<int> { previousNumber, currentNumber };

            UpdateToNextFibonacciNumber();
            while (currentNumber <= limit)
            {
                fibonacciNumbers.Add(currentNumber);
                UpdateToNextFibonacciNumber();
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