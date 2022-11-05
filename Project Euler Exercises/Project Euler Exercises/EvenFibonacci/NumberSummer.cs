namespace Project_Euler_Exercises.EvenFibonacci
{
    public class NumberSummer : INumberSummer
    {
        public int SumEven(List<int> numberList)
        {
            return numberList.Sum();
        }
    }
}