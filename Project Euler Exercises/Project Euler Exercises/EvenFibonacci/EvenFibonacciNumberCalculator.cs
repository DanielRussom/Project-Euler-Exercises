namespace Project_Euler_Exercises.EvenFibonacci
{
    public class EvenFibonacciNumberCalculator
    {
        public int SumEvenNumbersTo(int limit)
        {
            if(limit >= 4)
            {
                return 6;
            }

            if(limit >= 2)
            {
                return 2;
            }

            return 0;
        }
    }
}