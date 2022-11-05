namespace Project_Euler_Exercises.EvenFibonacci
{
    public class NumberSummer : INumberSummer
    {
        public int SumEven(List<int> numberList)
        {
            if (numberList.Any())
            {
                return numberList.Sum();
            }

            return 0;
        }
    }
}