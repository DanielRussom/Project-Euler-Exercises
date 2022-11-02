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


            return result;
        }
    }
}