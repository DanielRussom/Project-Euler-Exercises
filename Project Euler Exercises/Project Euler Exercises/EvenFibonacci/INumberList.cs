using System.Collections;

namespace Project_Euler_Exercises.EvenFibonacci
{
    public interface INumberList
    {
        int Sum();
        IReadOnlyCollection<int> GetNumbers();
    }
}
