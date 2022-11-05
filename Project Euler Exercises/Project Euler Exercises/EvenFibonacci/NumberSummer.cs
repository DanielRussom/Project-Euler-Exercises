namespace Project_Euler_Exercises.EvenFibonacci
{
    public class NumberSummer : INumberSummer
    {
        public int SumEven(List<int> numberList)
        {
            return numberList.Where(number => number % 2 == 0).Sum();
        }
    }
}