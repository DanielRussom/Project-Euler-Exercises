namespace Project_Euler_Exercises.EvenFibonacci
{
    public class SumEvenFibonacciNumbersEngine
    {
        private readonly IFibonacciNumberGenerator fibonacciGenerator;
        private readonly INumberSummer numberSummer;

        public SumEvenFibonacciNumbersEngine(IFibonacciNumberGenerator fibonacciGenerator, INumberSummer numberSummer)
        {
            this.fibonacciGenerator = fibonacciGenerator;
            this.numberSummer = numberSummer;
        }

        public int SumToLimit(int limit)
        {
            var generatedNumbers = fibonacciGenerator.GenerateToLimit(limit);

            return numberSummer.SumEven(generatedNumbers);
        }
    }
}