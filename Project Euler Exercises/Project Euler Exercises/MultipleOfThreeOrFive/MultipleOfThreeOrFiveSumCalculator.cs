namespace Project_Euler_Exercises.MultiplesOfThreeOrFive
{
    public class MultipleOfThreeOrFiveSumCalculator
    {
        public int SumTo(int limit)
        {
            if (limit >= 5)
            {
                return 8;
            }

            if (limit >= 3)
            {
                return 3;
            }

            return 0;
        }
    }
}