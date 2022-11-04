namespace Project_Euler_Exercises.EvenFibonacci
{
    public class FibonacciNumberGenerator : IFibonacciNumberGenerator
    {
        public List<int> GenerateToLimit(int limit)
        {
            if(limit > 0)
            {
                return new List<int> { limit };
            }

            return new List<int>();
        }
    }
}