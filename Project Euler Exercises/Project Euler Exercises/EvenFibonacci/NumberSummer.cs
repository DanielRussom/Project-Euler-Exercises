namespace Project_Euler_Exercises.EvenFibonacci
{
    public class NumberSummer : INumberSummer
    {
        public int SumEven(List<int> numberList)
        {
            var evenNumbers = numberList.Where(number => IsEven(number));
            return evenNumbers.Sum();
        }
        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}