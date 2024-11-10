using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KiselevEA.Sprint4.Task5.V15.Lib
{
    public class DataService : ISprint4Task5V15
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
