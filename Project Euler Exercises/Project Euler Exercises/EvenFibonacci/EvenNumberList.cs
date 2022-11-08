using System.Collections.ObjectModel;

namespace Project_Euler_Exercises.EvenFibonacci
{
    public class EvenNumberList : NumberListDecorator
    {
        public EvenNumberList(List<int> numbers)
            : base(new NumberList(numbers))
        {
        }

        public EvenNumberList(INumberList numbers) : base(numbers)
        {
        }

        public new IReadOnlyCollection<int> GetNumbers()
        {
            return new ReadOnlyCollection<int>(GetEvenNumbers());
;
        }
        public new int Sum()
        {
            return GetEvenNumbers().Sum();
        }

        private IList<int> GetEvenNumbers()
        {
            return base.GetNumbers().Where(number => IsEven(number)).ToList();
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}