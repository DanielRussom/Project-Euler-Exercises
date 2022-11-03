namespace Project_Euler_Exercises.EvenFibonacci
{
    public class SumEvenFibonacciNumbersEngine
    {
        private readonly IFibonacciNumberGenerator generator;

        public SumEvenFibonacciNumbersEngine()
        {
        }

        public SumEvenFibonacciNumbersEngine(IFibonacciNumberGenerator generator)
        {
            this.generator = generator;
        }

        public object SumToLimit(int limit)
        {
            generator.GenerateToLimit(limit);


            return 2;
        }
    }
}