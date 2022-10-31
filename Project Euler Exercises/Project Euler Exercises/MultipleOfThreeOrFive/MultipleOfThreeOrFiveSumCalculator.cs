namespace Project_Euler_Exercises.MultiplesOfThreeOrFive
{
    public class MultipleOfThreeOrFiveSumCalculator
    {
        private int[] values = new int[]{6, 5, 3};

        public int SumTo(int limit)
        {
            var result = 0;

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