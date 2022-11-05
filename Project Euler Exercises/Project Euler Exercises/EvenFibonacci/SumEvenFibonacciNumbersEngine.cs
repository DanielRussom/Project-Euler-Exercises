namespace Project_Euler_Exercises.EvenFibonacci
{
    public class SumEvenFibonacciNumbersEngine
    {
        private readonly IFibonacciNumberGenerator fibonacciGenerator;

        public SumEvenFibonacciNumbersEngine(IFibonacciNumberGenerator fibonacciGenerator)
        {
            this.fibonacciGenerator = fibonacciGenerator;
        }

        public int SumToLimit(int limit)
        {
            var generatedNumbers = fibonacciGenerator.GenerateNumbersToLimit(limit);

            return generatedNumbers.SumEven();
        }
    }
}