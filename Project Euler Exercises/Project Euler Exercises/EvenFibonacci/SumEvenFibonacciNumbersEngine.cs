namespace Project_Euler_Exercises.EvenFibonacci
{
    public class SumEvenFibonacciNumbersEngine
    {
        private readonly IFibonacciNumberGenerator fibonacciGenerator;
        private readonly INumberSummer numberSummer;

        public SumEvenFibonacciNumbersEngine(IFibonacciNumberGenerator generator, INumberSummer numberSummer)
        {
            this.fibonacciGenerator = generator;
            this.numberSummer = numberSummer;
        }

        public object SumToLimit(int limit)
        {
            var generatedNumbers = fibonacciGenerator.GenerateToLimit(limit);
            var result = numberSummer.SumEven(generatedNumbers);

            return result;
        }
    }
}