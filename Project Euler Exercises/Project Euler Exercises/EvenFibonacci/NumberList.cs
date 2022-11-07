using System.Collections;

namespace Project_Euler_Exercises.EvenFibonacci
{
    public class NumberList : INumberList
    {
        private readonly List<int> topSecretNumbers;

        public NumberList(List<int> numbers)
        {
            this.topSecretNumbers = numbers;
        }

        public IReadOnlyCollection<int> GetNumbers()
        {
            return topSecretNumbers;
        }

        public int SumEven()
        {
            IEnumerable<int> evenNumbers = GetEvenNumbers();
            return evenNumbers.Sum();
        }

        private IEnumerable<int> GetEvenNumbers()
        {
            return topSecretNumbers.Where(number => IsEven(number));
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}