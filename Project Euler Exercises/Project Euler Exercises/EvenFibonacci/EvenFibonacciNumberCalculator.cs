namespace Project_Euler_Exercises.EvenFibonacci
{
    public class EvenFibonacciNumberCalculator
    {
        public int SumEvenNumbersTo(int limit)
        {
            var result = 0;

            if (limit >= 2)
            {
                result += 2;
            }

            if (limit >= 4)
            {
                result += 4;
            }

            return result;
        }
    }
}