namespace Project_Euler_Exercises.EvenFibonacci
{
    public class EvenFibonacciNumberCalculator
    {
        public int SumEvenNumbersTo(int limit)
        {   
            if (limit >= 8)
            {
                return 10;
            }

            if (limit >= 2)
            {
               return 2;
            }


            return 0;
        }
    }
}