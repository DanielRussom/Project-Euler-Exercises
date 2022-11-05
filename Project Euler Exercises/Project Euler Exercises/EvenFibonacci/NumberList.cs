namespace Project_Euler_Exercises.EvenFibonacci
{
    public interface INumberList
    {
        int SumEven();
    }

    public class NumberList : INumberList
    {
        private List<int> numbers;

        public NumberList(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public int SumEven()
        {
            var evenNumbers = numbers.Where(number => IsEven(number));
            return evenNumbers.Sum();
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}