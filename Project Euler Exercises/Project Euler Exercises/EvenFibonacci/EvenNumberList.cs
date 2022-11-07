using System.Collections;
using System.Collections.ObjectModel;

namespace Project_Euler_Exercises.EvenFibonacci
{
    public class EvenNumberList : INumberList
    {
        private readonly List<int> numbers;

        public EvenNumberList(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public EvenNumberList(INumberList numbers)
        {
            this.numbers = numbers.GetNumbers().ToList();
        }

        public IReadOnlyCollection<int> GetNumbers()
        {
            return new ReadOnlyCollection<int>(GetEvenNumbers());
;
        }
        public int Sum()
        {
            return GetEvenNumbers().Sum();
        }

        private IList<int> GetEvenNumbers()
        {
            return numbers.Where(number => IsEven(number)).ToList();
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}