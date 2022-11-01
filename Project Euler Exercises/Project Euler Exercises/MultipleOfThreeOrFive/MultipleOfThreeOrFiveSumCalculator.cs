namespace Project_Euler_Exercises.MultiplesOfThreeOrFive
{
    public class MultipleOfThreeOrFiveSumCalculator
    {
        private readonly int[] values = new int[]{5};

        public int SumTo(int limit)
        {
            var result = 0;

            for(int count = 1; count <= limit; count++)
            {
                if(count % 3 == 0)
                {
                    result += count;
                }
            }

            foreach (var value in values)
            {
                if (limit >= value)
                {
                    result += value;
                }
            }

            return result;
        }
    }
}