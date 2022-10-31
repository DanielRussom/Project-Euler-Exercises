namespace Project_Euler_Exercises.MultiplesOfThreeOrFive
{
    public class MultipleOfThreeOrFiveSumCalculator
    {
        public int SumTo(int limit)
        {
            var result = 0;

            if (limit >= 5)
            {
                result += 5;
            }

            if (limit >= 3)
            {
                result += 3;
            }

            return result;
        }
    }
}