using System.Collections;

namespace Project_Euler_Exercises.EvenFibonacci
{
    public class NumberList : INumberList
    {
        private readonly List<int> numbers;

        public NumberList(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public ICollection GetNumbers()
        {
            return numbers;
        }

        public int SumEven()
        {
            IEnumerable<int> evenNumbers = GetEvenNumbers();
            return evenNumbers.Sum();
        }

        private IEnumerable<int> GetEvenNumbers()
        {
            return numbers.Where(number => IsEven(number));
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}