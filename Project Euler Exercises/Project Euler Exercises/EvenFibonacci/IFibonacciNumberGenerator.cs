namespace Project_Euler_Exercises.EvenFibonacci
{
    public interface IFibonacciNumberGenerator
    {
        public INumberList GenerateNumbersToLimit(int limit);
    }
}