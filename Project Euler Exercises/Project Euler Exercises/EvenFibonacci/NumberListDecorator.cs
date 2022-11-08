namespace Project_Euler_Exercises.EvenFibonacci
{
    public abstract class NumberListDecorator : INumberList
    {
        private readonly INumberList numberList;

        public NumberListDecorator(INumberList numberList)
        {
            this.numberList = numberList;
        }
        public int Sum()
        {
            return numberList.Sum();
        }

        public IReadOnlyCollection<int> GetNumbers()
        {
            return numberList.GetNumbers();
        }
    }
}
