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
            throw new NotImplementedException();
        }
    }
}