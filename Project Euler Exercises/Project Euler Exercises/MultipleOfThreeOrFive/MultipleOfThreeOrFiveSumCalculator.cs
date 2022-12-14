namespace Project_Euler_Exercises.MultiplesOfThreeOrFive
{
    public class MultipleOfThreeOrFiveSumCalculator
    {
        public int SumTo(int limit)
        {
            var result = 0;

            for(int count = 1; count <= limit; count++)
            {
                if (IsMultipleOfThreeOrFive(count))
                {
                    result += count;
                }
            }

            return result;
        }

        private bool IsMultipleOfThreeOrFive(int count)
        {
            return count % 3 == 0 || count % 5 == 0;
        }
    }
}