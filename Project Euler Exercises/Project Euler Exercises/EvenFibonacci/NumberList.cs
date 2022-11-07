namespace Project_Euler_Exercises.EvenFibonacci
{
    public class NumberList : INumberList
    {
        private readonly List<int> numbers;

        public NumberList(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public IReadOnlyCollection<int> GetNumbers()
        {
            return numbers;
        }

        public int Sum()
        {
            return numbers.Sum();
        }
    }
}